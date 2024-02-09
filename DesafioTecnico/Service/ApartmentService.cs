using AutoMapper;
using DesafioTecnico.Model.Dto;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using DesafioTecnico.Service.Interfaces;

namespace DesafioTecnico.Service
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _repository;
        private readonly IMapper _mapper;
        public ApartmentService(IApartmentRepository apartmentRepository, IMapper mapper) 
        {
            _repository = apartmentRepository;
            _mapper = mapper;
        }

        public async Task<ApartmentDto> Add(ApartmentDto resident)
        {
            var newApartment = _mapper.Map<Apartment>(resident);

            var result = _repository.Create(newApartment);
            await _repository.SaveChangesAsync();

            return result is not null
                ? resident
                : new ApartmentDto();
        }

        public async Task<bool> Delete(int id)
        {
            var exclusionApartment = await _repository.GetById(id);

            if (exclusionApartment == null)
                return false;

            _repository.Delete(exclusionApartment);

            return await _repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ApartmentDto>> GetAll()
        {
            var allApartments = await _repository.GetAll();
            var resultDto = allApartments.Select(o => _mapper.Map<ApartmentDto>(o));

            return resultDto;
        }

        public async Task<ApartmentDto> GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                return new ApartmentDto();
            }

            return _mapper.Map<ApartmentDto>(result);
        }

        public async Task<bool> Update(int id, ApartmentDto resident)
        {
            var dbApartment = await _repository.GetById(id);

            if (dbApartment == null)
                return false;

            var updatedApartment = _mapper.Map(resident, dbApartment);

            _repository.Update(updatedApartment);

            return await _repository.SaveChangesAsync();
        }
    }
}
