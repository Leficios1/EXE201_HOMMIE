using DAO.DTO.Reponse;
using DAO.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IAuthServices
    {
        public Task<StatusResponse<TokenReponse>> LoginAccount(AuthRequestDTO dto);
        public Task<UserByTokenResponse> GetUserByToken(string token);
    }
}
