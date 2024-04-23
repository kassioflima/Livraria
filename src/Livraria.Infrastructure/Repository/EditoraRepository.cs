using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Livraria.Infrastructure.Context;

namespace Livraria.Infrastructure.Repository
{
    public class EditoraRepository(LivrariaContext context) : BaseRepository<Editora>(context), IEditoraRepository
    {
        public Task<IEnumerable<Editora>?> ObterAsync(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
