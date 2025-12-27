using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGI.Domain.Base;
using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;
using SGI.Persistencia.Context;
using SGI.Persistencia.Interfaces.Usuarios;

namespace SGI.Persistencia.Repositorios.Usuarios
{
    public class RolRepository : IRolRepository
    {
        private readonly ILogger<RolRepository> _logger;
        private readonly SGIContext _context;
        private readonly DbSet<RolModel> _dbSet;

        public RolRepository(SGIContext context, ILogger<RolRepository> logger) 
        {
            _context = context;
            _logger = logger;
            _dbSet = context.Set<RolModel>();
        }

        public async Task<OperationResult> DeleteAsync(RolModel rolmodel)
        {
            try
            {

                _dbSet.Remove(rolmodel);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"El rol con id {rolmodel.id} ha sido eliminado.");
                return OperationResult.Ok("Eliminado correctamente.");

            }catch(Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar el rol.");
                throw ex;
            }
        }
        public async Task<OperationResult> GetAllAsync()
        {
            try
            {
                var listaModel = await _dbSet.ToListAsync();
                _logger.LogInformation("Se obtuvo la lista de roles correctamente.");
                return OperationResult.Ok("Se obtuvo la lista correctamente.", listaModel);

            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la lista de roles.");
                throw ex;
            }
        }
        public async Task<OperationResult> GetByIdAsync(int id)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                var rolmodel = await query.FirstOrDefaultAsync(r => r.id == id);
                if(rolmodel == null)
                {   
                    _logger.LogInformation($"Se intento obtener el rol con id {id}, pero no se encontró.");
                    return OperationResult.Fail("No se encontro ninguno rol con ese id.");
                }
                _logger.LogInformation($"Se obtuvo el rol con id {id} correctamente.");
                return OperationResult.Ok("Se obtuvo el rol correctamente.", rolmodel);
                
            }catch(Exception ex)
            {
                _logger.LogError(ex, $"Error al obtener el rol con id {id}.");
                throw ex;
            }
        }
        public async Task<OperationResult> SaveAsync(RolModel rolmodel)
        {
            try
            {
                _dbSet.Add(rolmodel);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Se ha guardado un nuevo rol correctamente.");
                return OperationResult.Ok("Se ha guardado correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar un nuevo rol.");
                throw ex;
            }
        }
        public async Task<OperationResult> UpdateAsync(RolModel rolmodel)
        {
            try
            {
                _dbSet.Update(rolmodel);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"El rol con id {rolmodel.id} ha sido actualizado correctamente.");
                return OperationResult.Ok("Se a actualizado correctamente.", rolmodel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al actualizar el rol con id {rolmodel.id}.");
                throw ex;
            }
        }
    }
}
