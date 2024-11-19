using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;
        private readonly IMapper _mapper;

        public UserController(IUserServices userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _userService.getUserById(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("getAllUser")]
        public async Task<ActionResult<IEnumerable<UserResponseForPageDTO>>> GetUsers(int? pageNumber, int? pageSize)
        {
            var response = await _userService.getAll(pageNumber, pageSize);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpPost("create")]
        public async Task<IActionResult> createUser([FromBody] UserRequestDTO DTO)
        {
            var response = await _userService.CreateUser(DTO);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> updateUser([FromRoute] int id, UserRequestDTO DTO)
        {
            var response = await _userService.UpdateUser(id, DTO);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
        [HttpPut("updateStatus/{id}")]
        public async Task<IActionResult> updateStatusUser([FromRoute] int id, bool status)
        {
            var response = await _userService.UpdateStatusUser(id, status);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
    }
}
