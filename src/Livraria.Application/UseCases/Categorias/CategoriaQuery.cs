using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Query;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Livraria.Domain.UseCases.Cagetorias.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Categorias
{
    public class CategoriaQuery(ILogger<CategoriaQuery> _logger, ICategoriaRepository _categoriaRepository) : ICategoriaQuery
    {
        public async Task<IEnumerable<CategoriaDto>?> ObterAsync()
        {
            var result = await _categoriaRepository.ObterAsync();
            return CategoriaMapper.Map(result);
        }

        public async Task<CategoriaDto?> ObterAsync(int id)
        {
            var result = await _categoriaRepository.ObterAsync(id);
            return CategoriaMapper.Map(result);
        }

        public async Task<IEnumerable<CategoriaDto>?> ObterAsync(string descricao)
        {
            var result = await _categoriaRepository.ObterAsync(descricao);
            return CategoriaMapper.Map(result);
        }

        public Task<IEnumerable<CategoriaDto>?> ObterAsync(Domain.UseCases.Cagetorias.Query.CategoriaQuery descricao)
        {
            throw new NotImplementedException();
        }
    }
}
