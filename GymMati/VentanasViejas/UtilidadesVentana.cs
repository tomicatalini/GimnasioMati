using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMati.Ventanas
{
    class UtilidadesVentana
    {

        public static bool ValidarFormulario(Control pventana, ErrorProvider pError)
        {
            foreach (Control pControl in pventana.Controls)
            {

                if ((pControl is TextBox) & (pControl))
                {

                    if (string.IsNullOrEmpty(pControl.Text.Trim()))
                    {

                    }
                }
            }
        }
    }
}
