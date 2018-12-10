using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado
{
    public partial class NuevoPaciente : Form
    {
        public NuevoPaciente()
        {
            InitializeComponent();
        }

        private void AbrirFormHija(object FormHija)
        {
            if (this.panelContenedorOdontograma.Controls.Count > 0)
            {
                this.panelContenedorOdontograma.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorOdontograma.Controls.Add(fh);
            this.panelContenedorOdontograma.Tag = fh;
            fh.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string message = "¿Esta seguro que desea cancelar el proceso?";
            string caption = "Control de Pacientes Clinica Machado";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;

            DialogResult result;
            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paciente Nuevo = new Paciente();
            Nuevo.identidad = identidadTxt.Text;
            Nuevo.nombre = nombreTxt.Text;
            Nuevo.apellido = apellidoTxt.Text;
            Nuevo.edad = Convert.ToInt32(edadNmr.Value);
            Nuevo.direccion = direccionTxt.Text;
            Nuevo.telefono = Convert.ToInt32(telefonoTxt.Text);
            Nuevo.ciudad = CiudadTxt.Text;
            Nuevo.fechaNacimiento = fechaNacimientoTxt.Text;
            Nuevo.ocupacion = ocupacionTxt.Text;
            Nuevo.tutor = tutorTxt.Text;
            Nuevo.nombreDelDoctorQueRefiere = doctorRefTxt.Text;
            Nuevo.observaciones = observacionesTxt.Text;
            Nuevo.Estado = 1;
            Nuevo.tipo = TipoTxt.Text;

            if (Nuevo.InsertarPaciente(Nuevo))
            {
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Error");
            }

            HistoriaMedica NuevaHMedica = new HistoriaMedica();

            if (checkBox14.Checked)
            {
                NuevaHMedica.padeceEnfermedad = 1;
            }
            else if (checkBox13.Checked)
            {
                NuevaHMedica.padeceEnfermedad = 0;
            }
            NuevaHMedica.tmMedico = richTextBox1.Text;
            NuevaHMedica.tomaMedicamentos = richTextBox2.Text;
            if (checkBox16.Checked)
            {
                NuevaHMedica.intervenidoQuirurgicamente = 1;
            }
            else if (checkBox15.Checked)
            {
                NuevaHMedica.intervenidoQuirurgicamente = 0;
            }

            if (checkBox18.Checked)
            {
                NuevaHMedica.hospitalizadoAlgunaVez = 1;
            }
            else if (checkBox17.Checked)
            {
                NuevaHMedica.hospitalizadoAlgunaVez = 0;
            }

            NuevaHMedica.alergias = richTextBox3.Text;

            if (checkBox20.Checked)
            {
                NuevaHMedica.enfermedadCardiaca = 1;
            }
            else if (checkBox19.Checked)
            {
                NuevaHMedica.enfermedadCardiaca = 0;
            }

            if (checkBox4.Checked)
            {
                NuevaHMedica.diabetico = 1;
            }
            else if (checkBox3.Checked)
            {
                NuevaHMedica.diabetico = 0;
            }

            if (checkBox6.Checked)
            {
                NuevaHMedica.tuberculosisPulmonar = 1;
            }
            else if (checkBox5.Checked)
            {
                NuevaHMedica.tuberculosisPulmonar = 0;
            }
            if (checkBox8.Checked)
            {
                NuevaHMedica.enfermedadHepatica = 1;
            }
            else if (checkBox7.Checked)
            {
                NuevaHMedica.enfermedadHepatica = 0;
            }

            if (checkBox10.Checked)
            {
                NuevaHMedica.problemasSangrado = 1;
            }
            else if (checkBox9.Checked)
            {
                NuevaHMedica.problemasSangrado = 0;
            }

            NuevaHMedica.paciente_Identidad = identidadTxt.Text;

            NuevaHMedica.InsertarHistoriaMedica(NuevaHMedica);



        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new Odontograma());
        }
    }
}
