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
    public partial class ActualizarDoctor : Form
    {
        string id;
        public ActualizarDoctor(string x)
        {
            InitializeComponent();
            id = x;
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Doctores Actualizar = new Clases.Doctores();
            Actualizar.idDoctor = Convert.ToInt32(id);
            Actualizar.nombre = nombreTxt.Text;
            Actualizar.apellido = apellidoTxt.Text;
            Actualizar.especialidad = especialidadTxt.Text;
            Actualizar.numeroColegiacion = Convert.ToInt32(colegiacionTxt.Text);

            if (Actualizar.ActualizarDoctor(Actualizar))
            {
                MessageBox.Show("Exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ActualizarDoctor_Load(object sender, EventArgs e)
        {
            Clases.Doctores listar = new Clases.Doctores();
            listar = listar.ObtenerDoctor(Convert.ToInt32(id));
            nombreTxt.Text = listar.nombre;
            apellidoTxt.Text = listar.apellido;
            especialidadTxt.Text = listar.especialidad;
            colegiacionTxt.Text = Convert.ToString(listar.numeroColegiacion);
        }
    }
}
