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

namespace casinoform
{
    public partial class Altaempleado : Form
    {
        empleado nuevoEmpleado = new empleado();
        principal principal = new principal();
        public Altaempleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoEmpleado = new empleado();
            nuevoEmpleado.nombre = textBox3.Text;
            nuevoEmpleado.apellido = textBox4.Text;
            nuevoEmpleado.dni = int.Parse(textBox1.Text);
            nuevoEmpleado.telefono = int.Parse(textBox5.Text);
            nuevoEmpleado.direccion = textBox6.Text;
            nuevoEmpleado.idEmpleados = int.Parse(textBox2.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.AltaEmpleado(nuevoEmpleado, nuevoEmpleado.idEmpleados);

            vista fmr = new vista();
            fmr.Show();
            this.Hide();
        }
    }
}