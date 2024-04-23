using Livraria.Domain.UseCases.Cagetorias.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Cagetorias.Interfaces.Application
{
    public interface ICategoriaIncluirApplication
    {
        Task<CategoriaDto?> HandleAsync(CategoriaDto categoriaDto);
    }
}
