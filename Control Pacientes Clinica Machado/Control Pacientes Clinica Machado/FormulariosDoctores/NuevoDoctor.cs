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
    public partial class NuevoDoctor : Form
    {
        public NuevoDoctor()
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Doctores Nuevo = new Clases.Doctores();
            Nuevo.nombre = nombreTxt.Text;
            Nuevo.apellido = apellidoTxt.Text;
            Nuevo.especialidad = especialidadTxt.Text;
            Nuevo.numeroColegiacion = Convert.ToInt32(colegiacionTxt.Text);

            if (Nuevo.InsertarDoctor(Nuevo))
            {
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
