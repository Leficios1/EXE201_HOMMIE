using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionHistoryController : ControllerBase
    {
        private readonly ITransactionHistory _services;

        public TransactionHistoryController(ITransactionHistory services)
        {
            _services = services;
        }

        [HttpGet("getbyId/{id}")]
        public async Task<IActionResult> getByid([FromRoute] int id)
        {
            var response = await _services.getById(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("getbyUserId/{userId}")]
        public async Task<IActionResult> getByUserid([FromRoute] int userId)
        {
            var response = await _services.getByUserId(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpGet("getbyWallet/{walletId}")]
        public async Task<IActionResult> getByWalletId([FromRoute] int walletId)
        {
            var response = await _services.getByWalletId(walletId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
    }
}
