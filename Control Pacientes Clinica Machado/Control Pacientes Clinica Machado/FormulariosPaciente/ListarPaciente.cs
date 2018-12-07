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
    public partial class ListarPaciente : Form
    {
        public ListarPaciente()
        {
            InitializeComponent();
        }

        private void ListarPaciente_Load(object sender, EventArgs e)
        {
            Paciente listar = new Paciente();
            dvgListarPaciente.DataSource = listar.ListarPaciente();
        }
    }
}
