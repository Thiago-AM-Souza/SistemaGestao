using BuildingBlocks.Migrations.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildingBlocks.Migrations
{
    public class MigrationContext : DbContext
    {
        public MigrationContext(DbContextOptions<MigrationContext> options) : base(options) 
        { 
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MigrationContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}