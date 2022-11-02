using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace casinoform
{
    public partial class Modificarempleado : Form
    {
        empleado EmpleadoModificado = new empleado();
        principal principal = new principal();
        int empleado; 
        public Modificarempleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleado = int.Parse(txtboxIdmodificarempleado.Text);

            EmpleadoModificado.nombre = txtboxNombremodificarempleado.Text;
            EmpleadoModificado.apellido = txtboxApellidomofificarempleado.Text;
            EmpleadoModificado.dni = int.Parse(txtboxDnimodificarempleado.Text);
            EmpleadoModificado.telefono = int.Parse(txtboxTelefonomodificarempleado.Text);
            EmpleadoModificado.direccion = txtboxDireccionmodificarempleado.Text;
            EmpleadoModificado.idEmpleados = int.Parse(txtboxIdmodificarempleado.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.ModificarEmpleado(EmpleadoModificado, EmpleadoModificado.idEmpleados);

            vista fmr = new vista();
            fmr.Show();
            this.Hide();
        }

        private void Modificarempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
