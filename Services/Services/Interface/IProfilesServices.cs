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
    public interface IProfilesServices
    {
        Task<StatusResponse<Profiles>> CreateProfiles(ProfilesRequestDTO dto);
        Task<StatusResponse<Profiles>> UpdateProfiles(int id, ProfilesRequestDTO dto);
        Task<StatusResponse<Profiles>> getProfile(int Userid);
        Task<StatusResponse<bool>> isFirstLogin(int userId);
        Task<StatusResponse<Profiles>> getProfileUserifHaveApplication(int applicationId);

    }
}
