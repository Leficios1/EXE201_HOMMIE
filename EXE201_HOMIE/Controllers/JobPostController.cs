using DAO.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostController : ControllerBase
    {
        private readonly IPostServices _postServices;
        public JobPostController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> createJobPost([FromBody] JobPostRequestDTO dto)
        {
            var response = await _postServices.CreateJobPost(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> getAll(int? pageNumber, int? pageSize, string? filter, string? OrderBy)
        {
            var response = await _postServices.getAllJobPost(pageNumber, pageSize, filter, OrderBy);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message, TolalItems = response.TotalItems, TotalPage = response.TotalPages  });
        }
        [HttpGet("getById/{id}")]
        public async Task<IActionResult> getById([FromRoute] int id)
        {
            var response = await _postServices.GetJobPost(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpGet("getByUserId/{userid}")]
        public async Task<IActionResult> getByUserId([FromRoute] int userid)
        {
            var response = await _postServices.GetJobPostByUserId(userid);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

    }
}
