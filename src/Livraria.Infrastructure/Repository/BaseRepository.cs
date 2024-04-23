using Livraria.Domain.Shared.Domain;
using Livraria.Domain.Shared.Infra.Repository;
using Livraria.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Livraria.Infrastructure.Repository
{
    public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly LivrariaContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(LivrariaContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>?> ObterAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> ObterAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TEntity> AdicionarAsync(TEntity entity)
        {
            if(entity is not null)
            {

                await DbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            else
                throw new ArgumentNullException(nameof(entity));
        }

        public async Task<bool> DeletarAsync(int id)
        {
            TEntity entity = await ObterAsync(id);
            if (entity is null)
                return false;

            _context.Set<TEntity>().Remove(entity);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> Atualizar(TEntity entity)
        {
            if (entity is not null)
            {
                _context.Entry(entity).State = EntityState.Modified;
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            else
                throw new ArgumentNullException(nameof(entity));
        }

        public async Task<IEnumerable<TEntity>?> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
