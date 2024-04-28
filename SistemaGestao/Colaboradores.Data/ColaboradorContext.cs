using BuildingBlocks.Core.Data;
using Colaboradores.Domain;
using Microsoft.EntityFrameworkCore;

namespace Colaboradores.Data
{
    public class ColaboradorContext : DbContext, ISaveChanges
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        public ColaboradorContext(DbContextOptionsBuilder<ColaboradorContext> optionsBuilder) : base(optionsBuilder.Options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("colaboradores");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColaboradorContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
