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
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class ListarPaciente : Form
    {
        string x;
        string buscar;
        public ListarPaciente()
        {
            InitializeComponent();

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE Estado = 1";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr["nombre"].ToString());
                    comboBox1.AutoCompleteCustomSource = CargarDatos();
                    comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        

        private AutoCompleteStringCollection CargarDatos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE Estado = 1";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    datos.Add(rdr["nombre"].ToString());

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
            return datos;
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

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            Paciente DarDeBaja = new Paciente();
            if (DarDeBaja.DarDeBaja(x))
            {
                MessageBox.Show("Exito!");
            }
            else
	        {
                MessageBox.Show("Error!");
            }
	{

            }

            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Paciente listar = new Paciente();
            dvgListarPaciente.DataSource = listar.ObtenerPaciente1(buscar);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE nombre = @name";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("name", SqlDbType.VarChar, 80).Value = comboBox1.Text;
                    
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    buscar = rdr["Identidad"].ToString();
                    
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
