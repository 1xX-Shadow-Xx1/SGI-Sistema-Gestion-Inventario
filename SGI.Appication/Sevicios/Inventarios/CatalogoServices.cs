

using SGI.Appication.Dtos.Inventarios.CatalogoDtos;
using SGI.Appication.Interfaces.Inventarios;
using SGI.Domain.Base;
using SGI.Persistencia.Interfaces.Inventarios;

namespace SGI.Appication.Sevicios.Inventarios
{
    public class CatalogoServices : ICatalogoServices
    {
        private readonly ICatalogoRepository _catalogoRepo; 

        public CatalogoServices(ICatalogoRepository repository)
        {
            _catalogoRepo = repository;
        }

        public async Task<OperationResult> CreateAsync(CatalogoCreateDto createDto)
        {
            try
            {


            }catch (Exception ex)
            {
                return OperationResult.Fail("Ocurrio un error al crear el catalogo.");
            }
        }

        public async Task<OperationResult> DeleteAsync(CatalogoDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> GetAllAsync(bool? isDeleted)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> GetByIdAsync(int id, bool? isDeleted)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> UpdateAsync(CatalogoUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
