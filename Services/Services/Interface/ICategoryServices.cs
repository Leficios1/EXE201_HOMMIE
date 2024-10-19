using DAO.DTO.Reponse;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface ICategoryServices
    {
        Task<StatusResponse<List<CategoryResponse>>> getAllCategory();
        Task<StatusResponse<CategoryResponse>> getCategoryById(int id);
    }
}
