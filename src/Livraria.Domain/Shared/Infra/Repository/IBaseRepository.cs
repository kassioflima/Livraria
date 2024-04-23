using Livraria.Domain.UseCases.Livros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Shared.Infra.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>?> ObterAsync();
        Task<TEntity?> ObterAsync(int id);
        Task<TEntity> AdicionarAsync(TEntity livro);
        Task<bool> DeletarAsync(int id);
        Task<bool> Atualizar(TEntity livro);
        Task<IEnumerable<TEntity>?> GetAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
