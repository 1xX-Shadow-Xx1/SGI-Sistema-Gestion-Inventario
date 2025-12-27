

using SGI.Appication.Base;
using SGI.Appication.Dtos.Inventarios.InventarioDtos;

namespace SGI.Appication.Interfaces.Inventarios
{
    public interface IInventarioServices : IBaseServices<InventarioCreateDto, InventarioUpdateDto, InventarioDeleteDto>
    {
    }
}
