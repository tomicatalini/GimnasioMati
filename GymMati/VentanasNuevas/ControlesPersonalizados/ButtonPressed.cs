using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymMati.VentanasNuevas.ControlesPersonalizados
{
    public partial class ButtonPressed : Button
    {
        public ButtonPressed()
        {
            InitializeComponent();
        }

        public bool IsPressed { get; set; }
    }
}
