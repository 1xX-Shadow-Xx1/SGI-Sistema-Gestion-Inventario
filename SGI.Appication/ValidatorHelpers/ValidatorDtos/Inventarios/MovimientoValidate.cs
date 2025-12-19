using SGI.Appication.ValidatorHelpers.ValidatorDtos;
using SGI.Domain.Entities.Operacion;

namespace SGI.Appication.ValidatorHelpers.ValidatorDtos.Inventarios
{
    public class MovimientoValidate
    {
        public static bool ValidateSave(MovimientoInventario movimiento, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<MovimientoInventario>(movimiento, "El movimiento", out  errorMessage)) return false;
            if (!ValidatorHelper.IsValidateInt(movimiento.Cantidad, "La cantidad", out errorMessage)) return false;
            return true;
        }
    }
}
