using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Derivada
{
    public class Cliente : Persona
    {
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        
    }
}
