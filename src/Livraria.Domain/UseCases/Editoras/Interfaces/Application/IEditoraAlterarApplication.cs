using Livraria.Domain.UseCases.Editoras.Dto;

namespace Livraria.Domain.UseCases.Editoras.Interfaces.Application
{
    public interface IEditoraAlterarApplication
    {
        Task<bool> HandleAsync(EditoraDto editora);
    }
}
