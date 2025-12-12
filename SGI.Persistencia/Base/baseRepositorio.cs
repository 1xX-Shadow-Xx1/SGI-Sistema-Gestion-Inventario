using Microsoft.EntityFrameworkCore;
using SGI.Domain.Base;
using SGI.Domain.Repository;
using SGI.Models;
using SGI.Persistencia.Context;

namespace SGI.Persistencia.Base
{
    public abstract class baseRepositorio<TEntity> : IbaseRepository<TEntity> where TEntity : baseModel
    {
        private readonly SGIContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public baseRepositorio(SGIContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public virtual async Task<OperationResult> SaveAsync(TEntity entity)
        {
            try
            {
                entity.fecha_creacion = DateTime.Now;
                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
                return OperationResult.Ok($"Se a guardado correctamente.", entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual async Task<OperationResult> UpdateAsync(TEntity entity)
        {
            try
            {
                entity.fecha_modificacion = DateTime.Now;
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return OperationResult.Ok($"Se a actualizado correctamente.", entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual async Task<OperationResult> RemoveAsync(TEntity entity)
        {
            try
            {
                entity.isDeleted = true;
                entity.fecha_modificacion = DateTime.Now;
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return OperationResult.Ok($"Se a eliminado correctamente.", entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual async Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            try
            {
                await _dbSet.ToListAsync();
                return OperationResult.Ok("Lista obtenida correctamente.", await _dbSet.ToListAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual async Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            try
            {
                var entity = await _dbSet.FirstOrDefaultAsync(u => u.id == id);
                return OperationResult.Ok("Entidad obtenida correctamente.", entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual async Task<OperationResult> DeleteAsync(int id) 
        {
            try
            {
                var entity = await _dbSet.FirstOrDefaultAsync(e => e.id == id);
                if (entity == null)
                {
                    return OperationResult.Fail("Entidad no encontrada.");
                }
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return OperationResult.Ok($"Se ha eliminado correctamente.", entity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
