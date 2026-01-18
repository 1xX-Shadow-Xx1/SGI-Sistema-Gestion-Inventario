

using SGI.Appication.Dtos.Inventarios.CatalogoDtos;
using SGI.Domain.Entities.Inventarios;

namespace SGI.Appication.MapperDtos.Inventarios
{
    public class CatalogoMappperDto
    {
        public CatalogoDto MapperCatalogo(Catalogo catalogo)
        {
            return new CatalogoDto()
            {
                Nombre = catalogo.Nombre,
                Descripcion = catalogo.Descripcion,
                ID = catalogo.ID,
                Fecha_creacion = catalogo.Fecha_creacion,
                Fecha_modificacion = catalogo.Fecha_modificacion,
                IsDeleted = catalogo.IsDeleted
            };
        }

        public Catalogo MapperCatalogoCreate(CatalogoCreateDto dto)
        {
            return new Catalogo()
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion
            };
        }

        public Catalogo MapperCatalogoUpdate(CatalogoUpdateDto dto)
        {
            return new Catalogo()
            {
                ID = dto.Id,
                Nombre = dto.Nombre ?? "",
                Descripcion = dto.Descripcion,
                IsDeleted = dto.IsDeleted
            };
        }

        public Catalogo MapperCatalogoDelete(CatalogoDeleteDto dto)
        {
            return new Catalogo()
            {
                ID = dto.Id,
                Nombre = dto.Nombre,
                Descripcion= dto.Descripcion,
                IsDeleted = dto.IsDeleted
            };
        }

    }
}
