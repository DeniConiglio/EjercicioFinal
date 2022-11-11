using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Derivada
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List <Empleado> ListaEmpleados { get; set; }


        public Departamento(int id, string nombre, List<Empleado> listaEmpleados)
        {
            Id = id;
            Nombre = nombre;
            ListaEmpleados = listaEmpleados;
        }

        public Departamento()
        {
        }
    }
}
