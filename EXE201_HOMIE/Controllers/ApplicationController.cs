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
