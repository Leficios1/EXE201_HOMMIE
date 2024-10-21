using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<StatusResponse<JobPost>> CreateJobPost(JobPostRequestDTO post)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var result = new StatusResponse<JobPost>();
                var postingFee = post.Price + (post.Price * 0.15m);
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
                        result.Message = "SquareMeters and NumberOfFloors are required for Employers";
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
                        Amount = postingFee,
                        TransactionDate = DateTime.UtcNow,
                        Description = "Job post fee for " + post.Title
                    };
                    await _context.TransactionHistories.AddAsync(transactionHistory);

                    // Tạo JobPost
                    var jobPost = _mapper.Map<JobPost>(post);
                    jobPost.Status = "Waiting";
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
                    result.Data = jobPost;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Job post created successfully.";
                }
                else if (dataUser.RoleId == 3)
                {
                    var jobPost = _mapper.Map<JobPost>(post);
                    jobPost.Status = "Waiting";
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
                    await _context.SaveChangesAsync();
                    result.Data = jobPost;
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


        public Task<StatusResponse<JobPost>> DeleteJobPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<StatusResponse<List<JobPost>>> getAllJobPost(int? pageNumber, int? pageSize)
        {
            try
            {
                var result = new StatusResponse<List<JobPost>>();

                int currentPage = pageNumber ?? 1;
                int currentPageSize = pageSize ?? 10;
                var data = await _context.JobPosts
                                        .Include(x => x.CategoryJobPosts)
                                        .ThenInclude(jpd => jpd.Category)
                                        .Skip((currentPage - 1) * currentPageSize)
                                        .Take(currentPageSize)
                                        .ToListAsync();

                var totalItems = await _context.JobPosts.CountAsync();

                if (data != null && data.Count > 0)
                {
                    result.Data = data;
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

        public async Task<StatusResponse<JobPost>> GetJobPost(int id)
        {
            try
            {
                var result = new StatusResponse<JobPost>();
                var data = await _context.JobPosts.
                                Include(x => x.CategoryJobPosts).
                                ThenInclude(jpd => jpd.Category).
                                Where(x => x.JobId == id).SingleOrDefaultAsync();
                if (data != null)
                {
                    result.Data = data;
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

        public async Task<StatusResponse<List<JobPost>>> searchJobPostByCategory(int? pageNumber, int? pageSize, string category)
        {
            try
            {
                var result = new StatusResponse<List<JobPost>>();

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
                    result.Data = data;
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


        public Task<StatusResponse<JobPost>> UpdateJobPost(JobPostRequestDTO post)
        {
            throw new NotImplementedException();
        }
    }
}
