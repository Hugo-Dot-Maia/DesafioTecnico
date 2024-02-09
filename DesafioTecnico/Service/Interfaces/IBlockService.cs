using DesafioTecnico.Model.Dto;

namespace DesafioTecnico.Service.Interfaces
{
    public interface IBlockService
    {
        Task<BlockDto> GetById(int id);
        Task<IEnumerable<BlockDto>> GetAll();
        Task<bool> Update(int id, BlockDto block);
        Task<bool> Delete(int id);
        Task<BlockDto> Add(BlockDto block);
    }
}
