using DesafioTecnico.Context;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Repository
{
    public class BlockRepository : BaseRepository, IBlockRepository
    {
        private readonly DesafioTecnicoContext _context;
        public BlockRepository(DesafioTecnicoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Block>> GetAll()
        {
            return await _context.Blocks.Select(x => x).ToListAsync();
        }

        public async Task<Block> GetById(int id)
        {
            return await _context.Blocks.Where(o => o.Id == id).FirstOrDefaultAsync();
        }
    }
}
