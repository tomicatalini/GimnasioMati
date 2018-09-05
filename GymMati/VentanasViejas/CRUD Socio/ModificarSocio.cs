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
using BusinessLayer.Controladores;

namespace GymMati.Ventanas
{
    public partial class ModificarSocio : Form
    {
        public ModificarSocio()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
           

                //if (tbBuscar.Text == "")
                //{
                //    MessageBox.Show("No se ingreso ningun dni", "Modificar Socio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                //    ControladorSocio adminSocio = new ControladorSocio();
                //    this.nope.Visible = false;

                ////Si no se existe el usuario
                ////if (!(controlador.existeSocio(Convert.ToInt32(tbBuscar.Text))))
                ////{
                ////    this.nope.Visible = true;
                ////}
                ////else
                ////{
                
                //SocioDTO unSocio = adminSocio.BuscarSocio(Convert.ToInt32(this.tbBuscar.Text));

                //        this.tbDni.Text = unSocio.DNI.ToString();
                //        this.tbNombre.Text = unSocio.Nombre;
                //        this.tbApellido.Text = unSocio.Apellido;
                //        this.tbDom.Text = unSocio.Domicilio;
                //        this.tbTel.Text = unSocio.Telefono.ToString();
                //        this.dtFechaNac.Value = unSocio.FechaNac;
                //        this.tbMail.Text = unSocio.Mail;
                    
                //}
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            ////Se verifica si alguno de los datos de entrada es vacio
            //if ((tbDni.Text == "") || (tbNombre.Text == "") || (tbApellido.Text == "") || (tbDom.Text == "") || (tbTel.Text == "") || (tbMail.Text == ""))
            //{
            //    MessageBox.Show("Debe completar los campos obligatorios antes de continuar!", "Alta Socio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{

            //    //Se iniciliza el controlador
            //    ControladorSocio adminSocio = new ControladorSocio();

            //    //Se hace el alta socio
            //   adminSocio.modificarSocio(Convert.ToInt32(tbDni.Text), tbNombre.Text, tbApellido.Text, dtFechaNac.Value, tbDom.Text, Convert.ToInt32(tbTel.Text), tbMail.Text);
            //    adminSocio.GuardarCambios(); 
            //}

            //this.Owner.Show();
            //this.Close();
        }

        private void ModificarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
