using Livraria.Domain.UseCases.Cagetorias.Entity;
using Livraria.Domain.UseCases.Editoras.Interfaces.Application;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Editoras
{
    public class EditoraExcluirApplication(ILogger<EditoraExcluirApplication> _logger, IEditoraRepository _repository) : IEditoraExcluirApplication
    {
        public async Task<bool> HandleAsync(int editoraId)
        {
            if (editoraId == 0)
            {
                _logger.LogInformation("Parâmetros inválidos para excluir categoria.");
                throw new ArgumentNullException("Parâmetros inválidos para excluir uma categoria.");
            }

            return await _repository.DeletarAsync(editoraId);
        }
    }
}
