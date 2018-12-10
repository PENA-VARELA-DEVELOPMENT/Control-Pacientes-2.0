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

namespace Control_Pacientes_Clinica_Machado.FormulariosMantenimiento
{
    public partial class HabilitarPaciente : Form
    {
        public HabilitarPaciente()
        {
            InitializeComponent();
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE Estado = 0";

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
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE Estado = 0";

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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Paciente habilitar = new Paciente();
            if (habilitar.Habilitar(comboBox1.Text))
            {
                inhabilitadoPicBox.Visible = false;
                habilitadoPicBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
            // Mostrar barrita de inhabiltado a habilitado
            // Esto saldría luego de haberse cambiado el estado
            // de inhabilitado a habilitado en la base de datos
            


        

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Mensaje de control
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
    }
}
