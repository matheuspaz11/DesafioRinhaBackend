using DesafioRinhaBackend.Context;
using DesafioRinhaBackend.Repository.Interfaces;

namespace DesafioRinhaBackend.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly PersonDbContext _context;

        public BaseRepository(PersonDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAssync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
