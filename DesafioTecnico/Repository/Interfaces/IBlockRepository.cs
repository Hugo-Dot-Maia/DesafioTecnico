using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IBlockRepository : IBaseRepository
    {
        Task<Block> GetById(int id);
        Task<IEnumerable<Block>> GetAll();

    }
}
