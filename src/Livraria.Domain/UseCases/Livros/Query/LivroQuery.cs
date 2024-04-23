using Livraria.Domain.Shared.Domain.Enum;

namespace Livraria.Domain.UseCases.Livros.Query
{
    public record LivroQuery
    {
        public int? LivroId { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public DateTime? Lancamento { get; set; }
        public string? Capa { get; set; }
        public ESituacao? Situacao { get; set; }
        public int? CategoriaId { get; set; }
        public int? EditoraId { get; set; }
    }
}
