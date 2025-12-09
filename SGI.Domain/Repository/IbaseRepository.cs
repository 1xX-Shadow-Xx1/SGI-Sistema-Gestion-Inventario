using SGI.Domain.Base;

namespace SGI.Domain.Repository
{
    public interface IbaseRepository<TEntity> where TEntity : class
    {
        Task<OperationResult> SaveAsync(TEntity entity);
        Task<OperationResult> UpdateAsync(TEntity entity);
        Task<OperationResult> RemoveAsync(TEntity entity);
        Task<OperationResult> GetAllAsync(bool? IsDeleted = false);
        Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false);
        Task<OperationResult> DeleteAsync(int id);
    }
}
