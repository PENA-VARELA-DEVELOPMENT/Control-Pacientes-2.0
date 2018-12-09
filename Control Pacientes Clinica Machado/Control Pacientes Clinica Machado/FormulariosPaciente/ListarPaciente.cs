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
using Control_Pacientes_Clinica_Machado.FormulariosPaciente;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class ListarPaciente : Form
    {
        string x;
        public ListarPaciente()
        {
            InitializeComponent();
        }

        private void ListarPaciente_Load(object sender, EventArgs e)
        {
            Paciente listar = new Paciente();
            dvgListarPaciente.DataSource = listar.ListarPaciente();
        }

        private void dvgListarPaciente_SelectionChanged(object sender, EventArgs e)
        {
             x = dvgListarPaciente.CurrentRow.Cells["Identidad"].Value.ToString();
        }

        private void btnVerExpediente_Click(object sender, EventArgs e)
        {
            //Expendiente vista = new Expendiente(x);
            //vista.Show();   

            Expendiente vista = new Expendiente(x);
            vista.ShowDialog();
            //menu.abrirExpediente(x);

        }
    }
}
