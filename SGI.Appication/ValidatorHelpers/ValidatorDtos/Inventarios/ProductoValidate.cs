using SGI.Appication.ValidatorHelpers.ValidatorDtos;
using SGI.Domain.Entities.Inventarios;

namespace SGI.Appication.ValidatorHelpers.ValidatorDtos.Inventarios
{
    public class ProductoValidate
    {
        public static bool ValidateSave(Producto producto, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Producto>(producto, "El producto", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(producto.Nombre, "El nombre", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateDecimal(producto.Precio, "El precio", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Producto producto, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Producto>(producto, "El producto", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(producto.ID, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(producto.Nombre, "El nombre", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateDecimal(producto.Precio, "El precio", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Producto producto, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Producto>(producto, "El producto", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(producto.ID, out errorMessage)) return false;
            return true;
        }
    }
}
