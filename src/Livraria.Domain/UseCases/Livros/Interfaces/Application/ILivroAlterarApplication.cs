using Livraria.Domain.UseCases.Livros.Dto;

namespace Livraria.Domain.UseCases.Livros.Interfaces.Application
{
    public interface ILivroAlterarApplication
    {
        Task<bool> HandleAsync(LivroDto livro);
    }
}
