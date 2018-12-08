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
        public string fecha { get; set; }
        public string hora { get; set; }
        public string pacienteIdentidad { get; set; }
        public int idDoctor { get; set; }
        //public int Estado { get; set; }

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
                    WHERE idCita = @idCita";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita;

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
                sql = @"select  Id, Nombre, Artista, Album, Genero, AñoCreacion FROM Music.Cancion Order by Id";

                SqlCommand cmd = conexion.EjecutarComando(sql);
                SqlDataReader rdr;

                try
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Cita resultado = new Cita();
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
                catch (SqlException)
                {

                    return Lista;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

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
                return true;

            }
    }
}

