namespace Coworking.Data.IRepositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<TEntity> GetAsync(long id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
