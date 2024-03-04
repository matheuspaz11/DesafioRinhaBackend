using DesafioRinhaBackend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioRinhaBackend.Context
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<Person> Person {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var person = modelBuilder.Entity<Person>();

            person.ToTable("tb_person");
            person.HasKey(x => x.Id);
            person.Property(x => x.Id).ValueGeneratedOnAdd();
            person.Property(x => x.Surname).HasColumnType("varchar(32)").IsRequired();
            person.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();
            person.Property(x => x.BirthDate).IsRequired();
        }
    }
}