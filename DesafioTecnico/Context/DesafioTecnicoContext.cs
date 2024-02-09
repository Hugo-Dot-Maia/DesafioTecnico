using DesafioTecnico.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Context
{
    public class DesafioTecnicoContext : DbContext
    {

        public DbSet<Condominium> Condominiums { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Resident> Residents { get; set; }

        public DesafioTecnicoContext(DbContextOptions<DesafioTecnicoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Condominium>();

            modelBuilder.Entity<Block>()
                .HasMany(b => b.Apartments);

            modelBuilder.Entity<Apartment>()
                .HasMany(a => a.Residents);      

            base.OnModelCreating(modelBuilder);
        }
    }
}
