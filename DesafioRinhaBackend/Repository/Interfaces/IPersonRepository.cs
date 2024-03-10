using DesafioRinhaBackend.Models.Entities;

namespace DesafioRinhaBackend.Repository.Interfaces
{
    public interface IPersonRepository : IBaseRepository
    {
        Task<Person> GetPersonByIdAsync(int id);
    }
}
