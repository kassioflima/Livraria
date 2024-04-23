namespace Livraria.Domain.UseCases.Livros.Interfaces.Application
{
    public interface ILivroExcluirApplication
    {
        Task<bool> HandleAsync(int livroId);
    }
}
