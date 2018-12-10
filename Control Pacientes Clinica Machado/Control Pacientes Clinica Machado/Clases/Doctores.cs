using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    class Doctores
    {
        // Propiedades para la clase
        public int idDoctor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string especialidad { get; set; }
        public int numeroColegiacion { get; set; }

        public List<Doctores> ListarDoctores()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            List<Doctores> Lista = new List<Doctores>();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Doctores] Order by IdDoctor"; 

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Doctores resultado = new Doctores();
                    resultado.idDoctor = rdr.GetInt32(0);
                    resultado.nombre = rdr.GetString(1);
                    resultado.apellido = rdr.GetString(2);
                    resultado.especialidad = rdr.GetString(3);
                    resultado.numeroColegiacion = rdr.GetInt32(4);
                    Lista.Add(resultado);
                }

                return Lista;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return Lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public Doctores ObtenerDoctor(int id)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            Doctores resultado = new Doctores();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Doctores] WHERE IdDoctor = @id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    
                    resultado.idDoctor = rdr.GetInt32(0);
                    resultado.nombre = rdr.GetString(1);
                    resultado.apellido = rdr.GetString(2);
                    resultado.especialidad = rdr.GetString(3);
                    resultado.numeroColegiacion = rdr.GetInt32(4);                   
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// se encarga de guardar un nuevo Paciente en la base de datos, recibe 
        /// como parametros un objeto de tipo Paciente.
        /// </summary>
        /// <returns>true: si se insertó correctamente false: si ocurrió un error</returns>
        public bool InsertarDoctor(Doctores doctor)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevoDoctores");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@Nombre"].Value = doctor.nombre;

            cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 50));
            cmd.Parameters["@Apellido"].Value = doctor.apellido;

            cmd.Parameters.Add(new SqlParameter("@Especialidad", SqlDbType.VarChar, 100));
            cmd.Parameters["@Especialidad"].Value = doctor.especialidad;

            cmd.Parameters.Add(new SqlParameter("@NumeroColegiacion", SqlDbType.Int));
            cmd.Parameters["@NumeroColegiacion"].Value = doctor.numeroColegiacion;

            // intentamos insertar el nuevo doctor
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
        /// Actualiza los datos de un Paciente en particular
        /// </summary>
        /// <param name="elPaciente"></param>
        /// <returns></returns>
        public bool ActualizarDoctor(Doctores doctor)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_ActualizarDoctores");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@IdDoctor", SqlDbType.Int));
            cmd.Parameters["@IdDoctor"].Value = doctor.idDoctor;


            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@Nombre"].Value = doctor.nombre;

            cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 50));
            cmd.Parameters["@Apellido"].Value = doctor.apellido;

            cmd.Parameters.Add(new SqlParameter("@Especialidad", SqlDbType.VarChar, 100));
            cmd.Parameters["@Especialidad"].Value = doctor.especialidad;

            cmd.Parameters.Add(new SqlParameter("@NumeroColegiacion", SqlDbType.Int));
            cmd.Parameters["@NumeroColegiacion"].Value = doctor.numeroColegiacion;

            // intentamos insertar al nuevo Doctor
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

        public bool EliminarDoctor(int id)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_EliminarDoctores");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@IdDoctor", SqlDbType.Int));
            cmd.Parameters["@IdDoctor"].Value = id;


            // intentamos insertar al nuevo Doctor
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
