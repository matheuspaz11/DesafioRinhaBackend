namespace DesafioRinhaBackend.Models.DTOs
{
    public class PersonDTO
    {
        public string Surname { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> Stack { get; set; }
    }
}
