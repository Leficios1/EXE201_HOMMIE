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
                var postingFee = post.Price + (post.Price * 0.05m);
                if (post == null)
                {
                    result.statusCode = HttpStatusCode.BadRequest;
                    result.Message = "Invalid job post request data.";
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
                await _context.JobPosts.AddAsync(jobPost);
                await _context.SaveChangesAsync();

                // Xác nhận giao dịch
                await transaction.CommitAsync();

                // Phản hồi thành công
                result.Data = jobPost;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Job post created successfully.";
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

        public async Task<StatusResponse<List<JobPost>>> getAllJobPost()
        {
            try
            {
                var result = new StatusResponse<List<JobPost>>();
                var data = await _context.JobPosts.ToListAsync();
                if (data != null)
                {
                    result.Data = data;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Successfull";
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
                var data = await _context.JobPosts.Where(x => x.JobId == id).SingleOrDefaultAsync();
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

        public Task<StatusResponse<JobPost>> UpdateJobPost(JobPostRequestDTO post)
        {
            throw new NotImplementedException();
        }
    }
}
