using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuildingBlocks.Migrations.Models
{
    public class Colaborador
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid UnidadeId { get; set; }

        public Usuario Usuario { get; set; }
        public Unidade Unidade { get; set; }
    }

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