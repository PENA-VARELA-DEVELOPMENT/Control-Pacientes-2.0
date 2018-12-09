using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Pacientes_Clinica_Machado.FormulariosMantenimiento
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Funcion para formularios hijo
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

        private void habilitarPxBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new HabilitarPaciente());
        }

        private void UsuariosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenimientoUsuarios());
        }
    }
}
