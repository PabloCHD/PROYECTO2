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
    public partial class FormFactura : Form
    {
        FacturaBL _facturaBL;
        ReservacionBL _reservacionesBL;
        Tipos _tiposBL;



        public FormFactura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _reservacionesBL = new ReservacionBL();
            listadeReservacionesBindingSource.DataSource = _reservacionesBL.ObtenerReservaciones();

            _tiposBL = new Tipos();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reservacionIdTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();
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

            toolStripButtonCancelar.Visible = !valor;

        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();
            var factura = (Factura)listaFacturasBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarYHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarYHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);
            DeshabilitarYHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;
            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);
            DeshabilitarYHabilitarBotones(false);
        }

        private void listaFacturasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }



        private void facturaDetalleDataGridView_DataError_3(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit_3(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.CalcularFactura(factura);
            listaFacturasBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text!="")
            {
                var resultado = MessageBox.Show("Desea anular factura?", "Anular", MessageBoxButtons.YesNo);
                       if (resultado==DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);

                }
            }

        }
        private void Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);
            if (resultado==true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular");
            }
        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            if (factura!=null && factura.Id!=0&& factura.Activo==false)
            {
                label1.Visible = true;

            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}

       


        
       

