using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Control_Pacientes_Clinica_Machado.Clases;

namespace Control_Pacientes_Clinica_Machado.FormulariosMantenimiento
{
    public partial class MantenimientoUsuarios : Form
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios nuevo = new Usuarios();
            // se obtiene el id del combobox cmbEmpleado.Text;
            nuevo.NombreUsuario = nombreUsuarioTxt.Text;
            if (contraseñaTxt.Text == textBox1.Text)
            {
                nuevo.Contrasena = procesarSha256Hash(contraseñaTxt.Text);
            }
            if (nuevo.InsertarUsuario(nuevo))
            {
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        static string procesarSha256Hash(string laCadena)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(laCadena));

                // Convert byte array to a string   
                StringBuilder constructor = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    constructor.Append(bytes[i].ToString("x2"));
                }
                return constructor.ToString();
            }
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            Usuarios nuevo = new Usuarios();
            suariosDataGridView.DataSource = nuevo.ObtenerUsuarios1();
        }
    }
}
