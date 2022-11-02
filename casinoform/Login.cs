using System;
using System.Windows.Forms;

namespace casinoform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool validarUsuario(string nombre, string clave)
        {
            // me voy a la base de usuarios a revisar par aese nombre y para esa clave
            // por ahora, lo hago a mano

            return (nombre == "Marcos") && (clave == "123");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text.Length > 0)
            {
                // deberían ir a la lista de usuarios, y rescatar el que tiene el mismo del TExt
                // validan el password.

                if (validarUsuario(txtuser.Text.Trim(), txtpass.Text.Trim()))
                {
                    Menu fmr = new Menu();
                    fmr.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario");

            }

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
