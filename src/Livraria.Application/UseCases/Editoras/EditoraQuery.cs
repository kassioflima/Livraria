using Livraria.Domain.UseCases.Editoras.Dto;
using Livraria.Domain.UseCases.Editoras.Interfaces.Query;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Livraria.Domain.UseCases.Editoras.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Editoras
{
    public class EditoraQuery(ILogger<EditoraQuery> _logger, IEditoraRepository _editoraRepository) : IEditoraQuery
    {
        public async Task<IEnumerable<EditoraDto>?> ObterAsync()
        {
            var result = await _editoraRepository.ObterAsync();
            return EditoraMapper.Map(result);
        }

        public async Task<EditoraDto?> ObterAsync(int id)
        {
            _logger.LogInformation($"Editando editora {id}");
            var result = await _editoraRepository.ObterAsync(id);
            return EditoraMapper.Map(result);
        }

        public async Task<IEnumerable<EditoraDto>?> ObterAsync(string nome)
        {
            var result = await _editoraRepository.ObterAsync(nome);
            return EditoraMapper.Map(result);
        }

        public Task<IEnumerable<EditoraDto>?> ObterAsync(Domain.UseCases.Editoras.Query.EditoraQuery editora)
        {
            throw new NotImplementedException();
        }
    }
}
