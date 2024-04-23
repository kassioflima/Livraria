using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Livros.Dto;
using Livraria.Domain.UseCases.Livros.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Livros.Interfaces.Query
{
    public interface ILivroQuery
    {
        Task<IEnumerable<LivroDto>?> ObterAsync();
        Task<LivroDto?> ObterAsync(int id);
        Task<IEnumerable<LivroDto>?> ObterAsync(string titulo);
        Task<IEnumerable<LivroDto>?> ObterAsync(DateTime lancamento);
        Task<IEnumerable<LivroDto>?> ObterAsync(ESituacao situacao);
        Task<IEnumerable<LivroDto>?> ObterAsync(LivroQuery query);
        Task<IEnumerable<LivroDto>?> ObterAutorAsync(string autor);
        Task<IEnumerable<LivroDto>?> ObterCategoriaAsync(int categoriaId);
        Task<IEnumerable<LivroDto>?> ObterEditoraAsync(int EditoraId);
    }
}
