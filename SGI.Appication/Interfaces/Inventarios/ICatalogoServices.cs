

using SGI.Appication.Base;
using SGI.Appication.Dtos.Inventarios.CatalogoDtos;

namespace SGI.Appication.Interfaces.Inventarios
{
    public interface ICatalogoServices : IBaseServices<CatalogoCreateDto, CatalogoUpdateDto, CatalogoDeleteDto>
    {
    }
}
