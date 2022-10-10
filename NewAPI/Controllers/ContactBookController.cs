using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactBookController : ControllerBase
    {
        [HttpGet("GetContacts")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("CreateContact")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut("UpdateContact")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete("DeleteContact")]
        public IActionResult Delete()
        {
            return Ok();
        }

    }
}
