using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    public partial class DarDeBajaDoctor : Form
    {
        public DarDeBajaDoctor()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
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

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            Clases.Doctores DarDeBaja = new Clases.Doctores();
            DarDeBaja.nombre = nombreTxt.Text;
            DarDeBaja.apellido = nombreTxt.Text;
            DarDeBaja.EliminarDoctor(DarDeBaja);
        }
    }
}
