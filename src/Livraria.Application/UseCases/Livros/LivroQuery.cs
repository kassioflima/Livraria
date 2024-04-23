using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Livros.Dto;
using Livraria.Domain.UseCases.Livros.Interfaces.Query;
using Livraria.Domain.UseCases.Livros.Interfaces.Repository;
using Livraria.Domain.UseCases.Livros.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Livros
{
    public class LivroQuery(ILogger<LivroQuery> _logger, ILivroRepository _repository) : ILivroQuery
    {
        public async Task<IEnumerable<LivroDto>?> ObterAsync()
        {
            var result = await _repository.ObterAsync();
            return LivroMapper.Map(result);
        }

        public async Task<LivroDto?> ObterAsync(int id)
        {
            var result = await _repository.ObterAsync(id);
            return LivroMapper.Map(result);
        }

        public async Task<IEnumerable<LivroDto>?> ObterAsync(string titulo)
        {
            var result = await _repository.GetAsync(x => x.Titulo!.Contains(titulo));
            return LivroMapper.Map(result);
        }

        public async Task<IEnumerable<LivroDto>?> ObterAsync(DateTime lancamento)
        {
            var result = await _repository.GetAsync(x => x.Lancamento >= lancamento);
            return LivroMapper.Map(result);
        }

        public async Task<IEnumerable<LivroDto>?> ObterAsync(ESituacao situacao)
        {
            var result = await _repository.GetAsync(x => x.Situacao == situacao);
            return LivroMapper.Map(result);
        }

        public Task<IEnumerable<LivroDto>?> ObterAsync(Domain.UseCases.Livros.Query.LivroQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LivroDto>?> ObterAutorAsync(string autor)
        {
            var result = await _repository.GetAsync(x => x.Autor!.Contains(autor));
            return LivroMapper.Map(result);
        }

        public async Task<IEnumerable<LivroDto>?> ObterCategoriaAsync(int categoriaId)
        {
            var result = await _repository.GetAsync(x => x.CategoriaId == categoriaId);
            return LivroMapper.Map(result);
        }

        public async Task<IEnumerable<LivroDto>?> ObterEditoraAsync(int EditoraId)
        {
            _logger.LogInformation($"buscando editora {EditoraId}");
            var result = await _repository.GetAsync(x => x.EditoraId == EditoraId);
            return LivroMapper.Map(result);
        }
    }
}
