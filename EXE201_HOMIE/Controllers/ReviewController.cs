using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewServices _reviewServices;

        public ReviewController(IReviewServices reviewServices)
        {
            _reviewServices = reviewServices;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateReview([FromBody] ReviewRequestDTO dto)
        {
            var response = await _reviewServices.create(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpDelete("Deleted/{Reviewid}")]
        public async Task<IActionResult> Deleted([FromRoute] int Reviewid)
        {
            var response = await _reviewServices.deleted(Reviewid);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpGet("getReviewByJobPost/{jobPostId}")]
        public async Task<IActionResult> getReviewByJobPostId([FromRoute] int jobPostId)
        {
            var response = await _reviewServices.getByJobPostId(jobPostId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
    }
}
