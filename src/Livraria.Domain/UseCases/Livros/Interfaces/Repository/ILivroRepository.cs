using Livraria.Domain.Shared.Infra.Repository;
using Livraria.Domain.UseCases.Livros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Livros.Interfaces.Repository
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
    }
}
