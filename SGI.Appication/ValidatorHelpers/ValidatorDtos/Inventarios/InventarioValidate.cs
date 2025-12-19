using SGI.Appication.ValidatorHelpers.ValidatorDtos;
using SGI.Domain.Entities.Inventarios;

namespace SGI.Appication.ValidatorHelpers.ValidatorDtos.Inventarios
{
    public class InventarioValidate
    {
        public static bool ValidateSave(Inventario inventario, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Inventario>(inventario, "El inventario", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullObjet<Producto>(inventario.Producto, "El producto", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Inventario inventario, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Inventario>(inventario, "El inventario", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(inventario.ID, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullObjet<Producto>(inventario.Producto, "El producto", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Inventario inventario, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Inventario>(inventario, "El inventario", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(inventario.ID, out errorMessage)) return false;
            return true;
        }
    }
}
