using Coworking.Data.Contexts;
using Coworking.Data.IRepositories;
using Coworking.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Coworking.Data.Repositories
{
#pragma warning disable
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly AppDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public Repository(AppDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> CheckingAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            return await this.DeleteAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetAsync(long id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            return (await dbSet.AddAsync(entity)).Entity;
        }

        public async Task SaveChangesAsync()
            => await context.SaveChangesAsync();

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var result = dbSet.Update(entity);
            return result.Entity;
        }
    }
}
