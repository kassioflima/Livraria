using Livraria.Domain.UseCases.Editoras.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Maps
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd().HasColumnName("EditoraId");
            builder.Property(l => l.Nome).HasMaxLength(150).HasColumnType("varchar");
            builder.Property(l => l.Situacao);

            builder.HasMany(c => c.Livros).WithOne(c => c.Editora).HasForeignKey(c => c.EditoraId);
        }
    }
}
