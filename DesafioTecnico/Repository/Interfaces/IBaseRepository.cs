using System.Threading.Tasks;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IBaseRepository
    {
        T Create<T>(T entity) where T : class;
        bool Update<T>(T entity)where T: class;
        bool Delete<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();

    }
}
