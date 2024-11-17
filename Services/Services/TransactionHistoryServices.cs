using DAO.DTO.Reponse;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class TransactionHistoryServices : ITransactionHistory
    {
        private readonly HomieContext _context;

        public TransactionHistoryServices(HomieContext context)
        {
            _context = context;
        }

        public async Task<StatusResponse<TransactionHistory>> getById(int id)
        {
            var result = new StatusResponse<TransactionHistory>();
            var data = await _context.TransactionHistories.FindAsync(id);
            if (data == null)
            {
                result.statusCode = System.Net.HttpStatusCode.NotFound;
                result.Message = "Not Found Transaction";
                return result;
            }
            result.Data = data;
            result.statusCode = System.Net.HttpStatusCode.OK;
            result.Message = "Succesful";
            return result;
        }

        public async Task<StatusResponse<List<TransactionHistory>>> getByUserId(int userId)
        {
            var result = new StatusResponse<List<TransactionHistory>>();
            var data = await _context.TransactionHistories.Where(x => x.UserId == userId).ToListAsync();
            if (data == null)
            {
                result.statusCode = System.Net.HttpStatusCode.NotFound;
                result.Message = "Not Found Transaction";
                return result;
            }
            result.Data = data;
            result.statusCode = System.Net.HttpStatusCode.OK;
            result.Message = "Succesful";
            return result;
        }

        public async Task<StatusResponse<List<TransactionHistory>>> getByWalletId(int walletId)
        {
            var result = new StatusResponse<List<TransactionHistory>>();
            var data = await _context.TransactionHistories.Where(x => x.WalletId == walletId).ToListAsync();
            if (data == null)
            {
                result.statusCode = System.Net.HttpStatusCode.NotFound;
                result.Message = "Not Found Transaction";
                return result;
            }
            result.Data = data;
            result.statusCode = System.Net.HttpStatusCode.OK;
            result.Message = "Succesful";
            return result;
        }
    }
}
