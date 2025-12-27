
using SGI.Appication.Base;
using SGI.Appication.Dtos.Usuarios.UsuarioDtos;

namespace SGI.Appication.Interfaces.Usuarios
{
    public interface IUsuarioServices : IBaseServices<UsuarioCreateDto, UsuarioUpdateDto, UsuarioDeleteDto>
    {
    }
}
