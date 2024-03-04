using DesafioRinhaBackend.Models.DTOs;
using DesafioRinhaBackend.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioRinhaBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IBaseRepository _repository;

        public PersonController(IBaseRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult CreatePerson(PersonDTO personDTO)
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