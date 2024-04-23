using Livraria.Domain.Shared.Infra.Repository;
using Livraria.Domain.UseCases.Editoras.Entity;

namespace Livraria.Domain.UseCases.Editoras.Interfaces.Repository
{
    public interface IEditoraRepository : IBaseRepository<Editora>
    {
        Task<IEnumerable<Editora>?> ObterAsync(string nome);
    }
}
