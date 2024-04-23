using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Application;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Livraria.Domain.UseCases.Cagetorias.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Categorias
{
    public class CategoriaIncluirApplication(ILogger<CategoriaIncluirApplication> _logger, ICategoriaRepository _repository) : ICategoriaIncluirApplication
    {
        public async Task<CategoriaDto?> HandleAsync(CategoriaDto categoriaDto)
        {
            if (categoriaDto is null)
            {
                _logger.LogInformation("Parâmetros inválidos para incluir categoria.");
                throw new ArgumentNullException("Parâmetros inválidos para criar uma categoria.");
            }
            var entity = CategoriaMapper.Map(categoriaDto);
            var result = await _repository.AdicionarAsync(entity);
            return CategoriaMapper.Map(result);
        }
    }
}
