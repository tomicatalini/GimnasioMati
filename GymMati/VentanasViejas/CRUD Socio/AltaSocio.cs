using System;
using BusinessLayer.Controladores;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.DataBase;
using DataLayer;

namespace GymMati.Ventanas
{
    public partial class AltaSocio : Form
    {
        public AltaSocio()
        {
            InitializeComponent();
        }

        private void AltaSocio_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se verifica si alguno de los datos de entrada es vacio
            if ((tbDni.Text == "") || (tbNombre.Text == "") || (tbApellido.Text =="") || (tbDom.Text == "")  || (tbTel.Text == "") || (tbMail.Text == ""))
            {
                MessageBox.Show("Debe completar los campos obligatorios antes de continuar!", "Alta Socio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ControladorSocio adminSocio = new ControladorSocio();

                adminSocio.AltaSocio(Convert.ToInt32(tbDni.Text), tbNombre.Text, tbApellido.Text, dtFechaNac.Value, tbDom.Text, Convert.ToInt32(tbTel.Text), tbMail.Text);

                MessageBox.Show("El socio se dio de alta", "Alta Socio",MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminSocio.GuardarCambios();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

            
            //Socio ventanaSocio = new Socio();

            //ventanaSocio.Show();
        }

        private void tbDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
