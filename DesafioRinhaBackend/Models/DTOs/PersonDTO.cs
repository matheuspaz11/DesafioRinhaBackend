using System.ComponentModel.DataAnnotations;

namespace DesafioRinhaBackend.Models.DTOs
{
    public class PersonDTO
    {
        [Required(ErrorMessage = "O campo Surname é obrigatório")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "O campo Name é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo BirthDate é obrigatório")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "O campo Stack é obrigatório")]
        public List<string> Stack { get; set; }
    }
}
