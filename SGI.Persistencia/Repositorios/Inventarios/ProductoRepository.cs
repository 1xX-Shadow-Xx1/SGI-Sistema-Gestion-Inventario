using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Models.Inventarios;
using SGI.Persistencia.Base;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Inventarios;
using SGI.Persistencia.Mappers.Inventarios;

namespace SGI.Persistencia.Repositorios.Inventarios
{
    public class ProductoRepository : baseRepositorio<ProductoModel>, IProductoRepository
    {
        private readonly ILogger<ProductoRepository> _logger;

        public ProductoRepository(SGIContext context, ILogger<ProductoRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public override async Task<OperationResult> RemoveAsync(ProductoModel model)
        {
            try
            {
                var result = await base.RemoveAsync(model);
                _logger.LogInformation("Producto entity removido correctamente");
                result.Data = ProductoMapperModel.MapperProducto(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removiendo el Producto entity");
                return OperationResult.Fail("Error al intentar remover el producto.");
            }
        }
        public override async Task<OperationResult> SaveAsync(ProductoModel model)
        {
            try
            {
                var result = await base.SaveAsync(model);
                _logger.LogInformation("Producto entity guardado correctamente");
                result.Data = ProductoMapperModel.MapperProducto(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando el Producto entity");
                return OperationResult.Fail("Error al intentar guardar el producto.");
            }
        }
        public override async Task<OperationResult> UpdateAsync(ProductoModel model)
        {
            try
            {
                var result = await base.UpdateAsync(model);
                _logger.LogInformation("Producto entity actualizado correctamente");
                result.Data = ProductoMapperModel.MapperProducto(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error actualizando el Producto entity");
                return OperationResult.Fail("Error al intentar actualizar el producto.");
            }
        }
        public override async Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetAllAsync(IsDeleted);
                _logger.LogInformation("Productos obtenidos correctamente");
                result.Data = ProductoMapperModel.MapperListProducto(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo la lista de Productos");
                return OperationResult.Fail("Error al intentar obtener la lista de productos.");
            }
        }
        public override async Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetByIdAsync(id, IsDeleted);
                _logger.LogInformation("Producto entity obtenido correctamente");
                result.Data = ProductoMapperModel.MapperProducto(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo el Producto entity");
                return OperationResult.Fail("Error al intentar obtener el producto.");
            }
        }
        public override async Task<OperationResult> DeleteAsync(int id)
        {
            try
            {
                var result = await base.DeleteAsync(id);
                _logger.LogInformation("Producto entity eliminado correctamente");
                result.Data = ProductoMapperModel.MapperProducto(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error eliminando el Producto entity");
                return OperationResult.Fail("Error al intentar eliminar el producto.");
            }
        }
    }
}
