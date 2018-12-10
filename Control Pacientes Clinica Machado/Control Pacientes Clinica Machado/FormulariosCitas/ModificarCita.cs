using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class ModificarCita : Form
    {
        int id;
        public ModificarCita(int x)
        {
            InitializeComponent();
            Cita listar = new Cita();
            listar = listar.ListarCitas1(x);
            dateTimeFecha.Value = listar.fecha;
            textBox1.Text = listar.hora;
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Clases.Cita Actualizar = new Clases.Cita();
            Actualizar.idCita = id;
            Actualizar.fecha = dateTimeFecha.Value;  
            Actualizar.hora = textBox1.Text;

            if (Actualizar.ActualizarCita(Actualizar))
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
