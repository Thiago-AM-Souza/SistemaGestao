using BuildingBlocks.Core.Data;
using Microsoft.EntityFrameworkCore;
using Usuarios.Domain;

namespace Usuarios.Data
{
    public class UsuarioContext : DbContext, ISaveChanges
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioContext(DbContextOptionsBuilder<UsuarioContext> optionsBuilder) : base(optionsBuilder.Options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("usuarios");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
