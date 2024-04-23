using Livraria.Domain.Shared.Infra.Repository;
using Livraria.Domain.UseCases.Cagetorias.Entity;

namespace Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        Task<IEnumerable<Categoria>?> ObterAsync(string descricao);
    }
}
