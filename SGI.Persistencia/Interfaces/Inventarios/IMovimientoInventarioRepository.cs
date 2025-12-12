using SGI.Domain.Base;
using SGI.Models.Inventarios;

namespace SGI.Persistencia.Interfaces.Inventarios
{
    public interface IMovimientoInventarioRepository 
    {
        Task<OperationResult> SaveAsync(MovimientoInventarioModel model);
        Task<OperationResult> DeleteAsync(MovimientoInventarioModel model);
    }
}
