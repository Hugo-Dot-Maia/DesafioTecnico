using AutoMapper;
using DesafioTecnico.Model.Dto;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using DesafioTecnico.Service.Interfaces;

namespace DesafioTecnico.Service
{
    public class ResidentService : IResidentService
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;

        public ResidentService(IResidentRepository residentRepository, IMapper mapper)
        {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }
 
        public async Task<IEnumerable<ResidentDto>> GetAll()
        {
            var result = await _residentRepository.GetAll();
            var resultDto = result.Select(o => _mapper.Map<ResidentDto>(o));
            return resultDto;
        }

        public async Task<ResidentDto> GetById(int id)
        {
            var result = await _residentRepository.GetById(id);

            if(result == null)
            {
                return new ResidentDto();
            }

            return _mapper.Map<ResidentDto>(result);
        }

        public async Task<bool> Update(int id, ResidentDto resident)
        {

            var dbResident = await _residentRepository.GetById(id);

            if(dbResident == null)
                return false;
            

            var updatedResident = _mapper.Map(resident, dbResident);

            _residentRepository.Update(updatedResident);

            return await _residentRepository.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {

            var exclusionResident = await _residentRepository.GetById(id);

            if (exclusionResident == null)
                return false;

            _residentRepository.Delete(exclusionResident);

            return await _residentRepository.SaveChangesAsync();
        }

        public async Task<ResidentDto> Add(ResidentDto resident)
        {
            var newResident = _mapper.Map<Resident>(resident);

            var result = _residentRepository.Create(newResident);
            await _residentRepository.SaveChangesAsync();

            return result is not null 
                ? resident
                : new ResidentDto();
        }
    }
}
