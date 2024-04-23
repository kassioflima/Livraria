using Livraria.Domain.UseCases.Editoras.Dto;
using Livraria.Domain.UseCases.Editoras.Query;

namespace Livraria.Domain.UseCases.Editoras.Interfaces.Query
{
    public interface IEditoraQuery
    {
        Task<IEnumerable<EditoraDto>?> ObterAsync();
        Task<EditoraDto?> ObterAsync(int id);
        Task<IEnumerable<EditoraDto>?> ObterAsync(string nome);
        Task<IEnumerable<EditoraDto>?> ObterAsync(EditoraQuery editora);
    }
}
