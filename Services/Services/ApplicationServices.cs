using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ApplicationServices : IApplication
    {
        private readonly IBaseRepository<Application> _applicationRepository;
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public ApplicationServices(IBaseRepository<Application> applicationRepository, IMapper mapper, HomieContext context)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<StatusResponse<bool>> applicationJobPost(ApplicationRequestDTO dto)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var result = new StatusResponse<bool>();
                var data = _mapper.Map<Application>(dto);
                data.Status = "Pending";
                data.AppliedAt = DateTime.UtcNow;
                await _applicationRepository.AddAsync(data);
                await _applicationRepository.SaveChangesAsync();
                result.Data = true;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successful";
                transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<bool>> changeStatus(int id, string status)
        {
            var transaction = _context.Database.BeginTransaction();
            try
            {
                var result = new StatusResponse<bool>();
                var data = await _applicationRepository.GetById(id);
                if (data == null)
                {
                    result.Data = false;
                    result.statusCode = HttpStatusCode.BadRequest;
                    result.Message = "Not Found Application";
                    return result;
                }
                data.Status = status;
                var jobPost = await _context.JobPosts.Where(x => x.JobId == data.JobId).SingleOrDefaultAsync();
                var myAccount = _context.Users.Where(x => x.RoleId == 1).SingleOrDefaultAsync();
                if (data.Status.ToUpper().Equals("Done".ToUpper()))
                {
                    if (jobPost != null)
                    {
                        if (jobPost.JobType == 1) // For User Post
                        {
                            var eWallet = await _context.EWallets.Where(x => x.UserId == data.WorkerId).SingleOrDefaultAsync();
                            if (eWallet != null)
                            {
                                eWallet.Balance += jobPost.Price;
                                eWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(eWallet);

                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = eWallet.WalletId,
                                    UserId = eWallet.UserId,
                                    TransactionType = "Receive money",
                                    Amount = jobPost.Price,
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Money for job post "
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                            }
                            var myWallet = await _context.EWallets.Where(x => x.UserId == myAccount.Id).SingleOrDefaultAsync();
                            if (myWallet != null)
                            {
                                myWallet.Balance += jobPost.Price * 0.15m;
                                myWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(myWallet);

                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = myWallet.WalletId,
                                    UserId = myWallet.UserId,
                                    TransactionType = "Job Free",
                                    Amount = jobPost.Price * 0.15m,
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Job Free"
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                            }
                            _applicationRepository.Update(data);
                            await _context.SaveChangesAsync();
                            result.Data = true;
                            result.statusCode = HttpStatusCode.OK;
                            result.Message = "Successful";
                        }
                        else if (jobPost.JobType == 2)// For Employee Post
                        {
                            // Wallet of User
                            var eWallet = await _context.EWallets.Where(x => x.UserId == data.WorkerId).SingleOrDefaultAsync();
                            if (eWallet != null)
                            {
                                eWallet.Balance -= jobPost.Price + (jobPost.Price * 0.15m);
                                eWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(eWallet);
                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = eWallet.WalletId,
                                    UserId = eWallet.UserId,
                                    TransactionType = "Paid money",
                                    Amount = jobPost.Price + (jobPost.Price * 0.15m),
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Money for job post"
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                                await _context.SaveChangesAsync();
                            }
                            //Wallet of Employee
                            var employeeWallet = await _context.EWallets.Where(x => x.UserId == jobPost.EmployerId).SingleOrDefaultAsync();
                            if (employeeWallet != null)
                            {
                                employeeWallet.Balance += jobPost.Price;
                                employeeWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(employeeWallet);

                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = eWallet.WalletId,
                                    UserId = eWallet.UserId,
                                    TransactionType = "Receive money",
                                    Amount = jobPost.Price,
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Money for job post "
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                                await _context.SaveChangesAsync();
                            }
                            //My Wallet
                            var myWallet = await _context.EWallets.Where(x => x.UserId == myAccount.Id).SingleOrDefaultAsync();
                            if (myWallet != null)
                            {
                                myWallet.Balance += jobPost.Price * 0.15m;
                                myWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(myWallet);

                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = myWallet.WalletId,
                                    UserId = myWallet.UserId,
                                    TransactionType = "Job Free",
                                    Amount = jobPost.Price * 0.15m,
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Job Free"
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                            }
                            _applicationRepository.Update(data);
                            await _context.SaveChangesAsync();
                            result.Data = true;
                            result.statusCode = HttpStatusCode.OK;
                            result.Message = "Successful";
                        }
                    }
                }
                else if (data.Status.ToUpper().Equals("Cancel".ToUpper()))
                {
                    if (jobPost != null)
                    {
                        if (jobPost.JobType == 1) // Add money for User if this post cancel
                        {
                            var userWallet = await _context.EWallets.Where(x => x.UserId == jobPost.EmployerId).SingleOrDefaultAsync();
                            if (userWallet != null)
                            {
                                userWallet.Balance += jobPost.Price + (jobPost.Price * 0.15m);
                                userWallet.UpdatedAt = DateTime.UtcNow;
                                _context.EWallets.Update(userWallet);
                                var transactionHistory = new TransactionHistory
                                {
                                    WalletId = userWallet.WalletId,
                                    UserId = userWallet.UserId,
                                    TransactionType = "Receive money",
                                    Amount = jobPost.Price + (jobPost.Price * 0.15m),
                                    TransactionDate = DateTime.UtcNow,
                                    Description = "Refund for post cancellation"
                                };
                                await _context.TransactionHistories.AddAsync(transactionHistory);
                                _applicationRepository.Update(data);
                                await _context.SaveChangesAsync();
                                result.Data = true;
                                result.statusCode = HttpStatusCode.OK;
                                result.Message = "Successful";
                            }
                        }
                    }
                }
                transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }
    }
}
