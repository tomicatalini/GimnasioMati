using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DataBase;
using BusinessLayer;

namespace GymMati.Ventanas
{
    public partial class Socio : Form
    {
        public Socio()
        {
            InitializeComponent();
        }
        
        private void btAltaSocio_Click(object sender, EventArgs e)
        {
            

            //Incializa la ventana de AltaSocio
            AltaSocio nuevaVentAltaSocio = new AltaSocio();
            nuevaVentAltaSocio.Show(this);

            //Ocultar la pantalla de Socio
            this.Hide();

            //this.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVerSocio_Click(object sender, EventArgs e)
        {
            //Ocultar pantalla socio
            this.Hide();

            //Inicializar ventana VerSocio
            VerSocio nuevoVerSocio = new VerSocio();
            nuevoVerSocio.Show();

        }

        private void btModSocio_Click(object sender, EventArgs e)
        {
            //Ocultar pantalla socio
            this.Hide();

            //Inicializar ventana VerSocio
            ModificarSocio nuevoModificar = new ModificarSocio();
            nuevoModificar.Show();
        }

        private void btBajaSocio_Click(object sender, EventArgs e)
        {
            //Ocultar pantalla socio
            this.Hide();

            //Inicializar ventana VerSocio
            BajaSocio bajaSocio = new BajaSocio();
            bajaSocio.Show();
        }

        private void Socio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            using (var DbContext = new GymMatiContext())
            {
                Controlador adm = new Controlador(DbContext);

                adm.altaSocio(1, "tomas", "catalini", new DateTime(1995, 03, 11), "suipacha 345", 1312312, "tomascatalini@gmail.com");

                adm.guardarCambios();
            }

            this.Close();
        }
    }
}
