using Livraria.Domain.UseCases.Cagetorias.Dto;

namespace Livraria.Domain.UseCases.Cagetorias.Interfaces.Application
{
    public interface ICategoriaExcluirApplication
    {
        Task<bool> HandleAsync(int categoriaId);
    }
}
