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
    public interface IPostServices
    {
        public Task<StatusResponse<JobPostResponseDTO>> CreateJobPost(JobPostRequestDTO post);
        Task<StatusResponse<JobPostResponseDTO>> UpdateJobPost(JobPostRequestDTO post);
        Task<StatusResponse<JobPostResponseDTO>> DeleteJobPost(int id);
        Task<StatusResponse<JobPostResponseDTO>> GetJobPost(int id);
        Task<StatusResponse<List<JobPostResponseDTO>>> GetJobPostByUserId(int userId);
        Task<StatusResponse<List<JobPostResponseDTO>>> getAllJobPost(int? pageNumber, int? pageSize, string? filter, string? OrderBy);
        Task<StatusResponse<List<JobPostResponseDTO>>> searchJobPostByCategory(int? pageNumber, int? pageSize, string category);
    }
}
