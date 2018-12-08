﻿using System;
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
            Nuevo.edad = edadNmr.TabIndex;
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
            

        }
    }
}
