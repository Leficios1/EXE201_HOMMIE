using DAO.DTO.Reponse;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface ITransactionHistory
    {
        Task<StatusResponse<List<TransactionHistory>>> getByUserId(int userId);
        Task<StatusResponse<List<TransactionHistory>>> getByWalletId(int walletId);
        Task<StatusResponse<TransactionHistory>> getById(int id);
    }
}
