using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IBlockRepository : IBaseRepository<Block>
    {
        Task<Block> GetById(int id);
        Task<IEnumerable<Block>> GetAll();

    }
}
