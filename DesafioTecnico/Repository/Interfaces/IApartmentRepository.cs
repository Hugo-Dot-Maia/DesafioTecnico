using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IApartmentRepository : IBaseRepository<Apartment>
    {
        Task<Apartment> GetById(int id);
        Task<IEnumerable<Apartment>> GetAll();
    }
}
