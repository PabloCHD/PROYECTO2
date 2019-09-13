using ReservacionesBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class NuevaReservacion : Form
    {
        ReservacionBL _reservaciones;

        public NuevaReservacion()
        {
            InitializeComponent();

            _reservaciones = new ReservacionBL();
            listadeReservacionesBindingSource.DataSource = _reservaciones.ObtenerReservaciones();
        }

        private void listadeReservacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeReservacionesBindingSource.EndEdit();
            var reservacion = (Reservacion)listadeReservacionesBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                reservacion.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                reservacion.Foto = null;
            }
            var resultado = _reservaciones.GuardarReservacion(reservacion);

            if (resultado.Exitoso == true)
            {
                listadeReservacionesBindingSource.ResetBindings(false);
                DeshabilitarYHabilitarBotones(true);
                MessageBox.Show(" Guardado con exito");
            }

            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reservaciones.AgregarReservacion();
            listadeReservacionesBindingSource.MoveLast();

            DeshabilitarYHabilitarBotones(false);
        }

        private void DeshabilitarYHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCancelar.Visible = ! valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _reservaciones.EliminarReservacion(id);

            if (resultado == true)
            {
                listadeReservacionesBindingSource.ResetBindings(false);
            }
            
            else
            {
                MessageBox.Show("Error al eliminar la reservacion");
            }
            
        }

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarYHabilitarBotones(true);
            Eliminar(0);
        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reservacion = (Reservacion)listadeReservacionesBindingSource.Current;

            if (reservacion != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var FileInfo = new FileInfo(archivo);
                    var fileStream = FileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
                else
                {
                    MessageBox.Show("Agregue un nuevo registro antes de agregar una imagen");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TipoHabitacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listadeReservacionesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
