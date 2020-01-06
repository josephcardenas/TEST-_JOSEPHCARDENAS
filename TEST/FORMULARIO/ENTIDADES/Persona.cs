using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Razon { get; set; }
        public string Aplicale { get; set; }

        public Persona() { }
        
        /*
        public Persona(String pNombre,String pApellido,String pRazon, String  pAplicale)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Razon = pRazon;
            this.Aplicale = pAplicale;
        }
        */
    }
}
