using Livraria.Domain.Shared.Domain;
using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Cagetorias.Entity;
using Livraria.Domain.UseCases.Editoras.Entity;

namespace Livraria.Domain.UseCases.Livros.Entity
{
    public class Livro : BaseEntity
    {
        public string? Titulo { get; private set; }
        public string? Autor { get; private set; }
        public DateTime Lancamento { get; private set; } = DateTime.Now;
        public string? Capa { get; private set; }
        public int CategoriaId { get; private set; }
        public int EditoraId { get; private set; }

        public Categoria? Categoria { get; private set; }
        public Editora? Editora { get; private set; }

        public Livro(int livroId, string? titulo, string? autor, DateTime lancamento, string? capa, int categoriaId, int editoraId, ESituacao situacao) : base(livroId, situacao)
        {
            Titulo = titulo;
            Autor = autor;
            Lancamento = lancamento;
            Capa = capa;
            CategoriaId = categoriaId;
            EditoraId = editoraId;
        }

        public Livro(string? titulo, string? autor, DateTime lancamento, string? capa, int categoriaId, int editoraId, ESituacao situacao) : base(situacao)
        {
            Autor = autor;
            Titulo = titulo;
            Lancamento = lancamento;
            Capa = capa;
            CategoriaId = categoriaId;
            EditoraId = editoraId;
        }
    }
}
