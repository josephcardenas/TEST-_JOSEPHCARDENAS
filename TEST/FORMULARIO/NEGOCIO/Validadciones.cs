using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class Validadciones
    {
        public bool ValidarPersona(string nombre, string apellido, string razon)
        {
            bool esValido = true;

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrWhiteSpace(nombre))
            {
                esValido = false;
            }
            else if (string.IsNullOrEmpty(apellido) && string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
            }




            else if (string.IsNullOrEmpty(razon) && string.IsNullOrWhiteSpace(razon))
            {
                esValido = false;
            }
            else
            {
                int _razon = 0;
                int.TryParse(razon, out _razon);

                if (_razon <= 0)
                {
                    esValido = false;
                }
            }


            return esValido;
        }
    }
}
