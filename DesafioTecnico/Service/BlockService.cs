using AutoMapper;
using DesafioTecnico.Model.Dto;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using DesafioTecnico.Service.Interfaces;

namespace DesafioTecnico.Service
{
    public class BlockService : IBlockService
    {
        private readonly IBlockRepository _repository;
        private readonly IMapper _mapper;

        public BlockService(IBlockRepository blockRepository, IMapper mapper)
        {
            _repository = blockRepository;
            _mapper = mapper;
        }

        public async Task<BlockDto> Add(BlockDto block)
        {
            var newBlock = _mapper.Map<Block>(block);

            var result = _repository.Create(newBlock);
            await _repository.SaveChangesAsync();

            return result is not null
                ? block
                : new BlockDto();
        }

        public async Task<bool> Delete(int id)
        {
            var exclusionBlock = await _repository.GetById(id);

            if (exclusionBlock == null)
                return false;

            _repository.Delete(exclusionBlock);

            return await _repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlockDto>> GetAll()
        {
            var allBlocks = await _repository.GetAll();
            var resultDto = allBlocks.Select(o => _mapper.Map<BlockDto>(o));

            return resultDto;
        }

        public async Task<BlockDto> GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                return new BlockDto();
            }

            return _mapper.Map<BlockDto>(result);
        }

        public async Task<bool> Update(int id, BlockDto block)
        {
            var dbBlock = await _repository.GetById(id);

            if (dbBlock == null)
                return false;

            var updatedBlock = _mapper.Map(block, dbBlock);

            _repository.Update(updatedBlock);

            return await _repository.SaveChangesAsync();
        }
    }
}
