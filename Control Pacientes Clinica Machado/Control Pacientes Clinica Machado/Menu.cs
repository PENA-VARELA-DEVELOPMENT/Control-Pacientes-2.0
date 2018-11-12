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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AbrirFormHija(new LogoClinica());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Colocar la hora y fecha actual en el formulario
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pacientesBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.pacientesBtn.BackColor = ColorTranslator.FromHtml("#FF7300");
        }

        private void pacientesBtn_MouseUp(object sender, MouseEventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.pacientesBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }

        private void doctoresBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.doctoresBtn.BackColor = ColorTranslator.FromHtml("#FF7300");
        }

        private void doctoresBtn_MouseUp(object sender, MouseEventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.doctoresBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }

        private void citasBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.citasBtn.BackColor = ColorTranslator.FromHtml("#FF7300");
        }

        private void citasBtn_MouseUp(object sender, MouseEventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.citasBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object FormHija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();     
        }

        private void pacientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pacientes());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new LogoClinica());
        }

        private void citasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Citas());
        }
    }
}
