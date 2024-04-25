using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuildingBlocks.Migrations.Models
{
    public class Unidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Desativado { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

    }

    public class UnidadeMapping : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidades", "unidade");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasMany(u => u.Colaboradores)
                    .WithOne(c => c.Unidade)
                    .HasForeignKey(c => c.UnidadeId);
        }
    }
}
