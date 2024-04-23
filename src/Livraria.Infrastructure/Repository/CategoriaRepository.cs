using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Entity;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Livraria.Infrastructure.Context;

namespace Livraria.Infrastructure.Repository
{
    public class CategoriaRepository(LivrariaContext context) : BaseRepository<Categoria>(context), ICategoriaRepository
    {
        public Task<IEnumerable<Categoria>?> ObterAsync(string descricao)
        {
            throw new NotImplementedException();
        }
    }
}
