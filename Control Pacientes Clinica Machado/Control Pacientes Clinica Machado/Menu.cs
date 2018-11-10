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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Colocar la hora y fecha actual en el formulario
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void doctoresBtn_MouseHover(object sender, EventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.doctoresBtn.BackColor = ColorTranslator.FromHtml("#FF7300");

        }

        private void doctoresBtn_MouseLeave(object sender, EventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.doctoresBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }

        private void pacientesBtn_MouseHover(object sender, EventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.pacientesBtn.BackColor = ColorTranslator.FromHtml("#FF7300");
        }

        private void pacientesBtn_MouseLeave(object sender, EventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.pacientesBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }

        private void citasBtn_MouseHover(object sender, EventArgs e)
        {
            // Al colocar el mouse sobre el boton este cambia de color 
            this.citasBtn.BackColor = ColorTranslator.FromHtml("#FF7300");
        }

        private void citasBtn_MouseLeave(object sender, EventArgs e)
        {
            // Al quitar el mouse sobre el boton estre vuleve a su color original
            this.citasBtn.BackColor = ColorTranslator.FromHtml("#33C42D");
        }
    }
}
