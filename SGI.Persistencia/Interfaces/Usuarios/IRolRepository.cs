using SGI.Domain.Base;
using SGI.Domain.Entities.Usuarios;

namespace SGI.Persistencia.Interfaces.Usuarios
{
    public interface IRolRepository 
    {
        Task<OperationResult> GetAllAsync();
        Task<OperationResult> GetByIdAsync(int id);
        Task<OperationResult> SaveAsync(Rol rol);
        Task<OperationResult> UpdateAsync(Rol rol);
        Task<OperationResult> DeleteAsync(Rol rol);
    }
}
