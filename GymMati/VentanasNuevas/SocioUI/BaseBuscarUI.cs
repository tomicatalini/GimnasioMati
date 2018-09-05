using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer;
using BusinessLayer.Controladores;

namespace GymMati.VentanasNuevas.SocioUI
{
    public partial class BaseBuscarUI : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseBuscarUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra la ventana actual e inicializa nuevamente la ventana que la llamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CerrarVentanaHandler(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        /// <summary>
        /// Permite ingresar solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EsNumero(object sender, KeyPressEventArgs e)
        {

            //verifica si la tecla oprimida es un numero o una tecla de control
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar solo cadenas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StringOnly(object sender, KeyPressEventArgs e)
        {

            //Verifica si la tecla oprimida es una letra, una tecla de control o espacio(borrar,ctrl, etc)
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Busca los socios que coincidan con el valor de entrada del TextBox y los muestra por pantalla en forma
        /// de lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListarSocios(object sender, KeyEventArgs e)
        {

            //Inicializacion de variables
            ControladorSocio adminSocio = new ControladorSocio();
            TextBox unTextBox = (TextBox)sender;
            BaseBuscarUI formBase = (BaseBuscarUI)unTextBox.FindForm();
            int rowIndex;

            //Elimina toda ocurrencia anterior
            if (formBase.listaSocios.RowCount > 0)
                formBase.listaSocios.Rows.Clear();

            ////Lista de socios filtada por su apellido
            if (!string.IsNullOrEmpty(unTextBox.Text.Trim()))
            {
                //Agrega cada socio al dataGridView
                foreach (var socio in adminSocio.GetSociosByApellido(unTextBox.Text.Trim()))
                {
                    rowIndex = formBase.listaSocios.Rows.Add();

                    formBase.listaSocios.Rows[rowIndex].Cells[0].Value = socio.NroSocio;
                    formBase.listaSocios.Rows[rowIndex].Cells[1].Value = socio.Apellido + ", " + socio.Nombre;
                }
            }

            formBase.listaSocios.ClearSelection();
        }

        private void MostarDatosSocioHandler(object sender, DataGridViewCellEventArgs e)
        {
            //Inicializacion de variables
            ControladorSocio adminSocio = new ControladorSocio();
            DataGridView dataGrid = (DataGridView)sender;
            BaseBuscarUI formBase = (BaseBuscarUI)dataGrid.FindForm();
           
            //dni asociado a la celda seleccionada
            int codigo = (int)dataGrid.Rows[e.RowIndex].Cells[0].Value;
            //socio con el dni en cuestion
            var unSocio = adminSocio.GetSocioByNroSocio(codigo);

            //Visualizacion de los valores del socio
            if (!(unSocio is null))
            {
                formBase.txtDocumento.Text = unSocio.DNI.ToString();
                formBase.txtApellido.Text = unSocio.Apellido;
                formBase.txtNombre.Text = unSocio.Nombre;
                formBase.txtDomicilio.Text = unSocio.Domicilio;
                formBase.txtCorreo.Text = unSocio.Mail;
                formBase.txtTelefono.Text = unSocio.Telefono.ToString();
                formBase.dateFechaNacimiento.Value = unSocio.FecNacimiento;
            }
            else
            {
                formBase.txtApellido.Text = "Nope";
            }            
        }
    }
}
