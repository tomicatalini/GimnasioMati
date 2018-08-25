﻿using System;
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
using System.Data.Entity;

namespace GymMati.Ventanas
{
    public partial class VerSocio : Form
    {
        public VerSocio()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            using (var dbMati = new GymMatiContext())
            {

                if (tbBuscar.Text == "")
                {
                    //Algo
                }
                else
                {
                    Controlador controlador = new Controlador(dbMati);
                    this.nope.Visible = false;
                    
                    //Si no se existe el usuario
                    if (!(controlador.existeSocio(Convert.ToInt32(tbBuscar.Text))))
                    {
                        this.nope.Visible = true ;
                    }
                    else
                    {
                        SocioDTO unSocio = controlador.buscarSocio(Convert.ToInt32(this.tbBuscar.Text));

                        this.tbDni.Text = unSocio.dni.ToString();
                        this.tbNombre.Text = unSocio.nombre;
                        this.tbApellido.Text = unSocio.apellido;
                        this.tbDom.Text = unSocio.domicilio;
                        this.tbTel.Text = unSocio.telefono.ToString();
                        this.dtFechaNac.Value = unSocio.fechaNac;
                        this.tbMail.Text = unSocio.mail;
                    }
                }
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Socio nuevoSocio = new Socio();
            nuevoSocio.Show();
        }
    }
}