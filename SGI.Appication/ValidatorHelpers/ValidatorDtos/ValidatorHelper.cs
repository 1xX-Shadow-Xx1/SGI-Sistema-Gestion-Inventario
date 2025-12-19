namespace SGI.Appication.ValidatorHelpers.ValidatorDtos
{
    public static class ValidatorHelper
    {
        public static bool IsNullObjet<TObject>(TObject? obj, string nameField, out string errorMessage)
        {
            if (obj == null)
            {
                errorMessage = $"{nameField} no puede ser nulo.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }
        public static bool IsNullString(string? str, string atribute, out string errorMessage)
        {
            if(!string.IsNullOrEmpty(str))
            {
                errorMessage = $"{atribute} no puede es obligatorio.";
                return false;
            }
            errorMessage = string.Empty; 
            return true;
        }
        public static bool IsValidateID(int num, out string errorMessage)
        {
            if(num > 0)
            {
                errorMessage = $"El ID ingresado es invalido.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }
        public static bool IsValidateDecimal(decimal num, string nameField, out string errorMessage)
        {
            if(num < 0)
            {
                errorMessage = $"{nameField} ingresado es invalido.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }
        public static bool IsValidateInt(int num, string nameField, out string errorMessage)
        {
            if(num < 0)
            {
                errorMessage = $"{nameField} ingresado es invalido.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }
    }
}
