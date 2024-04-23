using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Query;

namespace Livraria.Domain.UseCases.Cagetorias.Interfaces.Query
{
    public interface ICategoriaQuery
    {
        Task<IEnumerable<CategoriaDto>?> ObterAsync();
        Task<CategoriaDto?> ObterAsync(int id);
        Task<IEnumerable<CategoriaDto>?> ObterAsync(string descricao);
        Task<IEnumerable<CategoriaDto>?> ObterAsync(CategoriaQuery categoria);
    }
}
