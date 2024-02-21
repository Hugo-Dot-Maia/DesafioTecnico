using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface ICondominiumRepository : IBaseRepository<Condominium>
    {
        Task<Condominium> GetById(int id);
        Task<IEnumerable<Condominium>> GetAll();

    }
}
