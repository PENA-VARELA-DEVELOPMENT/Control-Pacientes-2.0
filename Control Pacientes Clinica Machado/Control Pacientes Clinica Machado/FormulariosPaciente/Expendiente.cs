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
            vista.Show();
        }

        private void BtnVerImagenes_Click(object sender, EventArgs e)
        {
            FormulariosPaciente.VerFotos vista = new FormulariosPaciente.VerFotos(identidad);
            vista.Show();
        }

        private void Expendiente_Load(object sender, EventArgs e)
        {
            Paciente listar = new Paciente();
            listar = listar.ObtenerPaciente(identidad);
            identidadTxt.Text = listar.identidad;
            identidadTxt.Enabled = false;
            nombreTxt.Text = listar.nombre;
            nombreTxt.Enabled = false;
            apellidoTxt.Text = listar.apellido;
            apellidoTxt.Enabled = false;
            edadNmr.Value = listar.edad;
            edadNmr.Enabled = false;
            direccionTxt.Text = listar.direccion;
            direccionTxt.Enabled = false;
            telefonoTxt.Text = Convert.ToString(listar.telefono);
            telefonoTxt.Enabled = false;
            CiudadTxt.Text = listar.ciudad;
            CiudadTxt.Enabled = false;
            fechaNacimientoTxt.Text = listar.fechaNacimiento;
            fechaNacimientoTxt.Enabled = false;
            ocupacionTxt.Text = listar.ocupacion;
            ocupacionTxt.Enabled = false;
            tutorTxt.Text = listar.tutor;
            tutorTxt.Enabled = false;
            doctorRefTxt.Text = listar.nombreDelDoctorQueRefiere;
            doctorRefTxt.Enabled = false;
            TipoTxt.Text = listar.tipo;
            TipoTxt.Enabled = false;
            observacionesTxt.Text = listar.observaciones;
            observacionesTxt.Enabled = false;

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

       
    }
}
