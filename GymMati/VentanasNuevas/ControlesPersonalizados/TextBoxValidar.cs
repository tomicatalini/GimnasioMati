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
    public partial class TextBoxValidar : TextBox
    {
        public TextBoxValidar()
        {
            InitializeComponent();
        }

        public bool Validar { get; set; }
        public bool Numerico { get; set; }

        //public TextBoxValidar(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
