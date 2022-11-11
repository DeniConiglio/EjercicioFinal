using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleado.Models.Derivada;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado1 = new Empleado() { Legajo = "1", Id = 122, Nombre = "Alejandro", Apellido = "Lopez" };
            Empleado empleado2 = new Empleado() { Legajo = "12", Id = 456, Nombre = "Alejo", Apellido = "Gonzales" };
            Empleado empleado3 = new Empleado() { Legajo = "45", Id = 952, Nombre = "pepe", Apellido = "Perez" };
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);


            Departamento departamento = new Departamento() { Id = 12, Nombre = "juan", ListaEmpleados = empleados };
            gridEmpleados.DataSource= departamento.ListaEmpleados;


        }

        
    }
}
