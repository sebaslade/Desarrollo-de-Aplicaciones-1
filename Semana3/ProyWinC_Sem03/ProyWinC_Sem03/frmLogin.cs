﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class frmLogin : Form
    {
        int intentos = 0;// Para cantidad de intentos fallidos
        int tiempo = 20; // Para cantidad de segundos como limite de tiempo para ingresar credenciales
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLogin .Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                // Codifique
                if(txtLogin.Text == "ISIL" &&  txtPassword.Text == "12345")
                {
                    // Ocultamos el frmLogin
                    this.Hide();

                    // Detenemos el timer...
                    timer1.Enabled = false;

                    // Creamos una instancia
                    MDIPrincipal frmMDI = new MDIPrincipal();
                    frmMDI.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               intentos +=1;
            }
            // Si se llega al intento 3 se envia el mensaje y se sale de la aplicacion
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cada segundo se decrementa la variable tiempo  en menos 1, reflejando esto en el texto del formulario
            // para que el usuario sepa cuantos segundos le van restando para ingresar sus credenciales.
            tiempo -= 1;
            this.Text = "Ingrese su Usuario y contraseña. Le quedan..." + tiempo;

            // Si la variable tiempo llega a 0 , se le indica que el tiempo expiro y saldremos de la aplicacion.
            if (tiempo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera.", "Mensaje",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();

            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
