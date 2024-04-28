using Colaboradores.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colaboradores.Data.Mappings
{
    public class UnidadeMapping : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidades", "unidade");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(u => u.Codigo)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.HasMany(u => u.Colaboradores)
                    .WithOne(c => c.Unidade)
                    .HasForeignKey(c => c.UnidadeId);
        }
    }
}
