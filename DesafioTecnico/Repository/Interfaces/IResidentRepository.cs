using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IResidentRepository : IBaseRepository
    {
        Task<Resident> GetById(int id);
        Task<IEnumerable<Resident>> GetAll();
    }
}
