using DAO.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authService;
        public AuthController(IAuthServices authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthRequestDTO dto)
        {
            var response = await _authService.LoginAccount(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpGet("login/get-user-by-token/{token}")]
        public async Task<IActionResult> GetUserByToken([FromRoute] string token)
        {
            var result = await _authService.GetUserByToken(token);
            return Ok(result);
        }
        [Authorize(Roles = "1, 2")]
        [HttpGet("test")]
        public async Task<IActionResult> HelloWord()
        {
            return Ok("Completed to authorize");
        } 
        [Authorize(Roles = "1, 2")]
        [HttpGet("testDeploy")]
        public async Task<IActionResult> Test()
        {
            return Ok("Completed to authorize");
        }
    }
}
