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
    public partial class AltaProductoUI : Form
    {
        public AltaProductoUI()
        {
            InitializeComponent();
        }

        private void OnLoadHandler(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_DataLayer_DataBase_GymMatiContextDataSet.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this._DataLayer_DataBase_GymMatiContextDataSet.TipoProducto);

            ControladorProducto adminProd = new ControladorProducto();
            AltaProductoUI ventanaPpal = (AltaProductoUI)sender;

            ventanaPpal.lblNumero.Text = adminProd.NumeroNuevoProducto().ToString();

        }

        private void AgregarProductoHandler(object sender, EventArgs e)
        {
            var aceptarButton = (Button)sender;
            AltaProductoUI ventanaPpal = (AltaProductoUI)aceptarButton.FindForm();
            var adminProd = new ControladorProducto();

            int codProducto = int.Parse(ventanaPpal.lblNumero.Text.Trim());
            string marca = ventanaPpal.txtMarca.Text.Trim().ToLower();
            string nombre = ventanaPpal.txtNombre.Text.Trim().ToLower();
            string tipoProducto = ventanaPpal.cbxTipo.Text.Trim().ToLower();
            float contenido = float.Parse(ventanaPpal.txtContenido.Text.Trim());
            float precio = float.Parse(ventanaPpal.txtPrecio.Text.Trim());
            string descripcion = ventanaPpal.rTxtDescripcion.Text.Trim();

            adminProd.AltaProducto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            adminProd.GuardarCambios();
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            //this.Owner.Show();
            this.Close();
        }

        private void AgregarSiNoExiste(object sender, EventArgs e)
        {
            //Inicializacion de variables
            var comboBox = (ComboBox)sender;
            var adminProd = new ControladorProducto();
            string nombre = comboBox.Text.Trim();
            string msj;
            DialogResult resultado;

            //Si el valor ingresado no es vacio
            if (!(string.IsNullOrEmpty(nombre)))
            {
                //Si el valor ingresado no existe en la base de datos
                if (tipoProductoBindingSource.Find("nombre", nombre) < 0)
                {
                    msj = "El Tipo de Producto: " + nombre + " no existe en la base de datos. Desea agregarlo?";
                    resultado = MessageBox.Show(msj, "Alta Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //Agrega el nuevo Tipo de Producto al Repositorio
                        adminProd.AddTipoProducto(1, nombre);
                        //Agrega el nuevo producto a la lista del comboBox
                        tipoProductoBindingSource.Add(nombre);
                    }
                    else
                    {

                        comboBox.Text = "";
                        comboBox.Focus();
                    }

                }

                adminProd.GuardarCambios();
            }
        }
    }
}

