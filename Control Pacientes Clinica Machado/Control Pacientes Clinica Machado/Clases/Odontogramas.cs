using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    public class Odontogramas
    {
        public int Diente { get; set; }
        public string Observaciones { get; set; }
        public string Vestibular { get; set; }
        public string Distal { get; set; }
        public string Oclusal { get; set; }
        public string Mesial { get; set; }
        public string Lingual { get; set; }
        public string Paciente_Identidad { get; set; }

        public bool InsertarOdontogramas(Odontogramas elOdontograma)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlOdontogramass.sp_NuevaOdontogramas");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@Diente", SqlDbType.Int));
            cmd.Parameters["@Diente"].Value = elOdontograma.Diente;

            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 100));
            cmd.Parameters["@Observaciones"].Value = elOdontograma.Observaciones;

            cmd.Parameters.Add(new SqlParameter("@Vestibular", SqlDbType.VarChar, 15));
            cmd.Parameters["@Vestibular"].Value = elOdontograma.Vestibular;

            cmd.Parameters.Add(new SqlParameter("@Distal", SqlDbType.VarChar, 15));
            cmd.Parameters["@Distal"].Value = elOdontograma.Distal;

            cmd.Parameters.Add(new SqlParameter("@Oclusal", SqlDbType.VarChar, 15));
            cmd.Parameters["@Oclusal"].Value = elOdontograma.Oclusal;

            cmd.Parameters.Add(new SqlParameter("@Mesial", SqlDbType.VarChar, 15));
            cmd.Parameters["@Mesial"].Value = elOdontograma.Mesial;

            cmd.Parameters.Add(new SqlParameter("@Lingual", SqlDbType.VarChar, 15));
            cmd.Parameters["@Lingual"].Value = elOdontograma.Lingual;

            cmd.Parameters.Add(new SqlParameter("@Paciente_Identidad", SqlDbType.VarChar, 15));
            cmd.Parameters["@Paciente_Identidad"].Value = elOdontograma.Paciente_Identidad;

            // intentamos insertar al nuevo Odontogramas
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
