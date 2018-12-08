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

namespace Control_Pacientes_Clinica_Machado
{
    public partial class DarDeBajaPaciente : Form
    {
        public DarDeBajaPaciente()
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Paciente DarDeBaja = new Paciente();
            DarDeBaja.identidad = "0318-1999-00191";
            DarDeBaja.nombre = nombreTxt.Text;
            DarDeBaja.DarDeBaja(DarDeBaja);
        }
    }
}
