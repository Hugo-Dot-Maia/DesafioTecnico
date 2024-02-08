using DesafioTecnico.Model.Dto;

namespace DesafioTecnico.Service.Interfaces
{
    public interface IResidentService
    {
        Task<ResidentDto> GetById(int id);
        Task<IEnumerable<ResidentDto>> GetAll();
        Task<bool> Update(int id, ResidentDto resident);
        Task<bool> Delete(int id);
        Task<ResidentDto> Add(ResidentDto resident);
    }
}
