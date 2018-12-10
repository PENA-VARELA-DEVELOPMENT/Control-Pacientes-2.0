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
    public partial class NuevaCita : Form
    {
        public string idPaciente;
        public string idDoctor;
        public NuevaCita()
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

            Conexion conn1 = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql1;
            // Query SQL
            sql1 = @"SELECT * FROM [ControlPacientes].[Doctores]";

            SqlCommand cmd1 = conn1.EjecutarComando(sql1);
            SqlDataReader rdr1;

            try
            {
                rdr1 = cmd1.ExecuteReader();

                while (rdr1.Read())
                {
                    comboBox2.Items.Add(rdr1["Nombre"].ToString());

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

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            Clases.Cita Nueva = new Clases.Cita();
            Nueva.fecha = dateTimeDTP.Value;
            Nueva.hora = dateTimePicker1.Text;
            Nueva.pacienteIdentidad = idPaciente;
            MessageBox.Show(idPaciente);
            Nueva.idDoctor = Convert.ToInt32(idDoctor);

            if (Nueva.InsertarCita(Nueva))
            {
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE nombre = @nom";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nom", SqlDbType.VarChar, 80).Value = comboBox1.Text;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idPaciente = rdr["Identidad"].ToString();

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

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Doctores] WHERE Nombre = @nombre";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = comboBox2.Text;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idDoctor = rdr["IdDoctor"].ToString();

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
