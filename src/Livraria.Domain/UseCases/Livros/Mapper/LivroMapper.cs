using Livraria.Domain.UseCases.Cagetorias.Mapper;
using Livraria.Domain.UseCases.Editoras.Mapper;
using Livraria.Domain.UseCases.Livros.Dto;
using Livraria.Domain.UseCases.Livros.Entity;

namespace Livraria.Domain.UseCases.Livros.Mapper
{
    public static class LivroMapper
    {
        public static IEnumerable<LivroDto>? Map(IEnumerable<Livro>? result)
        {
            if (result == null) return [];
            return result.Select(x => new LivroDto()
            {
                Autor = x.Autor,
                Capa = x.Capa,
                Categoria = CategoriaMapper.Map(x.Categoria),
                CategoriaId = x.CategoriaId,
                Editora = EditoraMapper.Map(x.Editora),
                EditoraId = x.EditoraId,
                Lancamento = x.Lancamento,
                LivroId = x.Id,
                Situacao = x.Situacao,
                Titulo = x.Titulo
            });
        }

        public static LivroDto? Map(Livro? result)
        {
            if (result == null) return default;

            return new()
            {
                Autor = result.Autor,
                Capa = result.Capa,
                Categoria = CategoriaMapper.Map(result.Categoria),
                CategoriaId = result.CategoriaId,
                Editora = EditoraMapper.Map(result.Editora),
                EditoraId = result.EditoraId,
                Lancamento = result.Lancamento,
                LivroId = result.Id,
                Situacao = result.Situacao,
                Titulo = result.Titulo
            };
        }
    }
}
