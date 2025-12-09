using SGI.Domain.Entities.Usuarios;

namespace SGI.Domain.ValidatorHelpers.Usuarios
{
    public class RolValidate
    {
        public static bool ValidateSave(Rol rol, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Rol>(rol, "El rol", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(rol.Nombre, "El nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Rol rol, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Rol>(rol, "El rol", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(rol.Id, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(rol.Nombre, "El nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Rol rol, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Rol>(rol, "El rol", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(rol.Id, out errorMessage)) return false;
            return true;
        }
    }
}
