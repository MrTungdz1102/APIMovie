using APIMovie.Interface;
using APIMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMovie.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly WebPhimContext _context;

        public GenericRepository(WebPhimContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
