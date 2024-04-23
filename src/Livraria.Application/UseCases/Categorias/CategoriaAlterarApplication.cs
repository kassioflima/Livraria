using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Entity;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Application;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Livraria.Domain.UseCases.Cagetorias.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Categorias
{

    public class CategoriaAlterarApplication(ILogger<CategoriaAlterarApplication> _logger, ICategoriaRepository _repository) : ICategoriaAlterarApplication
    {
        public async Task<bool> HandleAsync(CategoriaDto categoriaDto)
        {
            if (categoriaDto is null)
            {
                _logger.LogInformation("Parâmetros inválidos para incluir categoria.");
                throw new ArgumentNullException("Parâmetros inválidos para criar uma categoria.");
            }
            var entity = new Categoria(categoriaDto.CategoriaId, categoriaDto.Descricao, categoriaDto.DescricaoCategoria, categoriaDto.Situacao);
            return await _repository.Atualizar(entity);
        }
    }
}
