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
    public partial class ListarDoctores : Form
    {
        string x;
        public ListarDoctores()
        {
            InitializeComponent();
            Clases.Doctores listar = new Clases.Doctores();
            dgvListarDoctores.DataSource = listar.ListarDoctores();
        }

        private void ListarDoctores_Load(object sender, EventArgs e)
        {
            Clases.Doctores listar = new Clases.Doctores();
            dgvListarDoctores.DataSource = listar.ListarDoctores();
        }

        private void modificarDoctorBtn_Click(object sender, EventArgs e)
        {
            AgendaDoctor vista = new AgendaDoctor();
            vista.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarDoctor vista = new ActualizarDoctor(x);
            vista.ShowDialog();
        }

        private void dgvListarDoctores_SelectionChanged(object sender, EventArgs e)
        {
            x = dgvListarDoctores.CurrentRow.Cells["IdDoctor"].Value.ToString();
        }

        private void darBajaBtn_Click(object sender, EventArgs e)
        {
            Clases.Doctores elim = new Clases.Doctores();
            if (elim.EliminarDoctor(Convert.ToInt32(x)))
            {
                MessageBox.Show("Listo!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }
    }
}
