using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Derivada
{
    public class Empleado : Persona
    {
        

        public Empleado()
        {
            
        }

        public Empleado(string legajo)
        {
            Legajo = legajo;
        }


        public string Legajo { get; set; }

    }
}
