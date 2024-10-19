using DAO.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IProfilesServices _profilesService;

        public ProfilesController(IProfilesServices profilesService)
        {
            _profilesService = profilesService;
        }

        [HttpGet("getProfiles/{userId}")]
        public async Task<IActionResult> getProfilesByUserId([FromRoute] int userId)
        {
            var response = await _profilesService.getProfile(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpPost("CreateProfiles")]
        public async Task<IActionResult> CreateProfiles([FromBody] ProfilesRequestDTO dto )
        {
            var response = await _profilesService.CreateProfiles(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpPut("UpdateProfiles/{id}")]
        public async Task<IActionResult> UpdateProfiles([FromRoute] int id,[FromBody] ProfilesRequestDTO dto)
        {
            var response = await _profilesService.UpdateProfiles(id,dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
    }
}
