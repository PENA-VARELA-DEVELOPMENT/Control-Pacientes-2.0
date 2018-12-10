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

namespace Control_Pacientes_Clinica_Machado
{
    public partial class Login : Form
    {
        Menu menu = new Menu();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuarios nuevo = new Usuarios();
            nuevo = nuevo.ObtenerUsuarios(nombreTbox.Text);

            if (nuevo.Contrasena == procesarSha256Hash(PasswTbox.Text))
            {
                MessageBox.Show("Bienvenido al Sistema", "Clínica Dental Machado", MessageBoxButtons.OK);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK);
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
    }
}
