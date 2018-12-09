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
    public partial class ActualizarPaciente : Form
    {
        public ActualizarPaciente()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormHija(object FormHija)
        {
            if (this.panelContenedorOdontograma.Controls.Count > 0)
            {
                this.panelContenedorOdontograma.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorOdontograma.Controls.Add(fh);
            this.panelContenedorOdontograma.Tag = fh;
            fh.Show();
        }

        private void ActualizarPaciente_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new Odontograma());
        }
    }
}
