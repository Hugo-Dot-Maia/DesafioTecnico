using DesafioTecnico.Context;
using DesafioTecnico.Repository.Interfaces;

namespace DesafioTecnico.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        private readonly DesafioTecnicoContext _context;

        public BaseRepository(DesafioTecnicoContext context) 
        {
            _context = context;
        }

        public T Create(T entity)
        {
            _context.Add(entity);
            return entity;
        }

        public bool Delete(T entity)
        {
            _context.Remove(entity);
            return true;
        }     

        public bool Update(T entity)
        {
            _context.Update(entity);
            return true;
        }
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
