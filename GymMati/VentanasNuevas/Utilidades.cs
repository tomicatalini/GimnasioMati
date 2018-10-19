using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMati.VentanasNuevas.ControlesPersonalizados;

namespace GymMati.VentanasNuevas
{
    class Utilidades
    {

        public static bool ValidarFormulario(Control pControl, ErrorProvider pError)
        {
            //Variable que determina si hay un error
            bool HayError = false;

            //Por cada elemento (TextBox mas especifico, pero recorre todos) de la ventana se verifica si se tienen
            //que validar, es decir, si pueden o no estar vacios.
            foreach (Control elem in pControl.Controls)
            {

                if (elem is TextBoxValidar)
                {
                    TextBoxValidar unTextBox = (TextBoxValidar)elem;

                    if (unTextBox.Validar == true)
                    {

                        if (string.IsNullOrEmpty(unTextBox.Text.Trim()))
                        {

                            pError.SetError(unTextBox, "Dato Obligatorio!");
                            HayError = true;
                        }
                    }
                }
            }

            return HayError;
        }

        /// <summary>
        /// Verifica si un control esta vacio o no al perder el foco.
        /// </summary>
        /// <param name="Object"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidarControl(Control Object, ErrorProvider e)
        {
            bool HayError = false;

            if (Object is TextBoxValidar)
            {

                TextBoxValidar unTextBox = (TextBoxValidar)Object;

                if (string.IsNullOrEmpty(unTextBox.Text.Trim()))
                {

                    e.SetError(unTextBox, "Dato Obligatorio!");
                    HayError = true;
                }
            }

            return HayError;
        }

        public static void LimpiarFormulario(Form Object)
        {
            //var unFormulario = Object;
            foreach (Control control in Object.Controls)
            {
                if (control is TextBox || control is ComboBox || control is RichTextBox)
                    control.Text = "";

                if (control is DateTimePicker)
                {
                    var dateTime = (DateTimePicker)control;
                    dateTime.Value = DateTime.Today;
                }
            }
        }
    }
}
