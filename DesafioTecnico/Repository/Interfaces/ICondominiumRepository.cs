using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface ICondominiumRepository : IBaseRepository
    {
        Task<Condominium> GetById(int id);
        Task<IEnumerable<Condominium>> GetAll();

    }
}
