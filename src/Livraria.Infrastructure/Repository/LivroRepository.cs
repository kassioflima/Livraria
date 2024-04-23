using Livraria.Domain.UseCases.Livros.Entity;
using Livraria.Domain.UseCases.Livros.Interfaces.Repository;
using Livraria.Infrastructure.Context;

namespace Livraria.Infrastructure.Repository
{
    public class LivroRepository(LivrariaContext context) : BaseRepository<Livro>(context), ILivroRepository
    {
    }
}
