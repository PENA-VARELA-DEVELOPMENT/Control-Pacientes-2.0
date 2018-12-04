using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{
    public class HistoriaMedica
    {
        public int PadeceEnfermedad { get; set; }
        public int TmMedico { get; set; }
        public string TomaMedicamentos { get; set; }
        public string IntervenidoQuirurgicamente { get; set; }
        public string HospitalizadoAlgunaVez { get; set; }
        public string Alergias { get; set; }
        public int EnfermedadCardiaca { get; set; }
        public int Diabetico { get; set; }
        public int TuberculosisPulmonar { get; set; }
        public int EnfermedadHepatica { get; set; }
        public int ProblemasSangrado { get; set; }
        public string Paciente_Identidad { get; set; }

        public bool InsertarHistoriaMedica(HistoriaMedica HMedica)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaHistoriaMedica");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@PadeceEnfermedad", SqlDbType.Bit));
            cmd.Parameters["@PadeceEnfermedad"].Value = HMedica.PadeceEnfermedad;

            cmd.Parameters.Add(new SqlParameter("@TmMedico", SqlDbType.Bit));
            cmd.Parameters["@TmMedico"].Value = HMedica.TmMedico;

            cmd.Parameters.Add(new SqlParameter("@TomaMedicamentos", SqlDbType.VarChar, 500));
            cmd.Parameters["@TomaMedicamentos"].Value = HMedica.TomaMedicamentos;

            cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 100));
            cmd.Parameters["@Apellido"].Value = HMedica.apellido;

            cmd.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
            cmd.Parameters["@Edad"].Value = HMedica.edad;

            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar, 1000));
            cmd.Parameters["@Direccion"].Value = HMedica.direccion;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Int));
            cmd.Parameters["@Telefono"].Value = HMedica.telefono;

            cmd.Parameters.Add(new SqlParameter("@Ciudad", SqlDbType.Char, 9));
            cmd.Parameters["@Ciudad"].Value = HMedica.ciudad;

            cmd.Parameters.Add(new SqlParameter("@FechaNacimineto", SqlDbType.VarChar, 20));
            cmd.Parameters["@FechaNacimineto"].Value = HMedica.fechaNacimiento;

            cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Ocupacion"].Value = HMedica.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@Tutor", SqlDbType.VarChar, 200));
            cmd.Parameters["@Tutor"].Value = HMedica.tutor;

            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2000));
            cmd.Parameters["@Observaciones"].Value = HMedica.observaciones;

            cmd.Parameters.Add(new SqlParameter("@NombreDelDoctorQueRefiere", SqlDbType.VarChar, 200));
            cmd.Parameters["@NombreDelDoctorQueRefiere"].Value = HMedica.nombreDelDoctorQueRefiere;

            cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.Bit));
            cmd.Parameters["@Estado"].Value = HMedica.Estado;


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
    }
}
