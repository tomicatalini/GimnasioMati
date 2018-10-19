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

namespace GymMati.VentanasNuevas.SocioUI
{
    public partial class VerSocioUI : BaseBuscarUI
    {
        public VerSocioUI()
        {
            InitializeComponent();
        }

        private void MouseHoverHandler(object sender, EventArgs e)
        {
            var unBoton = (Button)sender;

            unBoton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            unBoton.ForeColor = Color.White;
            unBoton.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));

        }

        private void MouseLeaveHandler(object sender, EventArgs e)
        {
            var unBoton = (Button)sender;

            unBoton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            unBoton.ForeColor = Color.Black;
            unBoton.BackColor = Color.Gainsboro;

        }

        private void ModificarSocioEvent(object sender, EventArgs e)
        {
            foreach (Control pElem in this.Controls)
            {
                if (pElem is TextBox || pElem is ControlesPersonalizados.TextBoxValidar || pElem is DateTimePicker)
                {
                    pElem.Enabled = true;
                }
            }

            this.btnModificar.IsPressed = true;
        }

        private void BajaSocioEvent(object sender, EventArgs e)
        {

            ControladorSocio adminSocio = new ControladorSocio();

            adminSocio.BajaSocio(int.Parse(this.txtDocumento.Text));

            this.lblBajaSocio.Visible = true;
            adminSocio.GuardarCambios();
        }

        private void AceptarVerSocioEvent(object sender, EventArgs e)
        {

            if (this.btnModificar.IsPressed)
            {
                ControladorSocio adminSocio = new ControladorSocio();
                adminSocio.ModificarSocio(int.Parse(txtDocumento.Text), txtNombre.Text, txtApellido.Text, dateFechaNacimiento.Value, txtDomicilio.Text, long.Parse(txtTelefono.Text), txtCorreo.Text);
                this.btnModificar.IsPressed = false;
                adminSocio.GuardarCambios();
            }
            else
            {
                this.Close();
            }
        }
    }
}
