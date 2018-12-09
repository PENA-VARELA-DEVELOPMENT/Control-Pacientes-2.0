using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    public class Cita
    {
        // Propiedades para la clase 
        public int idCita { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string pacienteIdentidad { get; set; }
        public int idDoctor { get; set; }

        /// <summary>
        /// Obtiene un solo paciente de la tabla pacientes
        /// </summary>
        /// <param name="idCita"></param>
        /// <returns></returns>
        public static Cita ObtenerCita(int idCita)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            Cita resultado = new Cita();

            // Query SQL
            sql = @"SELECT *
                    FROM ControlPacientes.Cita
                    WHERE id = @id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCita;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idCita = rdr.GetInt32(0);
                    resultado.fecha = rdr.GetDateTime(1);
                    resultado.hora = rdr.GetDateTime(2);
                    resultado.pacienteIdentidad = rdr.GetString(3);
                    resultado.idDoctor = rdr.GetInt32(4);
                }

                return resultado;

            }
            catch (SqlException)
            {

                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

            // metodo para obtener las listas 
        public List<Cita> ListarCitas()
        {
            Conexion conexion = new Conexion();
            string sql;
            //Cita resultado = new Cita();

            List<Cita> Lista = new List<Cita>();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Cita]";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                 while (rdr.Read())
                 {
                    Cita resultado = new Cita();
                    resultado.idCita = rdr.GetInt32(0);
                    resultado.fecha = rdr.GetDateTime(1);
                    resultado.hora = rdr.GetDateTime(2);
                    resultado.pacienteIdentidad = rdr.GetString(4);
                    resultado.idDoctor = rdr.GetInt32(5);
                    Lista.Add(resultado);
                 }

                return Lista;
            }
            catch (SqlException)
            {

                return Lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // 
        public bool InsertarCita(Cita citaPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaCita");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos
            cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
            cmd.Parameters["@fecha"].Value = citaPaciente.fecha;

            cmd.Parameters.Add(new SqlParameter("@hora", SqlDbType.DateTime));
            cmd.Parameters["@hora"].Value = citaPaciente.hora;

            cmd.Parameters.Add(new SqlParameter("@paciente_Identidad", SqlDbType.VarChar, 15));
            cmd.Parameters["@paciente_Identidad"].Value = citaPaciente.pacienteIdentidad;

            cmd.Parameters.Add(new SqlParameter("@IdDoctor", SqlDbType.Int));
            cmd.Parameters["@IdDoctor"].Value = citaPaciente.idDoctor;

            // intentamos insertar la nueva cita
            try
            {

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza la cita de un Paciente en particular
        /// </summary>
        /// <param name="citaPaciente"></param>
        /// <returns></returns>
        public static bool ActualizarCita(Cita citaPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_ActualizarCita");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
            cmd.Parameters["@fecha"].Value = citaPaciente.fecha;

            cmd.Parameters.Add(new SqlParameter("@hora", SqlDbType.DateTime));
            cmd.Parameters["@hora"].Value = citaPaciente.hora;

            cmd.Parameters.Add(new SqlParameter("@paciente_Identidad", SqlDbType.VarChar, 15));
            cmd.Parameters["@paciente_Identidad"].Value = citaPaciente.pacienteIdentidad;

            cmd.Parameters.Add(new SqlParameter("@IdDoctor", SqlDbType.Int));
            cmd.Parameters["@IdDoctor"].Value = citaPaciente.idDoctor;

            // intentamos insertar la nueva Cita
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }

        }

        public bool Eliminar(string citaPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_EliminarCitas");
            cmd.CommandType = CommandType.StoredProcedure;


            // agregamos los parámetros que son requeridos
            cmd.Parameters.Add(new SqlParameter("@IdCita", SqlDbType.Int));
            cmd.Parameters["@IdCita"].Value = citaPaciente;

            // intentamos eliminar la cita
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
