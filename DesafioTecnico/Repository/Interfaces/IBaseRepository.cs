using System.Threading.Tasks;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<bool> SaveChangesAsync();
        
    }
}
