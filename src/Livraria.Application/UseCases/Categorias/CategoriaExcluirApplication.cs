using Livraria.Domain.UseCases.Cagetorias.Interfaces.Application;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Categorias
{
    public class CategoriaExcluirApplication(ILogger<CategoriaExcluirApplication> _logger, ICategoriaRepository _repository) : ICategoriaExcluirApplication
    {
        public async Task<bool> HandleAsync(int categoriaId)
        {
            if (categoriaId == 0)
            {
                _logger.LogInformation("Parâmetros inválidos para excluir categoria.");
                throw new ArgumentNullException("Parâmetros inválidos para excluir uma categoria.");
            }

            return await _repository.DeletarAsync(categoriaId);
        }
    }
}
