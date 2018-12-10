using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado.FormulariosPaciente
{
    public partial class Expendiente : Form
    {
        string identidad;
       

        public Expendiente(string x)
        {
            InitializeComponent();
            identidad = x;
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            FormulariosPaciente.InsertarImagenPaciente vista = new FormulariosPaciente.InsertarImagenPaciente(identidad);
            vista.ShowDialog();
        }

        private void BtnVerImagenes_Click(object sender, EventArgs e)
        {
            FormulariosPaciente.VerFotos vista = new FormulariosPaciente.VerFotos(identidad);
            vista.ShowDialog();
        }

        private void Expendiente_Load(object sender, EventArgs e)
        {
            Paciente listar = new Paciente();
            listar = listar.ObtenerPaciente(identidad);
            identidadTxt.Text = listar.identidad;          
            nombreTxt.Text = listar.nombre;
            apellidoTxt.Text = listar.apellido;
            edadNmr.Value = listar.edad;
            direccionTxt.Text = listar.direccion;
            telefonoTxt.Text = Convert.ToString(listar.telefono);
            CiudadTxt.Text = listar.ciudad;
            fechaNacimientoTxt.Text = listar.fechaNacimiento;
            ocupacionTxt.Text = listar.ocupacion;
            tutorTxt.Text = listar.tutor;
            doctorRefTxt.Text = listar.nombreDelDoctorQueRefiere;
            TipoTxt.Text = listar.tipo;
            observacionesTxt.Text = listar.observaciones;

            HistoriaMedica ListarHMedica = new HistoriaMedica();
            ListarHMedica = ListarHMedica.ObtenerHistoriaMedica(identidad);
            if (ListarHMedica.padeceEnfermedad == 1)
            {
                checkBox14.Checked = true;
            }
            else if (ListarHMedica.padeceEnfermedad == 0)
            {
                checkBox13.Checked = true;
            }

            richTextBox1.Text = ListarHMedica.tmMedico;
            richTextBox2.Text = ListarHMedica.tomaMedicamentos;

            if (ListarHMedica.intervenidoQuirurgicamente == 1)
            {
                checkBox16.Checked = true;
            }
            else if (ListarHMedica.intervenidoQuirurgicamente == 0)
            {
                checkBox15.Checked = true;
            }

            if (ListarHMedica.hospitalizadoAlgunaVez == 1)
            {
                checkBox4.Checked = true;
            }
            else if (ListarHMedica.hospitalizadoAlgunaVez == 0)
            {
                checkBox3.Checked = true;
            }

            richTextBox3.Text = ListarHMedica.alergias;

            if (ListarHMedica.enfermedadCardiaca == 1)
            {
                checkBox12.Checked = true;
            }
            else if (ListarHMedica.enfermedadCardiaca == 0)
            {
                checkBox11.Checked = true;
            }

            if (ListarHMedica.diabetico == 1)
            {
                checkBox10.Checked = true;
            }
            else if (ListarHMedica.diabetico == 0)
            {
                checkBox9.Checked = true;
            }

            if (ListarHMedica.tuberculosisPulmonar == 1)
            {
                checkBox6.Checked = true;
            }
            else if (ListarHMedica.tuberculosisPulmonar == 0)
            {
                checkBox5.Checked = true;
            }

            if (ListarHMedica.enfermedadHepatica == 1)
            {
                checkBox8.Checked = true;
            }
            else if (ListarHMedica.enfermedadHepatica == 0)
            {
                checkBox7.Checked = true;
            }

            if (ListarHMedica.problemasSangrado == 1)
            {
                checkBox18.Checked = true;
            }
            else if (ListarHMedica.problemasSangrado == 0)
            {
                checkBox17.Checked = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
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

            if (Nuevo.ActualizarPaciente(Nuevo))
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
            if (checkBox16.Checked)
            {
                NuevaHMedica.intervenidoQuirurgicamente = 1;
            }
            else if (checkBox15.Checked)
            {
                NuevaHMedica.intervenidoQuirurgicamente = 0;
            }
            NuevaHMedica.tomaMedicamentos = richTextBox2.Text;
            if (checkBox4.Checked)
            {
                NuevaHMedica.hospitalizadoAlgunaVez = 1;
            }
            else if (checkBox3.Checked)
            {
                NuevaHMedica.hospitalizadoAlgunaVez = 0;
            }

            NuevaHMedica.alergias = richTextBox3.Text;

            if (checkBox12.Checked)
            {
                NuevaHMedica.enfermedadCardiaca = 1;
            }
            else if (checkBox11.Checked)
            {
                NuevaHMedica.enfermedadCardiaca = 0;
            }

            if (checkBox10.Checked)
            {
                NuevaHMedica.diabetico = 1;
            }
            else if (checkBox9.Checked)
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

            if (checkBox18.Checked)
            {
                NuevaHMedica.problemasSangrado = 1;
            }
            else if (checkBox17.Checked)
            {
                NuevaHMedica.problemasSangrado = 0;
            }

            NuevaHMedica.paciente_Identidad = identidadTxt.Text;

            if (NuevaHMedica.ActualizarHistoriaMedica(NuevaHMedica))
            {
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
