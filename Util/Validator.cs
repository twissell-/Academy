using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;   // Para validaciones

namespace Util
{
    public class Validator
    {
        private static bool validate(String txt, String pattern)
        {
            // Validacion generica para ahorar codigo
            Regex regex = new Regex(pattern);
            return regex.IsMatch(txt);
        }

        public static bool validateMail(String txt)
        {
            return validate(txt, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        public static bool validateDni(String txt)
        {
            return validate(txt, @"\d{9}");
        }

        public static bool validateTexto(String txt)
        {
            return validate(txt, @"\w+");
        }

        public static bool validateNacimiento(String txt)
        {
            return validate(txt, @"(\d{2}/){2}/\d{4}");
        }

        public static bool validateTelefono(String txt)
        {
            return validate(txt, @"\d{3,5}-\d{9}");
        }
    }
}
