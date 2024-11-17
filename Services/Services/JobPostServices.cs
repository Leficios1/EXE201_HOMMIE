using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class JobPostServices : IPostServices
    {
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public JobPostServices(HomieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<JobPostResponseDTO>> CreateJobPost(JobPostRequestDTO post)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var result = new StatusResponse<JobPostResponseDTO>();
                decimal price = 0;
                if (post.Categorys != null && post.Categorys.Any())
                {
                    foreach (var category in post.Categorys)
                    {
                        var data = await _context.Category.Where(x => x.Id == category.CategoryId).SingleOrDefaultAsync();
                        if (data != null)
                        {
                            price += data.Price;
                        }
                    }
                }
                var postingFee = price + (price * 0.15m);
                if (post == null)
                {
                    result.statusCode = HttpStatusCode.BadRequest;
                    result.Message = "Invalid job post request data.";
                    return result;
                }

                var dataUser = await _context.Users.Where(x => x.UserId == post.UserId).SingleOrDefaultAsync();
                if (dataUser.RoleId == 2)
                {
                    if (post.NumberOfFloors == null || post.SquareMeters == null)
                    {
                        result.statusCode = HttpStatusCode.BadRequest;
                        result.Message = "SquareMeters and NumberOfFloors are required for Customer";
                        return result;
                    }
                    var wallet = await _context.EWallets.FirstOrDefaultAsync(w => w.UserId == post.UserId);
                    if (wallet == null)
                    {
                        result.statusCode = HttpStatusCode.NotFound;
                        result.Message = "User does not have an e-wallet.";
                        return result;
                    }

                    if (wallet.Balance < postingFee)
                    {
                        result.statusCode = HttpStatusCode.BadRequest;
                        result.Message = "Insufficient balance to post a job.";
                        return result;
                    }

                    wallet.Balance -= postingFee;
                    wallet.UpdatedAt = DateTime.UtcNow;
                    _context.EWallets.Update(wallet);

                    var transactionHistory = new TransactionHistory
                    {
                        WalletId = wallet.WalletId,
                        UserId = post.UserId,
                        TransactionType = "Payment",
                        Amount = -postingFee,
                        TransactionDate = DateTime.UtcNow,
                        Description = "Job post fee for " + post.Title
                    };
                    await _context.TransactionHistories.AddAsync(transactionHistory);

                    // Tạo JobPost
                    var jobPost = _mapper.Map<JobPost>(post);
                    jobPost.Status = "Waiting";
                    jobPost.Price = price;
                    jobPost.JobType = 1;
                    await _context.JobPosts.AddAsync(jobPost);
                    await _context.SaveChangesAsync();

                    //Tạo categoryJobPost
                    if (post.Categorys != null && post.Categorys.Any())
                    {
                        foreach (var category in post.Categorys)
                        {
                            var jobPostCategory = new CategoryJobPost
                            {
                                JobPostId = jobPost.JobId,
                                CategoryId = category.CategoryId
                            };
                            await _context.CategoryJobPosts.AddAsync(jobPostCategory);
                        }
                    }
                    await _context.SaveChangesAsync();
                    var mapper = _mapper.Map<JobPostResponseDTO>(jobPost);
                    result.Data = mapper;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Job post created successfully.";
                }
                else if (dataUser.RoleId == 3)
                {
                    var jobPost = _mapper.Map<JobPost>(post);
                    jobPost.Status = "Waiting";
                    jobPost.Price = price;
                    jobPost.JobType = 2;
                    await _context.JobPosts.AddAsync(jobPost);
                    await _context.SaveChangesAsync();
                    if (post.Categorys != null && post.Categorys.Any())
                    {
                        foreach (var category in post.Categorys)
                        {
                            var jobPostCategory = new CategoryJobPost
                            {
                                JobPostId = jobPost.JobId,
                                CategoryId = category.CategoryId
                            };
                            await _context.CategoryJobPosts.AddAsync(jobPostCategory);
                        }
                    }
                    else
                    {
                        result.Data = null;
                        result.statusCode = HttpStatusCode.BadRequest;
                        result.Message = "You don't have permission to create JobPost";
                        return result;
                    }
                    await _context.SaveChangesAsync();
                    var mapper = _mapper.Map<JobPostResponseDTO>(jobPost);
                    result.Data = mapper;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Job post created successfully.";
                }
                else
                {
                    result.Data = null;
                    result.statusCode = HttpStatusCode.BadRequest;
                    result.Message = "This account doesn't have permission to post job!";
                }
                // Xác nhận giao dịch
                await transaction.CommitAsync();
                return result;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception("Transaction failed: " + ex.Message);
            }
        }


        public Task<StatusResponse<JobPostResponseDTO>> DeleteJobPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<StatusResponse<List<JobPostResponseDTO>>> getAllJobPost(int? pageNumber, int? pageSize, string? filter, string? OrderBy)
        {
            try
            {
                var result = new StatusResponse<List<JobPostResponseDTO>>();

                int currentPage = pageNumber ?? 1;
                int currentPageSize = pageSize ?? 10;

                IQueryable<JobPost> query = _context.JobPosts.Include(x => x.CategoryJobPosts).ThenInclude(j => j.Category);

                if (!string.IsNullOrEmpty(filter))
                {
                    var propertyInfo = typeof(JobPost).GetProperty(filter,
                        BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                    if (propertyInfo != null)
                    {
                        query = OrderBy?.ToLower() == "asc"
                            ? query.OrderBy(e => EF.Property<object>(e, propertyInfo.Name))
                            : query.OrderByDescending(e => EF.Property<object>(e, propertyInfo.Name));
                    }
                    else
                    {
                        query = query.OrderByDescending(jp => jp.JobId);
                    }
                }
                else
                {
                    query = query.OrderByDescending(jp => jp.JobId);
                }

                var data = await query.Skip((currentPage - 1) * currentPageSize)
                              .Take(currentPageSize).ToListAsync();

                var mapper = _mapper.Map<List<JobPostResponseDTO>>(data);

                var totalItems = await query.CountAsync();

                if (data != null)
                {
                    result.Data = mapper;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Successfull";
                    result.TotalItems = totalItems;
                    result.TotalPages = (int)Math.Ceiling((double)totalItems / currentPageSize);
                }
                else
                {
                    result.statusCode = HttpStatusCode.NotFound;
                    result.Message = "No job posts found.";
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<JobPostResponseDTO>> GetJobPost(int id)
        {
            try
            {
                var result = new StatusResponse<JobPostResponseDTO>();
                var data = await _context.JobPosts.
                                Include(x => x.CategoryJobPosts).
                                ThenInclude(jpd => jpd.Category).
                                Where(x => x.JobId == id).SingleOrDefaultAsync();
                if (data != null)
                {
                    var mapper = _mapper.Map<JobPostResponseDTO>(data);
                    result.Data = mapper;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Successful";
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<List<JobPostResponseDTO>>> GetJobPostByUserId(int userId)
        {
            var response = new StatusResponse<List<JobPostResponseDTO>>();
            var data = await _context.JobPosts.Where( x => x.EmployerId == userId).Include(x => x.CategoryJobPosts).ThenInclude(j => j.Category).ToListAsync();
            if (data == null)
            {
                response.statusCode = HttpStatusCode.NotFound;
                response.Message = "Not found user";
                return response;
            }
            var mapper = _mapper.Map<List<JobPostResponseDTO>>(data);
            response.Data = mapper;
            response.statusCode = HttpStatusCode.OK;
            response.Message = "Succesful";
            return response;
        }

        public async Task<StatusResponse<List<JobPostResponseDTO>>> searchJobPostByCategory(int? pageNumber, int? pageSize, string category)
        {
            try
            {
                var result = new StatusResponse<List<JobPostResponseDTO>>();

                int currentPage = pageNumber ?? 1;
                int currentPageSize = pageSize ?? 10;

                var query = _context.JobPosts
                                    .Include(x => x.CategoryJobPosts)
                                    .ThenInclude(jpc => jpc.Category)
                                    .Where(x => x.CategoryJobPosts.Any(c => c.Category.CategoryName == category));

                int totalItems = await query.CountAsync();

                var data = await query
                                .Skip((currentPage - 1) * currentPageSize)
                                .Take(currentPageSize)
                                .ToListAsync();

                if (data != null && data.Count > 0)
                {
                    var mapper = _mapper.Map<List<JobPostResponseDTO>>(data);
                    result.Data = mapper;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Successfull";
                    result.TotalItems = totalItems;
                    result.TotalPages = (int)Math.Ceiling((double)totalItems / currentPageSize);
                }
                else
                {
                    result.statusCode = HttpStatusCode.NotFound;
                    result.Message = "No job posts found for the given category.";
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching job posts: " + ex.Message);
            }
        }


        public Task<StatusResponse<JobPostResponseDTO>> UpdateJobPost(JobPostRequestDTO post)
        {
            throw new NotImplementedException();
        }
    }
}
