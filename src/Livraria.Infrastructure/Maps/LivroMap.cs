using Livraria.Domain.UseCases.Livros.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Maps
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd().HasColumnName("LivroId");
            builder.Property(l => l.Titulo).HasMaxLength(150).HasColumnType("varchar");
            builder.Property(l => l.Autor).HasMaxLength(200).HasColumnType("varchar");
            builder.Property(l => l.Lancamento);
            builder.Property(l => l.Capa).HasMaxLength(300).HasColumnType("varchar");
            builder.Property(l => l.Situacao);
            builder.Property(l => l.CategoriaId);
            builder.Property(l => l.EditoraId);

            builder.HasOne(l => l.Categoria).WithMany(l => l.Livros).HasForeignKey(l => l.CategoriaId);
            builder.HasOne(l => l.Editora).WithMany(l => l.Livros).HasForeignKey(l => l.EditoraId);
        }
    }
}
