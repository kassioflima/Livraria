using Livraria.Domain.Shared.Domain;
using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Livros.Entity;

namespace Livraria.Domain.UseCases.Cagetorias.Entity
{
    public sealed class Categoria : BaseEntity
    {
        public string? Descricao { get; private set; }
        public string? DescricaoCategoria { get; private set; }

        public ICollection<Livro>? Livros { get; private set; }

        public Categoria(int categoriaId, string? descricao, string? descricaoCategoria, ESituacao situacao) : base(categoriaId, situacao)
        {
            Descricao = descricao;
            DescricaoCategoria = descricaoCategoria;
        }

        public Categoria(string? descricao, string? descricaoCategoria, ESituacao situacao) : base(situacao)
        {
            Descricao = descricao;
            DescricaoCategoria = descricaoCategoria;
        }
    }
}
