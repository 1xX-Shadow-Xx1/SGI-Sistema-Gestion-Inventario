using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;
using SGI.Persistencia.Base;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Usuarios;

namespace SGI.Persistencia.Repositorios.Usuarios
{
    public class UsuarioRepository : baseRepositorio<UsuarioModel>, IUsuarioRepository
    {
        private readonly ILogger<UsuarioRepository> _logger;


        public UsuarioRepository(SGIContext context, ILogger<UsuarioRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public override async Task<OperationResult> RemoveAsync(UsuarioModel model)
        {
            try
            {
                var result = await base.RemoveAsync(model);
                _logger.LogInformation("Usuario entity removido correctamente");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removiendo el Usuario entity");
                return OperationResult.Fail("Error al intentar remover el usuario.");
            }
        }
        public override async Task<OperationResult> SaveAsync(UsuarioModel model)
        {
            try
            {
                var result = await base.SaveAsync(model);
                _logger.LogInformation("Usuario entity guardado correctamente");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando el Usuario entity");
                return OperationResult.Fail("Error al intentar guardar el usuario.");
            }
        }
        public override async Task<OperationResult> UpdateAsync(UsuarioModel model)
        {
            try
            {
                var result = await base.UpdateAsync(model);
                _logger.LogInformation("Usuario entity actualizado correctamente");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error actualizando el Usuario entity");
                return OperationResult.Fail("Error al intentar actualizar el usuario.");
            }
        }
        public override async Task<OperationResult> GetAllAsync(bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetAllAsync(IsDeleted);
                _logger.LogInformation("Usuarios obtenidos correctamente");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo la lista de Usuarios");
                return OperationResult.Fail("Error al intentar obtener la lista de usuarios.");
            }
        }
        public override async Task<OperationResult> GetByIdAsync(int id, bool? IsDeleted = false)
        {
            try
            {
                var result = await base.GetByIdAsync(id, IsDeleted);
                _logger.LogInformation("Usuario entity obtenido correctamente");
                return result;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error obteniendo el Usuario entity");
                return OperationResult.Fail("Error al intentar obtener el usuario.");
            }
        }
        public override async Task<OperationResult> DeleteAsync(int id)
        {
            try
            {
                var result = await base.DeleteAsync(id);
                _logger.LogInformation("Usuario entity eliminado correctamente");
                return result;

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error eliminando el Usuario entity");
                return OperationResult.Fail("Error al intentar eliminar el usuario.");
            }
        }
    }
}