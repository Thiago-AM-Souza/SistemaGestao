using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuildingBlocks.Migrations.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Desativado { get; set; }

    }
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) 
        {
            builder.ToTable("usuarios", "usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Login)
                    .HasColumnType("varchar")                    
                    .IsRequired();

            builder.Property(u => u.Desativado)
                    .HasColumnType("boolean")
                    .HasDefaultValue(false);

            builder.Property(u => u.Senha)
                    .IsRequired();
        }
    }
}
