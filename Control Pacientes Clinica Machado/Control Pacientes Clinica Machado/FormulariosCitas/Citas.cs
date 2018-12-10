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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void AbrirFormHija(object FormHija)
        {
            if (this.PanelCrud.Controls.Count > 0)
            {
                this.PanelCrud.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCrud.Controls.Add(fh);
            this.PanelCrud.Tag = fh;
            fh.Show();
        }

        private void pacientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ListarCitas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NuevaCita());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
