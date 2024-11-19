using DAO.DTO.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.DTO.Request;
using DAO.DTO.Reponse;

namespace Services.Services.Interface
{
    public interface IUserServices
    {
        public Task<StatusResponse<UserResponseDTO>> CreateUser(UserRequestDTO dto); 
        public Task<StatusResponse<GetAllUserResponseDTO>> getAll(int? pageNumber, int? pageSize);
        public Task<StatusResponse<UserResponseDTO>> getUserById(int id);
        public Task<StatusResponse<UserResponseDTO>> UpdateUser(int userid, UserRequestDTO dto);
        public Task<StatusResponse<bool>> UpdateStatusUser(int userId, bool status);
        public Task<StatusResponse<bool>> DeletedUser(int userid); 
    }
}
