using DesafioRinhaBackend.Models.DTOs;
using DesafioRinhaBackend.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace DesafioRinhaBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IBaseRepository _repository;
        private readonly IMapper _mapper;

        public PersonController(IBaseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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