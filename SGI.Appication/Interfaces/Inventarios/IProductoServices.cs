

using SGI.Appication.Base;
using SGI.Appication.Dtos.Inventarios.ProductoDtos;

namespace SGI.Appication.Interfaces.Inventarios
{
    public interface IProductoServices : IBaseServices<ProductoCreateDto, ProductoUpdateDto, ProductoDeleteDto>
    {            
    }
}
