using DesafioTecnico.Context;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Repository
{
    public class CondominiumRepository : BaseRepository, ICondominiumRepository
    {
        private readonly DesafioTecnicoContext _context;
        public CondominiumRepository(DesafioTecnicoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Condominium>> GetAll()
        {
            return await _context.Condominiums.Select(x => x).ToListAsync();
        }

        public async Task<Condominium> GetById(int id)
        {
            return await _context.Condominiums.Where(o => o.Id == id).FirstOrDefaultAsync();
        }
    }
}
