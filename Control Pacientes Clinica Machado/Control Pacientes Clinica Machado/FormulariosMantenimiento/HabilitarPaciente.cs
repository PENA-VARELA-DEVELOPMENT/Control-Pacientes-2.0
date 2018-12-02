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
    public partial class HabilitarPaciente : Form
    {
        public HabilitarPaciente()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            // Mostrar barrita de inhabiltado a habilitado
            // Esto saldría luego de haberse cambiado el estado
            // de inhabilitado a habilitado en la base de datos
            inhabilitadoPicBox.Visible = false;
            habilitadoPicBox.Visible = true;
        

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Mensaje de control
            string message = "¿Esta seguro que desea cancelar el proceso?";
            string caption = "Control de Pacientes Clinica Machado";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;

            DialogResult result;
            result = MessageBox.Show(message, caption, button);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
