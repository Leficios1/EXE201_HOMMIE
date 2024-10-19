using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private readonly IDashBoardServices _services;
        public DashBoardController(IDashBoardServices services)
        {
            _services = services;
        }

        [HttpGet("getTotalAmount")]
        public async Task<IActionResult> getTotalAmount()
        {
            var response = await _services.GetTotalAmountPaid();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("RenuveByMonth")]
        public async Task<IActionResult> RenuveByMonth()
        {
            var response = await _services.RenuveByMonth();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("TotalApplication")]
        public async Task<IActionResult> TotalApplication()
        {
            var response = await _services.TotalApplication();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("TotalPost")]
        public async Task<IActionResult> TotalPost()
        {
            var response = await _services.TotalPost();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

    }
}
