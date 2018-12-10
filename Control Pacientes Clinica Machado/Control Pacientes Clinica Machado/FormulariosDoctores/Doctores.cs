using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
        }

        // Funcion para formularios hijos
        private void AbrirFormHija(object FormHija)
        {
            if (this.PanelCrudDoctor.Controls.Count > 0)
            {
                this.PanelCrudDoctor.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCrudDoctor.Controls.Add(fh);
            this.PanelCrudDoctor.Tag = fh;
            fh.Show();
        }
        private void buscarDoctorBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormulariosDoctores.ListarDoctores());
        }

        private void nuevaDoctorBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormulariosDoctores.NuevoDoctor());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
