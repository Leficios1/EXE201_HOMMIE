using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IApplication
    {
        Task<StatusResponse<bool>> applicationJobPost(ApplicationRequestDTO dto);
        Task<StatusResponse<bool>> changeStatus(int id, string status);
        Task<StatusResponse<List<Application>>> getAll();
        Task<StatusResponse<Application>> getById(int id);
        Task<StatusResponse<List<Application>>> getByUserId(int userId);
    }
}
