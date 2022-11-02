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
    public partial class Modificarcliente : Form
    {
        cliente ClienteModificado = new cliente();
        principal principal = new principal();
        int Cliente;
        public Modificarcliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente = int.Parse(txtboxIdmodificarcliente.Text);

            ClienteModificado.nombre = txtboxNombremodificarcliente.Text;
            ClienteModificado.apellido = txtboxApellidomodificarcliente.Text;
            ClienteModificado.dni = int.Parse(txtboxDnimodificarcliente.Text);
            ClienteModificado.telefono = int.Parse(txtboxTelefonomodificarcliente.Text);
            ClienteModificado.direccion = txtboxDireccionmodificarcliente.Text;
            ClienteModificado.idClientes = int.Parse(txtboxIdmodificarcliente.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.ModificarCliente(ClienteModificado, Cliente );

            vistagrillacliente fmr = new vistagrillacliente();
            fmr.Show();
            this.Hide();
        }

        private void Modificarcliente_Load(object sender, EventArgs e)
        {

        }
    }
}