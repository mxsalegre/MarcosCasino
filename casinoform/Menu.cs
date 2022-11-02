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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            vistagrillacliente fmr = new vistagrillacliente();
            fmr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vista fmr = new vista();
            fmr.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
