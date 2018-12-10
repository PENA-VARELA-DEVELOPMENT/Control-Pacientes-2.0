using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    public class Usuarios
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuarios ObtenerUsuarios(string nick)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            Usuarios resultado = new Usuarios();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[Usuarios] WHERE NombreUsuario = @nick";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nick", SqlDbType.Char, 15).Value = nick;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {

                    resultado.NombreUsuario = rdr.GetString(1);
                    resultado.Contrasena = rdr.GetString(2);

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

        public List<Usuarios> ObtenerUsuarios1()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            List<Usuarios> Lista = new List<Usuarios>();
            

            // Query SQL
            sql = @"SELECT NombreUsuario, Contraseña FROM [ControlPacientes].[Usuarios]";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Usuarios resultado = new Usuarios();
                    resultado.NombreUsuario = rdr.GetString(0);
                    resultado.Contrasena = rdr.GetString(1);
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
        public bool InsertarUsuario(Usuarios elUsuario)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("[ControlPacientes].[sp_NuevoUsuarios]");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.VarChar, 64));
            cmd.Parameters["@NombreUsuario"].Value = elUsuario.NombreUsuario;

            cmd.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar, 64));
            cmd.Parameters["@Contraseña"].Value = elUsuario.Contrasena;


            // intentamos insertar al nuevo Usuario
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
    }
}
