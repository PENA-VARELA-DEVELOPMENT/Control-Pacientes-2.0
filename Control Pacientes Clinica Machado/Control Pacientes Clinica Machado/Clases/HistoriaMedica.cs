using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Clases
{

    // Esta clase forma parte de Pacietes
    // Es parte del expediente de los pacientes
    public class HistoriaMedica
    {
        // Propiedades de la clase
        public int IdHistoria { get; set; }
        public int padeceEnfermedad { get; set; }
        public string tmMedico { get; set; } // Tratamiento médico
        public string tomaMedicamentos { get; set; }
        public int intervenidoQuirurgicamente { get; set; }
        public int hospitalizadoAlgunaVez { get; set; }
        public string alergias { get; set; }
        public int enfermedadCardiaca { get; set; }
        public int diabetico { get; set; }
        public int tuberculosisPulmonar { get; set; }
        public int enfermedadHepatica { get; set; }
        public int problemasSangrado { get; set; }
        public string paciente_Identidad { get; set; }

        /// <summary>
        /// Obtiene la historia médica de un paciente
        /// </summary>
        /// <param name="paciente_Identidad"></param>
        /// <returns></returns>
        public HistoriaMedica ObtenerHistoriaMedica(string paciente_Identidad)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            HistoriaMedica resultado = new HistoriaMedica();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[HistoriaMedica] WHERE paciente_Identidad = @Paciente_identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@Paciente_Identidad", SqlDbType.Char, 15).Value = paciente_Identidad;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.IdHistoria = rdr.GetInt32(0);
                    resultado.padeceEnfermedad = rdr.GetInt32(1);
                    resultado.tmMedico = rdr.GetString(2);
                    resultado.tomaMedicamentos = rdr.GetString(3);
                    resultado.intervenidoQuirurgicamente = rdr.GetInt32(4);
                    resultado.hospitalizadoAlgunaVez = rdr.GetInt32(5);
                    resultado.alergias = rdr.GetString(6);
                    resultado.enfermedadCardiaca = rdr.GetInt32(7);
                    resultado.diabetico = rdr.GetInt32(8);
                    resultado.tuberculosisPulmonar = rdr.GetInt32(9);
                    resultado.enfermedadHepatica = rdr.GetInt32(10);
                    resultado.problemasSangrado = rdr.GetInt32(11);
                    resultado.paciente_Identidad = rdr.GetString(12);
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
        /// Lista la historia médica de un paciente
        /// </summary>
        /// <returns></returns>
        public List<HistoriaMedica> ListarHMedica()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            List<HistoriaMedica> Lista = new List<HistoriaMedica>();

            // Query SQL
            sql = @"SELECT * FROM [ControlPacientes].[HistoriaMedica]";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    HistoriaMedica resultado = new HistoriaMedica();

                    resultado.IdHistoria = rdr.GetInt32(0);
                    resultado.padeceEnfermedad = rdr.GetInt32(1);
                    resultado.tmMedico = rdr.GetString(2);
                    resultado.tomaMedicamentos = rdr.GetString(3);
                    resultado.intervenidoQuirurgicamente = rdr.GetInt32(4);
                    resultado.hospitalizadoAlgunaVez = rdr.GetInt32(5);
                    resultado.alergias = rdr.GetString(6);
                    resultado.enfermedadCardiaca = rdr.GetInt32(7);
                    resultado.diabetico = rdr.GetInt32(8);
                    resultado.tuberculosisPulmonar = rdr.GetInt32(9);
                    resultado.enfermedadHepatica = rdr.GetInt32(10);
                    resultado.problemasSangrado = rdr.GetInt32(11);
                    resultado.paciente_Identidad = rdr.GetString(12);

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
        /// Actualiza la historia médica de un Paciente en particular
        /// </summary>
        /// <param name="HMedica"></param>
        /// <returns></returns>
        public static bool ActualizarHistoriaMedica(HistoriaMedica HMedica)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_ActualizarHistoriaMedica");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@PadeceEnfermedad", SqlDbType.Bit));
            cmd.Parameters["@PadeceEnfermedad"].Value = HMedica.padeceEnfermedad;

            cmd.Parameters.Add(new SqlParameter("@TmMedico", SqlDbType.VarChar, 500));
            cmd.Parameters["@TmMedico"].Value = HMedica.tmMedico;

            cmd.Parameters.Add(new SqlParameter("@TomaMedicamentos", SqlDbType.VarChar, 500));
            cmd.Parameters["@TomaMedicamentos"].Value = HMedica.tomaMedicamentos;

            cmd.Parameters.Add(new SqlParameter("@IntervenidoQuirurgicamente", SqlDbType.Bit));
            cmd.Parameters["@IntervenidoQuirurgicamente"].Value = HMedica.intervenidoQuirurgicamente;

            cmd.Parameters.Add(new SqlParameter("@HospitalizadoAlgunaVez", SqlDbType.Bit));
            cmd.Parameters["@HospitalizadoAlgunaVez"].Value = HMedica.hospitalizadoAlgunaVez;

            cmd.Parameters.Add(new SqlParameter("@Alergias", SqlDbType.VarChar, 500));
            cmd.Parameters["@Alergias"].Value = HMedica.alergias;

            cmd.Parameters.Add(new SqlParameter("@EnfermedadCardiaca", SqlDbType.Bit));
            cmd.Parameters["@EnfermedadCardiaca"].Value = HMedica.enfermedadCardiaca;

            cmd.Parameters.Add(new SqlParameter("@Diabetico", SqlDbType.Bit));
            cmd.Parameters["@Diabetico"].Value = HMedica.diabetico;

            cmd.Parameters.Add(new SqlParameter("@TuberculosisPulmonar", SqlDbType.Bit));
            cmd.Parameters["@TuberculosisPulmonar"].Value = HMedica.tuberculosisPulmonar;

            cmd.Parameters.Add(new SqlParameter("@EnfermedadHepatica", SqlDbType.Bit));
            cmd.Parameters["@EnfermedadHepatica"].Value = HMedica.enfermedadHepatica;

            cmd.Parameters.Add(new SqlParameter("@ProblemasSangrado", SqlDbType.Bit));
            cmd.Parameters["@ProblemasSangrado"].Value = HMedica.problemasSangrado;

            //cmd.Parameters.Add(new SqlParameter("@Paciente_Identidad", SqlDbType.Bit));
            //cmd.Parameters["@Paciente_Identidad"].Value = HMedica.paciente_Identidad;

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

        public bool InsertarHistoriaMedica(HistoriaMedica HMedica)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("ControlPacientes.sp_NuevaHistoriaMedica");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@PadeceEnfermedad", SqlDbType.Bit));
            cmd.Parameters["@PadeceEnfermedad"].Value = HMedica.padeceEnfermedad;

            cmd.Parameters.Add(new SqlParameter("@TmMedico", SqlDbType.VarChar, 500));
            cmd.Parameters["@TmMedico"].Value = HMedica.tmMedico;

            cmd.Parameters.Add(new SqlParameter("@TomaMedicamentos", SqlDbType.VarChar, 500));
            cmd.Parameters["@TomaMedicamentos"].Value = HMedica.tomaMedicamentos;

            cmd.Parameters.Add(new SqlParameter("@IntervenidoQuirurgicamente", SqlDbType.Bit));
            cmd.Parameters["@IntervenidoQuirurgicamente"].Value = HMedica.intervenidoQuirurgicamente;

            cmd.Parameters.Add(new SqlParameter("@HospitalizadoAlgunaVez", SqlDbType.Bit));
            cmd.Parameters["@HospitalizadoAlgunaVez"].Value = HMedica.hospitalizadoAlgunaVez;

            cmd.Parameters.Add(new SqlParameter("@Alergias", SqlDbType.VarChar, 500));
            cmd.Parameters["@Alergias"].Value = HMedica.alergias;

            cmd.Parameters.Add(new SqlParameter("@EnfermedadCardiaca", SqlDbType.Bit));
            cmd.Parameters["@EnfermedadCardiaca"].Value = HMedica.enfermedadCardiaca;

            cmd.Parameters.Add(new SqlParameter("@Diabetico", SqlDbType.Bit));
            cmd.Parameters["@Diabetico"].Value = HMedica.diabetico;

            cmd.Parameters.Add(new SqlParameter("@TuberculosisPulmonar", SqlDbType.Bit));
            cmd.Parameters["@TuberculosisPulmonar"].Value = HMedica.tuberculosisPulmonar;

            cmd.Parameters.Add(new SqlParameter("@EnfermedadHepatica", SqlDbType.Bit));
            cmd.Parameters["@EnfermedadHepatica"].Value = HMedica.enfermedadHepatica;

            cmd.Parameters.Add(new SqlParameter("@ProblemasSangrado", SqlDbType.Bit));
            cmd.Parameters["@ProblemasSangrado"].Value = HMedica.problemasSangrado;

            //cmd.Parameters.Add(new SqlParameter("@Paciente_Identidad", SqlDbType.Bit));
            //cmd.Parameters["@Paciente_Identidad"].Value = HMedica.paciente_Identidad;

            // intentamos insertar la nueva historia médica
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
