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
using GymMati.VentanasNuevas.ControlesPersonalizados;

namespace GymMati.VentanasNuevas.SocioUI
{
    public partial class BaseUI : Form
    {
        public BaseUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CerrarVentana(object sender, EventArgs e)
        {

            //this.Owner.Show();
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
        /// Advierte si un textBox es vacio. En ese caso, muestra al usuario un signo de advetencia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EsVacio(object sender, EventArgs e)
        {

            TextBox unTextBox = (TextBox)sender;
            if (!Utilidades.ValidarControl(unTextBox, errorValidarControl))
            {
                if(unTextBox.TabIndex == 0)
                    this.BuscarSocioEvent(sender, e);
            }
        }

        private void AltaSocio(object sender, EventArgs e)
        {
            var unBoton = (Button)sender;
            BaseUI formBase = (BaseUI)unBoton.FindForm();
            var adminSocio = new ControladorSocio();

            if (Utilidades.ValidarFormulario(formBase, errorValidarControl))
            {
                MessageBox.Show("Para continuar, es necesario completar los campos obligatorios.", "Alta Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dni = int.Parse(formBase.txtDocumento.Text.Trim());
                string nombre = formBase.txtNombre.Text;
                string apellido = formBase.txtApellido.Text;
                DateTimePicker fechaNacimiento = formBase.dateFechaNacimiento;
                string domicilio = formBase.txtDomicilio.Text;
                long telefono = long.Parse(formBase.txtTelefono.Text.Trim());
                string correo = formBase.txtCorreo.Text;


                //ModificarSocio
                if (formBase.txtDocumento.Enabled == false)
                {
                    adminSocio.ModificarSocio(dni, nombre, apellido, fechaNacimiento.Value, domicilio, telefono, correo);
                    adminSocio.GuardarCambios();
                    DialogResult resultado = MessageBox.Show("Los datos del socio se han modificado correctamente.", "Alta Socio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                }
                else
                {

                    adminSocio.AltaSocio(dni, nombre, apellido, fechaNacimiento.Value, domicilio, telefono, correo);
                    DialogResult resultado = MessageBox.Show("El socio se dio de alta exitosamente. Si desea agregar otro socio, presione SI.", "Alta Socio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        Utilidades.LimpiarFormulario(formBase);
                        formBase.txtDocumento.Focus();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        adminSocio.GuardarCambios();
                        formBase.Owner.Show();
                        formBase.Close();
                    }
                    else { }
                }
            }

        }

        private void SocioInactivoOption(Form formulario, ControladorSocio adminSocio ,int dniSocio)
        {
            BaseUI formBase = (BaseUI)formulario;

            DialogResult unResultado = MessageBox.Show("El dni ingresado corresponde a un socio que anteriormente fue dado de baja. Desea darlo de alta nuevamente? En caso afirmativo, podra modificar todos sus datos.", "Alta Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (unResultado == DialogResult.Yes)
            {
                formBase.txtDocumento.Enabled = false;
                adminSocio.AltaSocioBaja(dniSocio);
                adminSocio.GuardarCambios();
            }
            else
            {
                Utilidades.LimpiarFormulario(formBase);
                formBase.txtDocumento.Focus();
            }

        }

        private void ModificarSocioOption(Form formulario)
        {
            BaseUI formBase = (BaseUI)formulario;

            DialogResult unResultado = MessageBox.Show("El dni ingresado corresponde a un socio existente. Desea modificarlo?", "Alta Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (unResultado == DialogResult.No)
            {
                formBase.txtNombre.Enabled = false;
                formBase.txtApellido.Enabled = false;
                formBase.txtDomicilio.Enabled = false;
                formBase.txtTelefono.Enabled = false;
                formBase.txtCorreo.Enabled = false;
                formBase.dateFechaNacimiento.Enabled = false;
                formBase.btnCancelar.Focus();

            }
            else
            {
                formBase.txtDocumento.Enabled = false;
                formBase.txtApellido.Focus();
            }

        }


        private void BuscarSocioEvent(object sender, EventArgs e)
        {
            var unTextBox = (TextBoxValidar)sender;
            BaseUI formBase = (BaseUI)unTextBox.FindForm();
            var adminSocio = new ControladorSocio();
            var unSocio = adminSocio.GetSocioByDni(int.Parse(this.txtDocumento.Text.Trim()));

            if (!(unSocio is null))
            {

                formBase.txtDocumento.Text = unSocio.DNI.ToString();
                formBase.txtNombre.Text = unSocio.Nombre;
                formBase.txtApellido.Text = unSocio.Apellido;
                formBase.txtDomicilio.Text = unSocio.Domicilio;
                formBase.txtTelefono.Text = unSocio.Telefono.ToString();
                formBase.txtCorreo.Text = unSocio.Mail;
                formBase.dateFechaNacimiento.Value = unSocio.FecNacimiento;

                if (unSocio.Activo == false)
                {
                    this.SocioInactivoOption(formBase, adminSocio, unSocio.DNI);
                }
                else
                {

                    this.ModificarSocioOption(formBase);
                }
            }
            else
            {
                this.txtApellido.Focus();
            }
        }
    }
}
