using SGI.Domain.Base;

namespace SGI.Appication.Interfaces.Usuarios
{
    public interface IPermisoServices
    {
        Task<OperationResult> GetAllAsync();
    }
}
