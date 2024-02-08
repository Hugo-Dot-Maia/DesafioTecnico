using DesafioTecnico.Context;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Repository
{
    public class ResidentRepository : BaseRepository, IResidentRepository
    {
        private readonly DesafioTecnicoContext _context;
        public ResidentRepository(DesafioTecnicoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Resident>> GetAll()
        {
            return await _context.Residents.Select(x => x).ToListAsync();
        }

        public async Task<Resident> GetById(int id)
        {
            return await _context.Residents.Where(o => o.Id == id).FirstOrDefaultAsync();
        }
    }
}
