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
    public partial class Odontograma : Form
    {
        string ColorSeleccionado;
        Odontogramas Diente18 = new Odontogramas();
        Odontogramas Diente17 = new Odontogramas();
        Odontogramas Diente16 = new Odontogramas();
        Odontogramas Diente15 = new Odontogramas();
        Odontogramas Diente14 = new Odontogramas();
        Odontogramas Diente13 = new Odontogramas();
        Odontogramas Diente12 = new Odontogramas();
        Odontogramas Diente11 = new Odontogramas();
        Odontogramas Diente21 = new Odontogramas();
        Odontogramas Diente22 = new Odontogramas();
        Odontogramas Diente23 = new Odontogramas();
        Odontogramas Diente24 = new Odontogramas();
        Odontogramas Diente25 = new Odontogramas();
        Odontogramas Diente26 = new Odontogramas();
        Odontogramas Diente27 = new Odontogramas();
        Odontogramas Diente28 = new Odontogramas();
        Odontogramas Diente51 = new Odontogramas();
        Odontogramas Diente52 = new Odontogramas();
        Odontogramas Diente53 = new Odontogramas();
        Odontogramas Diente54 = new Odontogramas();
        Odontogramas Diente55 = new Odontogramas();
        Odontogramas Diente61 = new Odontogramas();
        Odontogramas Diente62 = new Odontogramas();
        Odontogramas Diente63 = new Odontogramas();
        Odontogramas Diente64 = new Odontogramas();
        Odontogramas Diente65 = new Odontogramas();
        Odontogramas Diente85 = new Odontogramas();
        Odontogramas Diente84 = new Odontogramas();
        Odontogramas Diente83 = new Odontogramas();
        Odontogramas Diente82 = new Odontogramas();
        Odontogramas Diente81 = new Odontogramas();
        Odontogramas Diente71 = new Odontogramas();
        Odontogramas Diente72 = new Odontogramas();
        Odontogramas Diente73 = new Odontogramas();
        Odontogramas Diente74 = new Odontogramas();
        Odontogramas Diente75 = new Odontogramas();
        Odontogramas Diente41 = new Odontogramas();
        Odontogramas Diente42 = new Odontogramas();
        Odontogramas Diente43 = new Odontogramas();
        Odontogramas Diente44 = new Odontogramas();
        Odontogramas Diente45 = new Odontogramas();
        Odontogramas Diente46 = new Odontogramas();
        Odontogramas Diente47 = new Odontogramas();
        Odontogramas Diente48 = new Odontogramas();
        Odontogramas Diente31 = new Odontogramas();
        Odontogramas Diente32 = new Odontogramas();
        Odontogramas Diente33 = new Odontogramas();
        Odontogramas Diente34 = new Odontogramas();
        Odontogramas Diente35 = new Odontogramas();
        Odontogramas Diente36 = new Odontogramas();
        Odontogramas Diente37 = new Odontogramas();
        Odontogramas Diente38 = new Odontogramas();

        public Odontograma()
        {
            InitializeComponent();          
        }

        private void btnDiente28_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente28_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente28_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente28_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente28_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente28_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente28_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente28_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente28_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente28_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente27_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente27_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente27_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente27_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente27_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente27_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente27_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente27_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente27_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente27_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente26_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente26_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente26_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente26_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente26_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente26_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente26_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente26_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente26_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente26_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente25_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente25_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente25_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente25_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente25_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente25_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente25_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente25_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente25_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente25_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente24_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente24_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente24_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente24_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente24_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente24_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente24_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente24_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente24_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente24_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente23_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente23_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente23_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente23_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente23_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente23_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente23_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente23_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente23_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente23_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente22_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente22_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente22_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente22_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente22_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente22_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente22_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente22_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente22_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente22_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente21_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente21_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente21_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente21_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente21_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente21_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente21_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente21_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente21_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente21_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente11_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente11_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente11_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente11_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente11_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente11_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente11_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente11_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente11_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente11_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente12_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente12_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente12_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente12_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente12_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente12_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente12_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente12_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente12_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente12_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente13_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente13_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente13_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente13_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente13_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente13_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente13_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente13_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente13_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente13_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente14_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente14_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente14_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente14_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente14_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente14_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente14_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente14_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente14_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente14_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente15_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente15_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente15_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente15_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente15_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente15_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente15_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente15_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente15_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente15_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente16_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente16_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente16_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente16_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente16_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente16_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente16_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente16_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente16_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente16_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente17_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente17_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente17_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente17_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente17_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente17_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente17_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente17_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente17_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente17_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente18_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente18_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente18_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente18_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente18_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente18_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente18_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente18_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente18_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente18_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente65_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente65_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente65_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente65_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente65_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente65_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente65_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente65_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente65_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente65_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente64_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente64_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente64_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente64_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente64_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente64_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente64_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente64_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente64_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente64_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente63_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente63_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente63_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente63_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente63_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente63_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente63_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente63_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente63_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente63_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente62_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente62_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente62_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente62_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente62_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente62_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente62_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente62_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente62_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente62_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente61_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente61_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente61_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente61_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente61_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente61_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente61_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente61_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente61_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente61_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente51_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente51_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente51_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente51_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente51_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente51_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente51_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente51_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente51_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente51_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente52_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente52_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente52_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente52_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente52_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente52_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente52_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente52_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente52_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente52_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente53_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente53_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente53_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente53_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente53_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente53_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente53_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente53_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente53_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente53_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente54_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente54_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente54_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente54_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente54_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente54_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente54_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente54_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente54_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente54_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente55_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente55_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente55_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente55_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente55_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente55_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente55_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente55_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente55_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente55_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente75_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente75_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente75_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente75_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente75_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente75_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente75_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente75_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente75_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente75_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente74_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente74_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente74_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente74_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente74_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente74_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente74_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente74_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente74_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente74_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente73_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente73_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente73_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente73_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente73_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente73_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente73_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente73_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente73_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente73_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente72_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente72_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente72_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente72_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente72_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente72_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente72_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente72_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente72_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente72_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente71_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente71_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente71_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente71_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente71_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente71_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente71_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente71_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente71_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente71_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente81_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente81_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente81_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente81_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente81_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente81_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente81_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente81_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente81_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente81_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente82_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente82_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente82_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente82_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente82_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente82_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente82_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente82_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente82_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente82_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente83_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente83_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente83_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente83_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente83_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente83_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente83_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente83_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente83_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente83_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente84_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente84_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente84_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente84_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente84_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente84_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente84_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente84_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente84_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente84_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente85_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente85_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente85_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente85_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente85_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente85_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente85_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente85_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente85_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente85_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void Odontograma_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDiente38_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente38_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente38_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente38_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente38_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente38_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente38_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente38_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente38_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente38_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente37_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente37_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente37_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente37_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente37_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente37_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente37_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente37_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente37_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente37_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente36_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente36_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente36_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente36_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente36_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente36_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente36_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente36_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente36_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente36_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente35_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente35_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente35_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente35_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente35_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente35_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente35_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente35_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente35_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente35_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente34_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente34_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente34_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente34_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente34_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente34_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente34_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente34_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente34_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente34_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente33_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente33_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente33_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente33_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente33_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente33_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente33_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente33_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente33_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente33_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente32_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente32_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente32_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente32_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente32_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente32_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente32_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente32_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente32_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente32_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente31_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente31_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente31_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente31_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente31_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente31_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente31_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente31_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente31_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente31_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente41_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente41_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente41_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente41_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente41_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente41_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente41_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente41_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente41_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente41_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente42_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente42_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente42_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente42_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente42_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente42_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente42_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente42_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente42_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente42_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente43_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente43_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente43_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente43_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente43_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente43_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente43_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente43_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente43_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente43_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente44_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente44_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente44_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente44_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente44_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente44_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente44_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente44_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente44_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente44_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente45_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente45_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente45_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente45_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente45_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente45_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente45_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente45_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente45_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente45_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente46_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente46_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente46_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente46_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente46_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente46_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente46_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente46_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente46_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente46_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente47_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente47_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente47_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente47_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente47_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente47_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente47_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente47_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente47_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente47_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente48_4_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente48_4.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente48_3_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente48_3.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente48_2_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente48_2.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente48_1_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente48_1.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnDiente48_5_Click(object sender, EventArgs e)
        {
            // Al hacer click en el boton cambia al color seleccionado por el usuario
            this.btnDiente48_5.BackColor = ColorTranslator.FromHtml(ColorSeleccionado);
        }

        private void btnCaries_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#17202A";
        }

        private void btnObturado_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#C0392B";
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#1F618D";
        }

        private void btnDiente38_Ausente_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#196F3D";
        }

        private void btnFractura_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#00FFFF";
        }

        private void btnProtesis_Click(object sender, EventArgs e)
        {
            ColorSeleccionado = "#660066";
        }
    }
}
