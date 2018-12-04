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
        public string fechaCreacion { get; set; }
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
        public static Paciente ObtenerPaciente(string identidad)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            Paciente resultado = new Paciente();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.Paciente
                    WHERE identidad = @identidad";

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
                    //resultado.id = rdr.GetInt32(0);
                    //resultado.nombres = rdr.GetString(1);
                    //resultado.apellidos = rdr.GetString(2);
                    //resultado.identidad = rdr.GetString(3);
                    //resultado.direccion = rdr.GetString(4);
                    //resultado.telefono = rdr.GetString(5);
                    //resultado.celular = rdr.GetString(6);

                    // Remover espacios en blanco

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

        public static Paciente ObtenerPacienteNombre(string Nombre)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            Paciente resultado = new Paciente();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.Paciente
                    WHERE nombres = @Nombre";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.Char, 13).Value = Nombre;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    //resultado.id = rdr.GetInt32(0);
                    //resultado.nombres = rdr.GetString(1);
                    //resultado.apellidos = rdr.GetString(2);
                    //resultado.identidad = rdr.GetString(3);
                    //resultado.direccion = rdr.GetString(4);
                    //resultado.telefono = rdr.GetString(5);
                    //resultado.celular = rdr.GetString(6);

                    // Remover espacios en blanco

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



        public List<Paciente> ListarCancion()
        {
            Conexion conexion = new Conexion();
            string sql;
            List<Paciente> Lista = new List<Paciente>();

            // Query SQL
            sql = @"select  Id, Nombre, Artista, Album, Genero, AñoCreacion FROM Music.Cancion Order by Id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Paciente resultado = new Paciente();
                    //resultado.Id = rdr.GetInt32(0);
                    //resultado.Nombre = rdr.GetString(1);
                    //resultado.Artista = rdr.GetInt32(2);
                    //resultado.Album = rdr.GetInt32(3);
                    //resultado.Genero = rdr.GetString(4);
                    //resultado.AñoCreacion = rdr.GetString(5);
                    //Lista.Add(resultado);
                    // Remover espacios
                }

                return Lista;
            }
            catch (SqlException ex)
            {
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
            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarPaciente");
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
         
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }

        }

        public static bool EliminarPaciente(Paciente elPaciente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_EliminarPaciente");
            cmd.CommandType = CommandType.StoredProcedure;

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

                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
