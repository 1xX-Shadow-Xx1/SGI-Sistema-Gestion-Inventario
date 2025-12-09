using SGI.Domain.Base;
using SGI.Domain.Repository;

namespace SGI.Persistencia.Base
{
    public abstract class baseRepositorio<TEntity> : IbaseRepository<TEntity> where TEntity : class
    {
        protected baseRepositorio()
        {
        }

        public virtual Task<OperationResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> SaveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
