using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    public class FotosPaciente
    {
        public string nombre { get; set; }
        public string comentario { get; set; }
        public MemoryStream Foto = new MemoryStream();
        public string Paciente_Identidad { get; set; }

        public bool InsertarFoto(FotosPaciente laFoto)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaFotoPaciente");
            cmd.CommandType = CommandType.StoredProcedure;

                // Creando los parámetros necesarios

                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 80);  
                cmd.Parameters.Add("@comentario", System.Data.SqlDbType.VarChar, 2000); 
                cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@Paciente_Identidad", System.Data.SqlDbType.VarChar, 15);

                cmd.Parameters["@nombre"].Value = laFoto.nombre;
                cmd.Parameters["@comentario"].Value = laFoto.comentario;
                cmd.Parameters["@Foto"].Value = laFoto.Foto.GetBuffer();
                cmd.Parameters["@Paciente_Identidad"].Value = laFoto.Paciente_Identidad;
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

        public FotosPaciente ListarFotosPaciente(string nombre)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            FotosPaciente resultado = new FotosPaciente();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[FotoPaciente] 
                            WHERE  ([nombre] = @nombre) ";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = nombre;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {

                    resultado.nombre = rdr.GetString(1);
                    resultado.comentario = rdr.GetString(2);                   
                    resultado.Foto = (MemoryStream)rdr.GetStream(3);


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
    }
}
