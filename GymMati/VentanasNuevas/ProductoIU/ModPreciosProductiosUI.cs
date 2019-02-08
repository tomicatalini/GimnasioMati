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
    public partial class ModPreciosProductosUI : Form
    {
        public ModPreciosProductosUI()
        {
            InitializeComponent();
        }

        private void ModPreciosProductosUI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_DataLayer_DataBase_GymMatiContextDataSet3.ProdyTip' Puede moverla o quitarla según sea necesario.
            this.prodyTipTableAdapter.Fill(this._DataLayer_DataBase_GymMatiContextDataSet3.ProdyTip);

            foreach (DataGridViewColumn columna in this.listaProductos.Columns)
            {
                if (columna.Name != "precioDataGridViewTextBoxColumn")
                    columna.ReadOnly = true;
            }

            this.lblPrueba.Text = "si";

        }

        private void SeleccionarProd(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            var VnaPpal = (ModPreciosProductosUI)dataGrid.FindForm();

            var row = dataGrid.Rows[e.RowIndex];
            row.Selected = true;
            VnaPpal.txtDescripcion.Text = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();

        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar(object sender, EventArgs e)
        {

            var adminProd = new ControladorProducto();
            adminProd.GuardarCambios();

            this.Close();
        }

        private void ListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                senderGrid.CurrentCell = senderGrid.CurrentRow.Cells["precioDataGridViewTextBoxColumn"];
                senderGrid.BeginEdit(true);
            }           

        }

        private void ListaProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (lblPrueba.Text == "si")
            {
                var senderGrid = (DataGridView)sender;
                var adminProd = new ControladorProducto();
                var row = senderGrid.Rows[e.RowIndex];

                adminProd.ModificarPrecioProducto((int)row.Cells["codProductoDataGridViewTextBoxColumn"].Value, (float)row.Cells["precioDataGridViewTextBoxColumn"].Value);

                senderGrid.EndEdit();
                senderGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
