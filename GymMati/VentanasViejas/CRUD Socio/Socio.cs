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
using GymMati.VentanasNuevas.SocioUI;

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
            AltaSocioUI nuevaVentAltaSocio = new AltaSocioUI();

            //Se pasa una objeto (Socio) para no perder la referencia
            nuevaVentAltaSocio.Show(this);

            //Ocultar la pantalla de Socio
            this.Hide();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVerSocio_Click(object sender, EventArgs e)
        {
            
            //Inicializar ventana VerSocio
            VerSocioUI nuevoVerSocio = new VerSocioUI();
            nuevoVerSocio.Show(this);

            //Ocultar pantalla socio
            this.Hide();

        }

        private void btModSocio_Click(object sender, EventArgs e)
        {
           
            //Inicializar ventana VerSocio
            ModificarSocioUI nuevoModificar = new ModificarSocioUI();
            nuevoModificar.Show(this);

            //Ocultar pantalla socio
            this.Hide();

        }

        private void btBajaSocio_Click(object sender, EventArgs e)
        {
            
            //Inicializar ventana VerSocio
            VerSocioUI bajaSocio = new VerSocioUI();
            bajaSocio.Show(this);

            //Ocultar pantalla socio
            this.Hide();

        }

        private void Socio_Load(object sender, EventArgs e)
        {



        }
       
    }
}
