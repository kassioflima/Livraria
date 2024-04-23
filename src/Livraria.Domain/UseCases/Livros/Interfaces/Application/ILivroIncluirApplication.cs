using Livraria.Domain.UseCases.Livros.Dto;

namespace Livraria.Domain.UseCases.Livros.Interfaces.Application
{
    public interface ILivroIncluirApplication
    {
        Task<LivroDto?> HandleAsync(LivroDto livro);
    }
}
