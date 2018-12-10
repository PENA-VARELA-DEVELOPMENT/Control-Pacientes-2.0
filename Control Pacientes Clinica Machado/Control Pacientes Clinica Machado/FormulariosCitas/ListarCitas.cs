using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class ListarCitas : Form
    {
        public string x;
        public string buscar;
        public ListarCitas()
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
                    ListarComBox.Items.Add(rdr["nombre"].ToString());
                    ListarComBox.AutoCompleteCustomSource = CargarDatos();
                    ListarComBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    ListarComBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Clases.Cita Eliminar = new Cita();
            if (Eliminar.Eliminar(x))
            {
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void dgvListarCita_SelectionChanged(object sender, EventArgs e)
        {
            x = dgvListarCita.CurrentRow.Cells["IdCita"].Value.ToString();
        }

        private void ListarComBox_TextChanged(object sender, EventArgs e)
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
                    cmd.Parameters.Add("name", SqlDbType.VarChar, 80).Value = ListarComBox.Text;

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

        private void buscarCitaBtn_Click(object sender, EventArgs e)
        {
            Cita listar = new Cita();
            dgvListarCita.DataSource = listar.ListarCitas(buscar);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ModificarCita vista = new ModificarCita(Convert.ToInt32(x));
            vista.ShowDialog();
        }
    }
}
