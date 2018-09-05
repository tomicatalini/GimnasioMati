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
    public partial class VerProductoYmasUI : Form
    {
        public VerProductoYmasUI()
        {
            InitializeComponent();
        }

        private void BuscarProducto(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var VnaPpal = (VerProductoYmasUI)btn.FindForm();
            var VnaBuscar = new BuscarProductoUI();

            VnaBuscar.Show(this);
            
        }        

        public void buscarProd(int codProducto)
        {
            var adminProd = new ControladorProducto();

            var unProd = adminProd.GetProducto(codProducto);
            string filtro = string.Format("[tipoId] = {0}", unProd.TipoProductoId);

            this.lblCodigo.Text = unProd.CodProducto.ToString();
            this.txtNombre.Text = unProd.Nombre;
            this.txtMarca.Text = unProd.Marca;
            this.txtContenido.Text = unProd.Contenido.ToString();
            this.txtPrecio.Text = unProd.Precio.ToString();
            this.rTxtDescripcion.Text = unProd.Descripcion;
            tipoProductoBindingSource.Filter = filtro;


        }

        private void VerProductoYmasUI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_DataLayer_DataBase_GymMatiContextDataSet2.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this._DataLayer_DataBase_GymMatiContextDataSet2.TipoProducto);

        }

        private void ModificarProducto(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var VnaPpal = (VerProductoYmasUI)btn.FindForm();

            if (VnaPpal.lblCodigo.Text == "XX")
            {
                var VnaBuscar = new BuscarProductoUI();
                VnaBuscar.ShowDialog(this);
            }
            else
            {
                foreach (Control item in VnaPpal.Controls)
                {
                    if (item is TextBox || item is ComboBox || item is RichTextBox)
                        item.Enabled = true;
                }
            }

        }

        private void Aceptar(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var VnaPpal = (VerProductoYmasUI)btn.FindForm();

            if (VnaPpal.txtNombre.Enabled == true)            {
                
                var adminProd = new ControladorProducto();

                string nombre = txtNombre.Text.Trim();
                string marca = txtMarca.Text.Trim();
                float contenido = float.Parse(txtContenido.Text.Trim());
                float precio = float.Parse(txtPrecio.Text.Trim());
                string tipoProd = cbxTipo.Text;
                string descripcion = rTxtDescripcion.Text.Trim();

                adminProd.ModificarProducto(1, marca, nombre, tipoProd, contenido, precio, descripcion);
                adminProd.GuardarCambios();
            }

            this.Close();
        }

        private void BajaProducto(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            var VnaPpal = (VerProductoYmasUI)btn.FindForm();
            var adminProd = new ControladorProducto();

            if (VnaPpal.lblCodigo.Text == "XX")
            {
                var VnaBuscar = new BuscarProductoUI();
                VnaBuscar.ShowDialog(this);
            }
            else
            {
                int codProd = int.Parse(VnaPpal.lblCodigo.Text.Trim());
                adminProd.BajaProducto(codProd);
                adminProd.GuardarCambios();
                Utilidades.LimpiarFormulario(VnaPpal);
                VnaPpal.lblCodigo.Text = "XX";
            }

        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
