using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMati.Ventanas;
using GymMati.VentanasNuevas.ProductoIU;

namespace GymMati
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //AltaProductoUI ventanaPpal = new AltaProductoUI();
            Application.Run(new ModPreciosProductosUI());

        }
    }
}
