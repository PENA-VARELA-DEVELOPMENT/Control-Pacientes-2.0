﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Pacientes_Clinica_Machado.FormulariosPaciente
{
    public partial class InsertarImagenPaciente : Form
    {
        string identidad;
        public InsertarImagenPaciente(string x)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            identidad = x;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.FotosPaciente nueva = new Clases.FotosPaciente();
            nueva.Paciente_Identidad = identidad;
            nueva.nombre = nombreTxt.Text;
            nueva.comentario = observacionesTxt.Text;
            pictureBox1.Image.Save(nueva.Foto, GetPng());
            if (nueva.InsertarFoto(nueva))
            {
                MessageBox.Show("Exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Exito!");
            }

            
        }

        private static System.Drawing.Imaging.ImageFormat GetPng()
        {
            return System.Drawing.Imaging.ImageFormat.Png;
        }
    }
}
