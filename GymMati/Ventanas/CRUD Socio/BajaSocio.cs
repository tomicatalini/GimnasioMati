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
using System.Data.Entity;

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
            using (var dbMati = new GymMatiContext())
            {

                if (tbBuscar.Text == "")
                {
                    //Algo
                }
                else
                {
                    Controlador controlador = new Controlador(dbMati);
                    this.nope.Visible = false;
                    this.baja.Visible = false;

                    //Si no se existe el usuario
                    if (!(controlador.existeSocio(Convert.ToInt32(tbBuscar.Text))))
                    {
                        this.nope.Visible = true;
                    }
                    else
                    {

                        controlador.bajaSocio(Convert.ToInt32(tbBuscar.Text));
                        controlador.guardarCambios();

                        this.baja.Visible = true;
                    }
                }
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Socio nuevoSocio = new Socio();
            nuevoSocio.Show();
        }
    }
}
