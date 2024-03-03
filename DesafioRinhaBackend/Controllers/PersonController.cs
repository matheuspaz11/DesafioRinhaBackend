using Microsoft.AspNetCore.Mvc;

namespace DesafioRinhaBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreatePerson()
        {
            return Ok();
        }

        [HttpGet("Id")]
        public IActionResult GetPersonById()
        {
            return Ok();
        }
    }
}