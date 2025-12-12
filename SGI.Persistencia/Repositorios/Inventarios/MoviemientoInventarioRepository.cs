using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Models.Inventarios;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Inventarios;

namespace SGI.Persistencia.Repositorios.Inventarios
{
    public class MoviemientoInventarioRepository : IMovimientoInventarioRepository
    {
        private readonly SGIContext _context;
        private readonly ILogger<MoviemientoInventarioRepository> _logger;
        private readonly DbSet<MovimientoInventarioModel> _dbSet;

        public MoviemientoInventarioRepository(SGIContext context, ILogger<MoviemientoInventarioRepository> logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = _context.Set<MovimientoInventarioModel>();
        }

        public async Task<OperationResult> SaveAsync(MovimientoInventarioModel model)
        {
            try
            {
                await _dbSet.AddAsync(model);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Movimiento de inventario guardado correctamente");
                return OperationResult.Ok("Guardado correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando el movimiento de inventario en SaveAsync");
                return OperationResult.Fail("Ocurrio un error al guardar.");
            }
        }
        public async Task<OperationResult> DeleteAsync(MovimientoInventarioModel model)
        {
            try
            {
                _dbSet.Remove(model);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Movimiento de inventario eliminado correctamente");
                return OperationResult.Ok("Eliminado correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error eliminando el movimiento de inventario en DeleteAsync");
                return OperationResult.Fail("Ocurrio un error al eliminar.");
            }
        }
    }
}
