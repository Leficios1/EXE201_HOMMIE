using DAO.DTO.Reponse;
using DAO.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IEWallet
    {
        Task<StatusResponse<EWalletResponse>> AddMoneytoWallet(EWalletRequest dto);
        Task<StatusResponse<EWalletResponse>> GetWalletFromUser(int userId);
    }
}
