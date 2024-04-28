using Colaboradores.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colaboradores.Data.Mappings
{
    public class ColaboradorMapping : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("colaboradores", "colaborador");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                    .HasColumnType("varchar(50)")
                    .IsRequired();

            builder.HasOne(c => c.Usuario)
                    .WithOne()
                    .HasForeignKey<Colaborador>(c => c.UsuarioId);

            builder.HasOne(c => c.Unidade)
                    .WithMany(u => u.Colaboradores)
                    .HasForeignKey(c => c.UnidadeId);
        }
    }
}
