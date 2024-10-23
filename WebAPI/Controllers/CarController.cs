using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok();
        }

       
    }

}

