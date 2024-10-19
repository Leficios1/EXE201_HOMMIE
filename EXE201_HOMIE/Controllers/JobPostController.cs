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
        public async Task<IActionResult> getAll(int? pageNumber, int? pageSize)
        {
            var response = await _postServices.getAllJobPost(pageNumber, pageSize);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpGet("getById/{id}")]
        public async Task<IActionResult> getById([FromRoute] int id)
        {
            var response = await _postServices.GetJobPost(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

    }
}
