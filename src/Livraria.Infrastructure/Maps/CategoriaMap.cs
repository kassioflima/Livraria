using Livraria.Domain.UseCases.Cagetorias.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Maps
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd().HasColumnName("CategoriaId");
            builder.Property(c => c.Descricao).HasMaxLength(150).HasColumnType("varchar");
            builder.Property(c => c.DescricaoCategoria).HasMaxLength(300).HasColumnType("varchar");
            builder.Property(c => c.Situacao);

            builder.HasMany(c => c.Livros).WithOne(c => c.Categoria).HasForeignKey(c => c.CategoriaId);
        }
    }
}
