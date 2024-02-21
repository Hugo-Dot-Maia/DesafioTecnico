using DesafioTecnico.Context;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Repository
{
    public class ApartmentRepository : BaseRepository<Apartment>, IApartmentRepository
    {
        private readonly DesafioTecnicoContext _context;
        public ApartmentRepository(DesafioTecnicoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Apartment>> GetAll()
        {
            return await _context.Apartments.Select(x => x).ToListAsync();
        }

        public async Task<Apartment> GetById(int id)
        {
            return await _context.Apartments.Where(o => o.Id == id).FirstOrDefaultAsync();
        }
    }
}
