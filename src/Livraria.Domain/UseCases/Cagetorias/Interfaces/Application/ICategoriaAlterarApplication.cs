using Livraria.Domain.UseCases.Cagetorias.Dto;

namespace Livraria.Domain.UseCases.Cagetorias.Interfaces.Application
{
    public interface ICategoriaAlterarApplication
    {
        Task<bool> HandleAsync(CategoriaDto categoriaDto);
    }
}
