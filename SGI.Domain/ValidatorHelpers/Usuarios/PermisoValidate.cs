using SGI.Domain.Entities.Usuarios;

namespace SGI.Domain.ValidatorHelpers.Usuarios
{
    public class PermisoValidate
    {
        public static bool ValidateSave(Permiso permiso, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Permiso>(permiso, "El permiso", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(permiso.Nombre, "El nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Permiso permiso, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Permiso>(permiso, "El permiso", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(permiso.Id, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(permiso.Nombre, "El nombre", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Permiso permiso, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Permiso>(permiso, "El permiso", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(permiso.Id, out errorMessage)) return false;
            return true;
        }
    }
}
