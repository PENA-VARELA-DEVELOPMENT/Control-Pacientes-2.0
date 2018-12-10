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

using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.FormulariosPaciente
{
    public partial class VerFotos : Form
    {
        string identidad;
        public VerFotos(string x)
        {
            InitializeComponent();
            identidad = x;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FotosPaciente Listar = new FotosPaciente();
            Listar = Listar.ListarFotosPaciente(cmbNombres.Text);
            label1.Text = Listar.nombre;
            pictureBox1.Image = Image.FromStream(Listar.Foto);
            


        }

        private void VerFotos_Load(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[FotoPaciente] WHERE Paciente_identidad = @identidad";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.VarChar, 15).Value = identidad;
                    rdr = cmd.ExecuteReader();
                }
                

                while (rdr.Read())
                {
                    cmbNombres.Items.Add(rdr["nombre"].ToString());
                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
