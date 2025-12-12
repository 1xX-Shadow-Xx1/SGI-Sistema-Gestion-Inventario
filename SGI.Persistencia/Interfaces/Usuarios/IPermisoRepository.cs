using SGI.Domain.Base;

namespace SGI.Persistencia.Interfaces.Usuarios
{
    public interface IPermisoRepository 
    {
        Task<OperationResult> GetAllPermisosAsync();
    }
}
