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
        public Task<StatusResponse<JobPost>> CreateJobPost(JobPostRequestDTO post);
        Task<StatusResponse<JobPost>> UpdateJobPost(JobPostRequestDTO post);
        Task<StatusResponse<JobPost>> DeleteJobPost(int id);
        Task<StatusResponse<JobPost>> GetJobPost(int id);
        Task<StatusResponse<List<JobPost>>> getAllJobPost(int? pageNumber, int? pageSize);
        Task<StatusResponse<List<JobPost>>> searchJobPostByCategory(int? pageNumber, int? pageSize, string category);
    }
}
