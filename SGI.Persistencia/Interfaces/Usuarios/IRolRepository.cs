using SGI.Domain.Base;
using SGI.Models.Usuarios;


namespace SGI.Persistencia.Interfaces.Usuarios
{
    public interface IRolRepository 
    {
        Task<OperationResult> GetAllAsync();
        Task<OperationResult> GetByIdAsync(int id);
        Task<OperationResult> SaveAsync(RolModel rol);
        Task<OperationResult> UpdateAsync(RolModel rol);
        Task<OperationResult> DeleteAsync(RolModel rol);
    }
}
