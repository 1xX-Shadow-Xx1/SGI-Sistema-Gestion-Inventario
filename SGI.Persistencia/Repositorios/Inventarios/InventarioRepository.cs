using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Models.Inventarios;
using SGI.Persistencia.Base;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Inventarios;
using SGI.Persistencia.Mappers.Inventarios;

namespace SGI.Persistencia.Repositorios.Inventarios
{
    public class InventarioRepository : baseRepositorio<InventarioModel>, IInventarioRepository
    {
        private readonly ILogger<InventarioRepository> _logger;

        public InventarioRepository(SGIContext context, ILogger<InventarioRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public override async Task<OperationResult> RemoveAsync(InventarioModel model)
        {
            try
            {
                var result = await base.RemoveAsync(model);
                _logger.LogInformation("Inventario entity removido correctamente");
                result.Data = InventarioMapperModel.MapperInventario(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removiendo el Inventario entity");
                return OperationResult.Fail("Error al intentar remover el inventario.");
            }
        }
        public override async Task<OperationResult> SaveAsync(InventarioModel model)
        {
            try
            {
                var result = await base.SaveAsync(model);
                _logger.LogInformation("Inventario entity guardado correctamente");
                result.Data = InventarioMapperModel.MapperInventario(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando el Inventario entity");
                return OperationResult.Fail("Error al intentar guardar el inventario.");
            }
        }
        public override async Task<OperationResult> UpdateAsync(InventarioModel model)
        {
            try
            {
                var result = await base.UpdateAsync(model);
                _logger.LogInformation("Inventario entity actualizado correctamente");
                result.Data = InventarioMapperModel.MapperInventario(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error actualizando el Inventario entity");
                return OperationResult.Fail("Error al intentar actualizar el inventario.");
            }
        }
        public override async Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetAllAsync(IsDeleted);
                _logger.LogInformation("Inventarios obtenidos correctamente");
                result.Data = InventarioMapperModel.MapperListInventario(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo la lista de Inventarios");
                return OperationResult.Fail("Error al intentar obtener la lista de inventarios.");
            }
        }
        public override async Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetByIdAsync(id, IsDeleted);
                _logger.LogInformation("Inventario entity obtenido correctamente");
                result.Data = InventarioMapperModel.MapperInventario(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo el Inventario entity");
                return OperationResult.Fail("Error al intentar obtener el inventario.");
            }
        }
        public override async Task<OperationResult> DeleteAsync(int id)
        {
            try
            {
                var result = await base.DeleteAsync(id);
                _logger.LogInformation("Inventario entity eliminado correctamente");
                result.Data = InventarioMapperModel.MapperInventario(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error eliminando el Inventario entity");
                return OperationResult.Fail("Error al intentar eliminar el inventario.");
            }
        }
    }
}
