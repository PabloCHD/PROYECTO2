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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormLogin = new Login();
            FormLogin.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.ShowDialog();
        }

        private void crearNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevaReservacion = new NuevaReservacion();
            NuevaReservacion.MdiParent = this;
            NuevaReservacion.Show();
        }

        private void ultimasReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var UltimasReservaciones     = new UltimasReservaciones();
            UltimasReservaciones.MdiParent = this;
            UltimasReservaciones.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }
    }
}
