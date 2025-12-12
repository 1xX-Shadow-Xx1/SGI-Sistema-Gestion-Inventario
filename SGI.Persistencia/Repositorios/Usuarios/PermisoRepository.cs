using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Models.Usuarios;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Usuarios;
using SGI.Persistencia.Mappers.Usuarios;

namespace SGI.Persistencia.Repositorios.Usuarios
{
    public class PermisoRepository : IPermisoRepository
    {
        private readonly SGIContext _context;
        private readonly ILogger<PermisoRepository> _logger;
        private readonly DbSet<PermisoModel> _dbset;

        public PermisoRepository(SGIContext context, ILogger<PermisoRepository> logger)
        {
            _context = context;
            _logger = logger;
            _dbset = _context.Set<PermisoModel>();
        }

        public async Task<OperationResult> GetAllPermisosAsync()
        {
            try
            {
                var listModel = await _dbset.ToListAsync();
                var listPermisos = PermisoMapperModel.MapperListPermiso(listModel);
                _logger.LogInformation("Lista de permisos obtenida correctamente en el metodo GetAllPermisosAsync.");
                return OperationResult.Ok("Lista de permisos obtenida correctamente.", listPermisos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la lista de permisos en el metodo GetAllPermisosAsync.");
                throw ex;
            }
        }
    }
}
