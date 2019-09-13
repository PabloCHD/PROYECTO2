using ReservacionesBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Login : Form
    {
        SeguridadBL _seguridad;//Variable Global

        public Login()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string pass;

            Usuario = textBox1.Text;
            pass    = textBox2.Text;

            var resultado = _seguridad.Autorizar(Usuario, pass);

            if (resultado == true )
            {
                this.Close();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
