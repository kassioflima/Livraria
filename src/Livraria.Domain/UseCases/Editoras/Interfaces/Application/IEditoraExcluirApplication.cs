namespace Livraria.Domain.UseCases.Editoras.Interfaces.Application
{
    public interface IEditoraExcluirApplication
    {
        Task<bool> HandleAsync(int editoraId);
    }
}
