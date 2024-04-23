using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Livros.Interfaces.Application;
using Livraria.Domain.UseCases.Livros.Interfaces.Repository;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Livros
{
    public class LivroExcluirApplication(ILogger<LivroExcluirApplication> _logger, ILivroRepository _repository) : ILivroExcluirApplication
    {
        public async Task<bool> HandleAsync(int livroId)
        {
            if (livroId == 0)
            {
                _logger.LogInformation("Parâmetros inválidos para excluir categoria.");
                throw new ArgumentNullException("Parâmetros inválidos para excluir uma categoria.");
            }

            return await _repository.DeletarAsync(livroId);
        }
    }
}
