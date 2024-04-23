using Livraria.Domain.UseCases.Editoras.Dto;
using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Livros.Dto;
using Livraria.Domain.UseCases.Livros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Editoras.Mapper
{
    public static class EditoraMapper
    {
        public static EditoraDto? Map(Editora? editora)
        {
            if (editora == null) return default;
            return new EditoraDto()
            {
                EditoraId = editora.Id,
                Nome = editora.Nome,
                Situacao = editora.Situacao
            };
        }

        public static IEnumerable<EditoraDto>? Map(IEnumerable<Editora>? result)
        {
            if (result is null) return [];
            
            return result.Select(x => new EditoraDto()
            {
                EditoraId = x.Id,
                Nome = x.Nome,
                Situacao = x.Situacao
            });
        }
    }
}
