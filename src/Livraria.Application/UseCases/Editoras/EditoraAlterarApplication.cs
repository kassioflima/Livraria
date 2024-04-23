using Livraria.Domain.UseCases.Editoras.Dto;
using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Editoras.Interfaces.Application;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Livraria.Domain.UseCases.Editoras.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Editoras
{
    public class EditoraAlterarApplication(ILogger<EditoraAlterarApplication> _logger, IEditoraRepository _editoraRepository) : IEditoraAlterarApplication
    {
        public async Task<bool> HandleAsync(EditoraDto editora)
        {
            _logger.LogInformation("Iniciando a atualização da editora.");
            var entity = await _editoraRepository.ObterAsync(editora.EditoraId);
            if(entity is null) return false;
            var update = new Editora(entity.Id, editora.Nome, editora.Situacao);
            return await _editoraRepository.Atualizar(update);
        }
    }
}
