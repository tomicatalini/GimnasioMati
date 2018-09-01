using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //hace algo
            }
            else
            {
                using (var dbMati = new GymMatiContext())
                {
                    //Se iniciliza el controlador
                    Controlador controlador = new Controlador(dbMati);

                    //Se hace el alta socio
                    controlador.altaSocio(Convert.ToInt64(tbDni.Text), tbNombre.Text, tbApellido.Text, dtFechaNac.Value, tbDom.Text, Convert.ToInt32(tbTel.Text), tbMail.Text);

                    //Commit en Base de Datos
                    controlador.guardarCambios();
                }

                btGuacho.Visible = true;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

            
            //Socio ventanaSocio = new Socio();

            //ventanaSocio.Show();
        }
    }
}
