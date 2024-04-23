using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Entity;

namespace Livraria.Domain.UseCases.Cagetorias.Mapper
{
    public static class CategoriaMapper
    {
        public static IEnumerable<CategoriaDto>? Map(IEnumerable<Categoria>? result)
        {
            if (result is null) return Enumerable.Empty<CategoriaDto>();
            return result.Select(x => new CategoriaDto()
            {
                CategoriaId = x.Id,
                Descricao = x.Descricao,
                DescricaoCategoria = x.DescricaoCategoria,
                Situacao = x.Situacao
            });
        }

        public static CategoriaDto? Map(Categoria? result)
        {
            if (result is null) return default;
            return new CategoriaDto()
            {
                CategoriaId = result.Id,
                Descricao = result.Descricao,
                DescricaoCategoria = result.DescricaoCategoria,
                Situacao = result.Situacao
            };
        }

        public static Categoria Map(CategoriaDto categoriaDto)
        {
            return new(categoriaDto.Descricao, categoriaDto.DescricaoCategoria, categoriaDto.Situacao);
        }
    }
}
