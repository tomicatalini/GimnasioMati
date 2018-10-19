using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controladores;

namespace GymMati.VentanasNuevas.ProductoIU
{
    public partial class BuscarProductoUI : Form
    {
        public BuscarProductoUI()
        {
            InitializeComponent();
        }

        private void BuscarProductoUI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_DataLayer_DataBase_GymMatiContextDataSet1.ProdyTip' Puede moverla o quitarla según sea necesario.
            this.prodyTipTableAdapter.Fill(this._DataLayer_DataBase_GymMatiContextDataSet1.ProdyTip);
        }

        private void FiltarProductos(object sender, KeyEventArgs e)
        {
            var txt = (TextBox)sender;
            var VnaPpal = (BuscarProductoUI)txt.FindForm();
            string filtro = "[nombre] like '" + txt.Text + "%' or [marca] like '" + txt.Text + "%' or [tipoProducto] like '" + txt.Text + "%'";
            prodyTipBindingSource.Filter = filtro;
        }

        private void SeleccionCelda(object sender, DataGridViewCellEventArgs e)
        {

            var dataGrid = (DataGridView)sender;
            dataGrid.Rows[e.RowIndex].Selected = true;
        }

        private void SeleccionarProd(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Rows[e.RowIndex].Selected = true;

            var VnaPpal = (VerProductoYmasUI)dataGrid.FindForm().Owner;

            int codigo = (int)dataGrid.Rows[e.RowIndex].Cells[0].Value;
            VnaPpal.buscarProd(codigo);

            this.Close();
        }

        private void SeleccionarProd(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var VnaPpal = (BuscarProductoUI)btn.FindForm();
            var owner = (VerProductoYmasUI)VnaPpal.Owner;

            var row = VnaPpal.dgvListaProductos.SelectedRows[0];
            int codigo = (int)row.Cells[0].Value;
            owner.buscarProd(codigo);

            this.Close();
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
