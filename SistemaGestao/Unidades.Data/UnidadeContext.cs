using BuildingBlocks.Core.Data;
using Microsoft.EntityFrameworkCore;
using Unidades.Domain;

namespace Unidades.Data
{
    public class UnidadeContext : DbContext, ISaveChanges
    {
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }

        public UnidadeContext(DbContextOptionsBuilder<UnidadeContext> builder) : base(builder.Options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("unidades");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UnidadeContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
