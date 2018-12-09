using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class Login : Form
    {
        Menu menu = new Menu();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema", "Clínica Dental Machado", MessageBoxButtons.OK);
            

            menu.Show();
            this.Hide();
        }
    }
}
