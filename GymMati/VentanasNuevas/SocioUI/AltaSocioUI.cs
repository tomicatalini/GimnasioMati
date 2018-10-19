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
    public partial class AltaSocioUI : BaseUI
    {
        public AltaSocioUI()
        {
            InitializeComponent();
        }        

        private void AgregarFichaMedica(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente fuera de servicio. Disculpe las molestias :(", "Alta Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
