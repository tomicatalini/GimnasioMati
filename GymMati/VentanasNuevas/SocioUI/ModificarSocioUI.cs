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
    public partial class ModificarSocioUI : BaseBuscarUI
    {
        public ModificarSocioUI()
        {
            InitializeComponent();
        }

        private void ModificarSocio(object sender, EventArgs e)
        {

            ControladorSocio adminSocio = new ControladorSocio();

            adminSocio.ModificarSocio(int.Parse(txtDocumento.Text), txtNombre.Text, txtApellido.Text, dateFechaNacimiento.Value, txtDomicilio.Text, long.Parse(txtTelefono.Text), txtCorreo.Text);

            MessageBox.Show("El socio se modifico de manera exitosa", "Modificar Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            adminSocio.GuardarCambios();
            this.Close();
        }
    }
}
