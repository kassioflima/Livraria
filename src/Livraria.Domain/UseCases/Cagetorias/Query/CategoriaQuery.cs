using Livraria.Domain.Shared.Domain.Enum;

namespace Livraria.Domain.UseCases.Cagetorias.Query
{
    public record CategoriaQuery
    {
        public int? Id { get; set; }
        public string? Descricao { get; set; }
        public ESituacao? Situacao { get; set; }
    }
}
