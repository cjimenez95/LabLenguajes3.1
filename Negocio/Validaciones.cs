
using System;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class Validaciones
    {

        public Boolean soloNumeros(String palabra)
        {
            return Regex.IsMatch(palabra, "[a-zA-Z]");
        }

        public Boolean soloLetras(String palabra)
        {
            return Regex.IsMatch(palabra, "[0-9]");
        }
        public Boolean validarTamanno(String palabra)
        {
            palabra = palabra.Trim();
            return (palabra.Length == 0);
        }

        public Boolean correo(String palabra)
        {

            return Regex.IsMatch(palabra, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

        }


    }
}
