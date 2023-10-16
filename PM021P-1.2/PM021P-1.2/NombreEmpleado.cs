using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PM021P_1._2
{
    public class NombreEmpleado
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }

        public bool IsValid()
        {

            if (string.IsNullOrWhiteSpace(Correo))
            {
                return false; // El campo de correo está vacío o solo contiene espacios en blanco.
            }

            string correoPattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            if (!Regex.IsMatch(Correo, correoPattern))
            {
                return false; // El correo no cumple con el formato válido.
            }

            return true;
        }
    }
}
