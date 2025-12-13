using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Models.Inventarios;
using SGI.Persistencia.Base;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Inventarios;
using SGI.Persistencia.Mappers.Inventarios;

namespace SGI.Persistencia.Repositorios.Inventarios
{
    public class CatalogoRepository : baseRepositorio<CatalogoModel>, ICatalogoRepository
    {
        private readonly ILogger<CatalogoRepository> _logger;

        public CatalogoRepository(SGIContext context, ILogger<CatalogoRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public override async Task<OperationResult> RemoveAsync(CatalogoModel model)
        {
            try
            {
                var result = await base.RemoveAsync(model);
                _logger.LogInformation("Catalogo entity removido correctamente");
                result.Data = CatalogoMapperModel.MapperCatalogo(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removiendo el Catalogo entity");
                return OperationResult.Fail("Error al intentar remover el catalogo.");
            }
        }
        public override async Task<OperationResult> SaveAsync(CatalogoModel model)
        {
            try
            {
                var result = await base.SaveAsync(model);
                _logger.LogInformation("Catalogo entity guardado correctamente");
                result.Data = CatalogoMapperModel.MapperCatalogo(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando el Catalogo entity");
                return OperationResult.Fail("Error al intentar guardar el catalogo.");
            }
        }
        public override async Task<OperationResult> UpdateAsync(CatalogoModel model)
        {
            try
            {
                var result = await base.UpdateAsync(model);
                _logger.LogInformation("Catalogo entity actualizado correctamente");
                result.Data = CatalogoMapperModel.MapperCatalogo(model);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error actualizando el Catalogo entity");
                return OperationResult.Fail("Error al intentar actualizar el catalogo.");
            }
        }
        public override async Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetAllAsync(IsDeleted);
                _logger.LogInformation("Catalogos obtenidos correctamente");
                result.Data = CatalogoMapperModel.MapperListCatalogo(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo la lista de Catalogos");
                return OperationResult.Fail("Error al intentar obtener la lista de catalogos.");
            }
        }
        public override async Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetByIdAsync(id, IsDeleted);
                _logger.LogInformation("Catalogo entity obtenido correctamente");
                result.Data = CatalogoMapperModel.MapperCatalogo(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo el Catalogo entity");
                return OperationResult.Fail("Error al intentar obtener el catalogo.");
            }
        }
        public override async Task<OperationResult> DeleteAsync(int id)
        {
            try
            {
                var result = await base.DeleteAsync(id);
                _logger.LogInformation("Catalogo entity eliminado correctamente");
                result.Data = CatalogoMapperModel.MapperCatalogo(result.Data);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error eliminando el Catalogo entity");
                return OperationResult.Fail("Error al intentar eliminar el catalogo.");
            }
        }
    }
}
