using DAO.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EWalletController : ControllerBase
    {
        private readonly IEWallet _eWallet;

        public EWalletController(IEWallet eWallet)
        {
            _eWallet = eWallet;
        }

        [HttpGet("GetEwalletByUserID/{userId}")]
        public async Task<IActionResult> getEwalletByUserId([FromRoute] int userId)
        {
            var response = await _eWallet.GetWalletFromUser(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

        [HttpPost("AddMoney")]
        public async Task<IActionResult> AddMoneyForUser([FromBody] EWalletRequest dto)
        {
            var response = await _eWallet.AddMoneytoWallet(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }
    }
}
