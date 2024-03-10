using DesafioRinhaBackend.Context;
using DesafioRinhaBackend.Models.Entities;
using DesafioRinhaBackend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioRinhaBackend.Repository
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        private readonly PersonDbContext _context;

        public PersonRepository(PersonDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _context.Person.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
