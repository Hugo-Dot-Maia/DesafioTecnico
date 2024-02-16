using AutoMapper;
using DesafioTecnico.Model.Dto;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using DesafioTecnico.Service.Interfaces;

namespace DesafioTecnico.Service
{
    public class CondominiumService : ICondominiumService
    {
        private readonly ICondominiumRepository _repository;
        private readonly IMapper _mapper;

        public CondominiumService(ICondominiumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CondominiumDto> Add(CondominiumDto condominium)
        {
            var newCondominium = _mapper.Map<Condominium>(condominium);

            var result = _repository.Create(newCondominium);
            await _repository.SaveChangesAsync();

            return result is not null
                ? condominium
                : new CondominiumDto();
        }

        public async Task<bool> Delete(int id)
        {
            var exclusionCondominium = await _repository.GetById(id);

            if (exclusionCondominium == null)
                return false;

            _repository.Delete(exclusionCondominium);

            return await _repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CondominiumDto>> GetAll()
        {
            var allCondominium = await _repository.GetAll();
            var resultDto = allCondominium.Select(o => _mapper.Map<CondominiumDto>(o));

            return resultDto;
        }

        public async Task<CondominiumDto> GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                return new CondominiumDto();
            }

            return _mapper.Map<CondominiumDto>(result);
        }

        public async Task<bool> Update(int id, CondominiumDto condominium)
        {
            var dbCondominium = await _repository.GetById(id);

            if (dbCondominium == null)
                return false;

            var updatedCondominium = _mapper.Map(condominium, dbCondominium);

            _repository.Update(updatedCondominium);

            return await _repository.SaveChangesAsync();
        }
    }
}
