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
    public partial class Altacliente : Form

    {
        cliente nuevoCliente = new cliente();
        principal principal = new principal();
        public Altacliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoCliente = new cliente();
            nuevoCliente.nombre = txtboxNombrecliente.Text;
            nuevoCliente.apellido = txtboxApellidocliente.Text;
            nuevoCliente.dni = int.Parse(txtboxDnicliente.Text);
            nuevoCliente.telefono = int.Parse(txtboxTelefonocliente.Text);
            nuevoCliente.direccion = txtboxDireccioncliente.Text;
            nuevoCliente.idClientes = int.Parse(txtboxIdcliente.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.AltaCliente(nuevoCliente, nuevoCliente.idClientes);

            vistagrillacliente fmr = new vistagrillacliente();
            fmr.Show();
            this.Hide();
        }

        private void Altacliente_Load(object sender, EventArgs e)
        {

        }
    }
}