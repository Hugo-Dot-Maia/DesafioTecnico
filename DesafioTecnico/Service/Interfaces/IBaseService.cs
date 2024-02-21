namespace DesafioTecnico.Service.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<T> Add(T entity);
        Task<bool> Update(int id,T entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}
