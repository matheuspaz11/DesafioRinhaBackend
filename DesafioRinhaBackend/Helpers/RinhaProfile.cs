using AutoMapper;
using DesafioRinhaBackend.Models.DTOs;
using DesafioRinhaBackend.Models.Entities;

namespace DesafioRinhaBackend.Helpers
{
    public class RinhaProfile : Profile
    {
        public RinhaProfile() {
            CreateMap<Person, PersonDTO>();

            CreateMap<PersonDTO, Person>();
        }
    }
}
