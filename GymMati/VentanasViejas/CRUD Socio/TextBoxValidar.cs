using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMati.Ventanas.CRUD_Socio
{
    public partial class TextBoxValidar : TextBox
    {
        public TextBoxValidar()
        {
            InitializeComponent();
        }

        public bool Validar { get; set; }

    }
}
