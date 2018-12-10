using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Pacientes_Clinica_Machado.Clases;
using System.Data;
using System.Data.SqlClient;

namespace Control_Pacientes_Clinica_Machado.Reportes
{
    public class ReporteCita
    {
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public string Doctor { get; set; }
        public string Motivo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

        public List<ReporteCita> ListarReporteCita()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ClinicaMachado");
            string sql;
            List<ReporteCita> Lista = new List<ReporteCita>();

            // Query SQL
            sql = @"SELECT ControlPacientes.Paciente.Nombre, ControlPacientes.Paciente.Apellido, ControlPacientes.Doctores.Nombre AS Doctor, ControlPacientes.Doctores.Especialidad, 
                    ControlPacientes.Citas.Fecha, ControlPacientes.Citas.Hora FROM ControlPacientes.Citas INNER JOIN ControlPacientes.Doctores ON ControlPacientes.Citas.Doctores_IdDoctor = 
                    ControlPacientes.Doctores.IdDoctor INNER JOIN ControlPacientes.Paciente ON ControlPacientes.Citas.paciente_Identidad = ControlPacientes.Paciente.Identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ReporteCita resultado = new ReporteCita();
                    resultado.NombrePaciente = rdr.GetString(0);
                    resultado.ApellidoPaciente = rdr.GetString(1);
                    resultado.Doctor = rdr.GetString(2);
                    resultado.Motivo = rdr.GetString(3);
                    resultado.Fecha = Convert.ToString(rdr.GetDateTime(4));
                    resultado.Hora = rdr.GetString(5);




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
    }
}
