using DesafioRinhaBackend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioRinhaBackend.Context
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<Person> Person {  get; set; }
    }
}
