using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IResidentRepository : IBaseRepository<Resident>
    {
        Task<Resident> GetById(int id);
        Task<IEnumerable<Resident>> GetAll();
    }
}
