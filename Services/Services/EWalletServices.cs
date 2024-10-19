using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
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
    public class EWalletServices : IEWallet
    {
        private readonly IBaseRepository<EWallet> _eWalletRepository;
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public EWalletServices(IBaseRepository<EWallet> eWalletRepository, HomieContext context, IMapper mapper)
        {
            _eWalletRepository = eWalletRepository;
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<EWalletResponse>> AddMoneytoWallet(EWalletRequest dto)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var result = new StatusResponse<EWalletResponse>();
                var wallet = await _eWalletRepository.Get().Where(w => w.UserId == dto.UserId).FirstOrDefaultAsync();
                if (wallet == null)
                {
                    result.Message = "Not Found EWallet";
                    result.statusCode = HttpStatusCode.BadRequest;
                    return result;
                }
                wallet.Balance += dto.Balance;
                wallet.UpdatedAt = DateTime.UtcNow;
                _eWalletRepository.Update(wallet);

                var transactionHistory = new TransactionHistory
                {
                    WalletId = wallet.WalletId,
                    UserId = dto.UserId,
                    TransactionType = "Deposit",
                    Amount = dto.Balance,
                    TransactionDate = DateTime.UtcNow,
                    Description = "Deposit to wallet"
                };
                await _context.TransactionHistories.AddAsync(transactionHistory);
                await _context.SaveChangesAsync();
                var mapper = _mapper.Map<EWalletResponse>(wallet);
                result.Data = mapper;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Succesful";
                transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<EWalletResponse>> GetWalletFromUser(int userId)
        {
            try
            {
                var result = new StatusResponse<EWalletResponse>();
                var wallet = await _eWalletRepository.Get().Where(w => w.UserId == userId).FirstOrDefaultAsync();
                if (wallet == null)
                {
                    result.Message = "Not Found EWallet";
                    result.statusCode = HttpStatusCode.BadRequest;
                    return result;
                }
                var mapper = _mapper.Map<EWalletResponse>(wallet);
                result.Data = mapper;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Succesful";
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
