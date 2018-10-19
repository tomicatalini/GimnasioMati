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
using BusinessLayer.Controladores;

namespace GymMati.Ventanas
{
    public partial class BajaSocio : Form
    {
        public BajaSocio()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            

                if (tbBuscar.Text == "")
                {
                    MessageBox.Show("No se ingreso ningun dni", "Alta Socio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ControladorSocio adminSocio = new ControladorSocio();
                    this.nope.Visible = false;
                    this.baja.Visible = false;

                    //Si no se existe el usuario
                    //if (!(adminSocio.existeSocio(Convert.ToInt32(tbBuscar.Text))))
                    //{
                    //    this.nope.Visible = true;
                    //}
                    //else
                    //{

                    adminSocio.BajaSocio(Convert.ToInt32(tbBuscar.Text));

                    MessageBox.Show("El socio se dio de baja", "Baja Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BajaSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
