using Livraria.Domain.UseCases.Editoras.Dto;

namespace Livraria.Domain.UseCases.Editoras.Interfaces.Application
{
    public interface IEditoraIncluirApplication
    {
        Task<EditoraDto?> HandleAsync(EditoraDto editora);
    }
}
