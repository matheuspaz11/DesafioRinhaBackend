using DesafioRinhaBackend.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioRinhaBackend.Maps
{
    public class PersonMap : BaseMap<Person>
    {
        public PersonMap() : base("tb_person")
        {
        }

        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Surname).HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
        }
    }
}
