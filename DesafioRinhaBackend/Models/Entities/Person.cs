namespace DesafioRinhaBackend.Models.Entities
{
    public class Person
    {
        public long Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> Stack { get; set; }
    }
}
