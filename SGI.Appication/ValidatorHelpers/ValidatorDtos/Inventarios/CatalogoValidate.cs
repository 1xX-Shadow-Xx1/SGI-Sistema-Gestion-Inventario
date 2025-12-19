using SGI.Appication.ValidatorHelpers.ValidatorDtos;
using SGI.Domain.Entities.Inventarios;

namespace SGI.Appication.ValidatorHelpers.ValidatorDtos.Inventarios
{
    public class CatalogoValidate
    {
        public static bool ValidateSave(Catalogo catalogo, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Catalogo>(catalogo, "El catalogo", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(catalogo.Nombre, "E nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Catalogo catalogo, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Catalogo>(catalogo, "El catalogo", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(catalogo.ID, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(catalogo.Nombre, "E nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Catalogo catalogo, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Catalogo>(catalogo, "El catalogo", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(catalogo.ID, out errorMessage)) return false;
            return true;
        }
    }
}
