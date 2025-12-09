using SGI.Domain.Entities.Usuarios;

namespace SGI.Domain.ValidatorHelpers.Usuarios
{
    public class UsuarioValidate
    {
        public static bool ValidateSave(Usuario usuario, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Usuario>(usuario, "El usuario", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Nombre, "El nombre", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Empleado, "El nombre del empleado", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Correo, "El correo", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Contraseña, "La contraseña", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateUpdate(Usuario usuario, out string errorMessage)
        {
            if (!ValidatorHelper.IsNullObjet<Usuario>(usuario, "El usuario", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(usuario.ID, out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Nombre, "El nombre", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Empleado, "El nombre del empleado", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Correo, "El correo", out errorMessage)) return false;
            if (!ValidatorHelper.IsNullString(usuario.Contraseña, "La contraseña", out errorMessage)) return false;
            return true;
        }

        public static bool ValidateRemove(Usuario usuario, out string errorMessage)
        { 
            if (!ValidatorHelper.IsNullObjet<Usuario>(usuario, "El usuario", out errorMessage)) return false;
            if (!ValidatorHelper.IsValidateID(usuario.ID, out errorMessage)) return false;
            return true;
        }
    }
}
