
using SGI.Appication.Dtos.Inventarios.ProductoDtos;
using SGI.Domain.Entities.Inventarios;

namespace SGI.Appication.MapperDtos.Inventarios
{
    public class ProductoMapperDto
    {
        public Producto MapperProductoDto(ProductoDto dto)
        {
            return new Producto()
            {
                ID = dto.ID,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Garantia = dto.Garantia,
                IsAvailable = dto.IsAvailable,
                Descuento = dto.Descuento,
                Codigo_Barra = dto.Codigo_Barra,
                Marca = dto.Marca,
                Precio = dto.Precio,
                URL_Imagen = dto.URL_Imagen,
                Size = dto.Size,
                ITBIS = dto.ITBIS,
                Fecha_creacion = dto.Fecha_creacion,
                Fecha_modificacion = dto.Fecha_modificacion,
                IsDeleted = dto.IsDeleted
            };
        }

        public ProductoDto MapperProducto(Producto producto)
        {
            return new ProductoDto()
            {
                ID = producto.ID,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Garantia = producto.Garantia,
                IsAvailable = producto.IsAvailable,
                Descuento = producto.Descuento,
                Codigo_Barra = producto.Codigo_Barra,
                Marca = producto.Marca,
                Precio = producto.Precio,
                URL_Imagen = producto.URL_Imagen,
                Size = producto.Size,
                ITBIS = producto.ITBIS,
                Fecha_creacion = producto.Fecha_creacion,
                Fecha_modificacion = producto.Fecha_modificacion,
                IsDeleted = producto.IsDeleted
            };
        }

        public Producto MapperProductoCreate(ProductoCreateDto dto)
        {
            return new Producto()
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Garantia = dto.Garantia,
                IsAvailable = dto.IsAvailable,
                Descuento = dto.Descuento,
                Codigo_Barra = dto.Codigo_Barra,
                Marca = dto.Marca,
                Precio = dto.Precio,
                URL_Imagen = dto.URL_Imagen,
                Size = dto.Size,
                ITBIS = dto.ITBIS
            };
        }

        public Producto MapperProductoUpdate(ProductoUpdateDto dto)
        {
            return new Producto()
            {
                ID = dto.Id,
                Nombre = dto.Nombre ?? "",
                Descripcion = dto.Descripcion,
                Garantia = dto.Garantia,
                IsAvailable = dto.IsAvailable ?? false,
                Descuento = dto.Descuento,
                Codigo_Barra = dto.Codigo_Barra,
                Marca = dto.Marca,
                Precio = dto.Precio ?? 0,
                URL_Imagen = dto.URL_Imagen,
                Size = dto.Size,
                ITBIS = dto.ITBIS ?? 0,
                Fecha_modificacion = DateTime.Now,
                IsDeleted = dto.IsDeleted 
            };
        }

        public Producto MapperProductoDelete(ProductoDeleteDto dto)
        {
            return new Producto()
            {
                ID = dto.Id,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio,
                IsDeleted = dto.IsDeleted
            };
        }

    }
}
