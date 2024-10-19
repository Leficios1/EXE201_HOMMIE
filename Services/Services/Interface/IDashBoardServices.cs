using DAO.DTO.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IDashBoardServices
    {
        public Task<StatusResponse<int>> TotalPost();
        public Task<StatusResponse<int>> TotalApplication();
        public Task<StatusResponse<List<RenuveByMonth>>> RenuveByMonth();
        public Task<StatusResponse<decimal>> GetTotalAmountPaid();
        public Task<StatusResponse<decimal>> GetTotalProfit();

    }
}
