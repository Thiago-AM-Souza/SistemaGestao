using Colaboradores.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colaboradores.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios", "usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Login)
                    .HasColumnType("varchar")
                    .IsRequired();

            builder.Property(u => u.Senha)
                    .IsRequired();
        }
    }
}
