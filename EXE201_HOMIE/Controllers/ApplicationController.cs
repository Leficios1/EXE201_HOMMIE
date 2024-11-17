using DAO.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplication _applicationServices;

        public ApplicationController(IApplication applicationServices)
        {
            _applicationServices = applicationServices;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getAll()
        {
            var response = await _applicationServices.getAll();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("getbyId/{id}")]
        public async Task<IActionResult> getByid(int id)
        {
            var response = await _applicationServices.getById(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("getbyUserId/{userId}")]
        public async Task<IActionResult> getByUserId([FromRoute] int userId)
        {
            var response = await _applicationServices.getByUserId(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }


        [HttpPost("CreateApplication")]
        public async Task<IActionResult> createApplication([FromBody] ApplicationRequestDTO dto)
        {
            var response = await _applicationServices.applicationJobPost(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpPut("UpdateStatus/{id}")]
        public async Task<IActionResult> UpdateApplication([FromRoute] int id, string status)
        {
            var response = await _applicationServices.changeStatus(id, status);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

    }
}
