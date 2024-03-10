using DesafioRinhaBackend.Models.DTOs;
using DesafioRinhaBackend.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DesafioRinhaBackend.Models.Entities;

namespace DesafioRinhaBackend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(PersonDTO personDTO)
        {
            Person newPerson = _mapper.Map<Person>(personDTO);

            _repository.Add(newPerson);

            return await _repository.SaveChangesAssync() ? Ok("Pessoa salva com sucesso") : BadRequest("Houve um erro, tente novamente");
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetPersonByIdAsync(int id)
        {
            var person = await _repository.GetPersonByIdAsync(id);

            var returnPerson = _mapper.Map<PersonDTO>(person);

            return returnPerson != null ? Ok(returnPerson) : BadRequest("Pessoa não encontrada");
        }
    }
}