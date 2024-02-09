using DesafioTecnico.Model.Dto;

namespace DesafioTecnico.Service.Interfaces
{
    public interface ICondominiumService
    {
        Task<CondominiumDto> GetById(int id);
        Task<IEnumerable<CondominiumDto>> GetAll();
        Task<bool> Update(int id, CondominiumDto condominium);
        Task<bool> Delete(int id);
        Task<CondominiumDto> Add(CondominiumDto condominium);
    }
}
