using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interface;

namespace EXE201_HOMIE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryServices _Categoryservices;

        public CategoryController(ICategoryServices categoryservices)
        {
            _Categoryservices = categoryservices;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getAll()
        {
            var response = await _Categoryservices.getAllCategory();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        } 
        [HttpGet("getById/{id}")]
        public async Task<IActionResult> getbyId([FromRoute] int id)
        {
            var response = await _Categoryservices.getCategoryById(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Message });
        }

    }
}
