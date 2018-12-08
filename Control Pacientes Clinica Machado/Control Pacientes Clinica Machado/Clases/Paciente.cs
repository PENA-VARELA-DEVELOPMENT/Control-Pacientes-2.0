using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    class Paciente
    {
        // Propiedades para la clase
        public string tipo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string identidad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string ciudad { get; set; }
        public string fechaNacimiento { get; set; }
        public string ocupacion { get; set; }
        public string tutor { get; set; }
        public string observaciones { get; set; }
        public string nombreDelDoctorQueRefiere { get; set; }
        public int Estado { get; set; }

        /// <summary>
        /// Obtiene un solo paciente de la tabla pacientes
        /// </summary>
        /// <param name="identidad"></param>
        /// <returns></returns>
        public Paciente ObtenerPaciente(string identidad)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            Paciente resultado = new Paciente();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente] WHERE Identidad = @identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.Char, 13).Value = identidad;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    
                    resultado.tipo = rdr.GetString(0);
                    resultado.fechaCreacion = rdr.GetDateTime(1);
                    resultado.identidad = rdr.GetString(2);
                    resultado.nombre = rdr.GetString(3);
                    resultado.apellido = rdr.GetString(4);
                    resultado.edad = rdr.GetInt32(5);
                    resultado.direccion = rdr.GetString(6);
                    resultado.telefono = rdr.GetInt32(7);
                    resultado.ciudad = rdr.GetString(8);
                    resultado.fechaNacimiento = rdr.GetString(9);
                    resultado.ocupacion = rdr.GetString(10);
                    resultado.tutor = rdr.GetString(11);
                    resultado.observaciones = rdr.GetString(12);
                    resultado.nombreDelDoctorQueRefiere = rdr.GetString(13);
                    resultado.Estado = Convert.ToInt32(rdr.GetValue(14));

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
        /// Lista un paciente
        /// </summary>
        /// <returns></returns>
        public List<Paciente> ListarPaciente()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            List<Paciente> Lista = new List<Paciente>();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Paciente]";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Paciente resultado = new Paciente();
                    resultado.tipo = rdr.GetString(0);
                    resultado.fechaCreacion = rdr.GetDateTime(1);
                    resultado.identidad = rdr.GetString(2);
                    resultado.nombre = rdr.GetString(3);
                    resultado.apellido = rdr.GetString(4);
                    resultado.edad = rdr.GetInt32(5);
                    resultado.direccion = rdr.GetString(6);
                    resultado.telefono = rdr.GetInt32(7);
                    resultado.ciudad = rdr.GetString(8);
                    resultado.fechaNacimiento = rdr.GetString(9);
                    resultado.ocupacion = rdr.GetString(10);
                    resultado.tutor = rdr.GetString(11);
                    resultado.observaciones = rdr.GetString(12);
                    resultado.nombreDelDoctorQueRefiere = rdr.GetString(13);
                    resultado.Estado = Convert.ToInt32(rdr.GetValue(14));


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

        /// <summary>
        /// se encarga de guardar un nuevo Paciente en la base de datos, recibe 
        /// como parametros un objeto de tipo Paciente.
        /// </summary>
        /// <returns>true: si se insertó correctamente false: si ocurrió un error</returns>
        public bool InsertarPaciente(Paciente elPaciente)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaPaciente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@Identidad", SqlDbType.VarChar, 15));
            cmd.Parameters["@identidad"].Value = elPaciente.identidad;

            cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar, 10));
            cmd.Parameters["@Tipo"].Value = elPaciente.tipo;

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@Nombre"].Value = elPaciente.nombre;

            cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 100));
            cmd.Parameters["@Apellido"].Value = elPaciente.apellido;

            cmd.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
            cmd.Parameters["@Edad"].Value = elPaciente.edad;

            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar, 1000));
            cmd.Parameters["@Direccion"].Value = elPaciente.direccion;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Int));
            cmd.Parameters["@Telefono"].Value = elPaciente.telefono;

            cmd.Parameters.Add(new SqlParameter("@Ciudad", SqlDbType.Char, 9));
            cmd.Parameters["@Ciudad"].Value = elPaciente.ciudad;

            cmd.Parameters.Add(new SqlParameter("@FechaNacimineto", SqlDbType.VarChar, 20));
            cmd.Parameters["@FechaNacimineto"].Value = elPaciente.fechaNacimiento;

            cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Ocupacion"].Value = elPaciente.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@Tutor", SqlDbType.VarChar, 200));
            cmd.Parameters["@Tutor"].Value = elPaciente.tutor;

            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2000));
            cmd.Parameters["@Observaciones"].Value = elPaciente.observaciones;

            cmd.Parameters.Add(new SqlParameter("@NombreDelDoctorQueRefiere", SqlDbType.VarChar, 200));
            cmd.Parameters["@NombreDelDoctorQueRefiere"].Value = elPaciente.nombreDelDoctorQueRefiere;

            cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.Bit));
            cmd.Parameters["@Estado"].Value = elPaciente.Estado;


            // intentamos insertar al nuevo Paciente
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
        public static bool ActualizarPaciente(Paciente elPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_ActualizarPaciente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@Identidad", SqlDbType.VarChar, 15));
            cmd.Parameters["@identidad"].Value = elPaciente.identidad;

            cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar, 10));
            cmd.Parameters["@Tipo"].Value = elPaciente.tipo;

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@Nombre"].Value = elPaciente.nombre;

            cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 100));
            cmd.Parameters["@Apellido"].Value = elPaciente.apellido;

            cmd.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
            cmd.Parameters["@Edad"].Value = elPaciente.edad;

            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar, 1000));
            cmd.Parameters["@Direccion"].Value = elPaciente.direccion;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Int));
            cmd.Parameters["@Telefono"].Value = elPaciente.telefono;

            cmd.Parameters.Add(new SqlParameter("@Ciudad", SqlDbType.Char, 9));
            cmd.Parameters["@Ciudad"].Value = elPaciente.ciudad;

            cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.VarChar, 20));
            cmd.Parameters["@FechaNacimiento"].Value = elPaciente.fechaNacimiento;

            cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Ocupacion"].Value = elPaciente.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@Tutor", SqlDbType.VarChar, 200));
            cmd.Parameters["@Tutor"].Value = elPaciente.tutor;

            cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Ocupacion"].Value = elPaciente.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2000));
            cmd.Parameters["@Observaciones"].Value = elPaciente.observaciones;

            cmd.Parameters.Add(new SqlParameter("@NombreDelDoctorQueRefiere", SqlDbType.VarChar, 200));
            cmd.Parameters["@NombreDelDoctorQueRefiere"].Value = elPaciente.nombreDelDoctorQueRefiere;

            cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.Bit));
            cmd.Parameters["@Estado"].Value = elPaciente.Estado;


            // intentamos insertar al nuevo Paciente
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

        public bool DarDeBaja(Paciente elPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("UPDATE ControlPacientes.Paciente SET Estado = 0 WHERE Identidad = @identidad or Nombre = @nombre");
            

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.Char, 13));
            cmd.Parameters["@identidad"].Value = elPaciente.identidad;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombre"].Value = elPaciente.nombre;

            // intentamos insertar al nuevo Paciente
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
