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
        public ListarDoctores()
        {
            InitializeComponent();
        }

        private void ListarDoctores_Load(object sender, EventArgs e)
        {
            Clases.Doctores listar = new Clases.Doctores();
            dgvListarDoctores.DataSource = listar.ListarDoctores();
        }
    }
}
