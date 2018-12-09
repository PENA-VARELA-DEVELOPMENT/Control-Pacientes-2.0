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
        public MemoryStream Foto  { get; set; }
        public string Paciente_Identidad { get; set; }

        public bool InsertarFoto(FotosPaciente laFoto)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaFotoPaciente");
            cmd.CommandType = CommandType.StoredProcedure;

                // Creando los parámetros necesarios

                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 80);  
                cmd.Parameters.Add("@comentario", System.Data.SqlDbType.VarChar, 2000); 
                cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);

                cmd.Parameters["@name"].Value = laFoto.nombre;
                cmd.Parameters["@comentario"].Value = laFoto.comentario;
                cmd.Parameters["@image"].Value = laFoto.Foto.GetBuffer();
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
