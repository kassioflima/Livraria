using Livraria.Domain.Shared.Domain;
using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Livros.Entity;

namespace Livraria.Domain.UseCases.Editoras.Entity
{
    public sealed class Editora : BaseEntity
    {
        public string? Nome { get; private set; }

        public ICollection<Livro>? Livros { get; private set; }

        public Editora(int editoraId, string? nome, ESituacao situacao) : base(editoraId, situacao)
        {
            Nome = nome;
        }

        public Editora(string? nome, ESituacao situacao) : base(situacao)
        {
            Nome = nome;
        }
    }
}
