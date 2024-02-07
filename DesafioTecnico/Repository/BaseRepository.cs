using DesafioTecnico.Context;
using DesafioTecnico.Repository.Interfaces;

namespace DesafioTecnico.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DesafioTecnicoContext _context;

        public BaseRepository(DesafioTecnicoContext context) 
        {
            _context = context;
        }

        public T Create<T>(T entity) where T : class
        {
            _context.Add(entity);
            return entity;
        }

        public bool Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            return true;
        }

        public bool Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            return true;
        }
    }
}
