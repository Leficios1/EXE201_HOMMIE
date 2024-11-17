using DAO.DTO.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IReviewServices
    {
        Task<StatusResponse<ReviewResponseDTO>> create(ReviewRequestDTO dto);
        Task<StatusResponse<bool>> deleted(int reviewId);
        Task<StatusResponse<List<ReviewResponseDTO>>> getByJobPostId(int jobPostId);

    }
}
