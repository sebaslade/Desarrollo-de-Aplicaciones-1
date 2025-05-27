using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BE;
using LeonComputing_BL;

namespace LeonComputing_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 20;
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                // Codifique...
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                if (objUsuarioBE is null)
                {
                    // Si la cuenta no existe
                    MessageBox.Show("Usuaio no existe");
                    intentos += 1;
                    ValidaAccesos();
                }
                else if (objUsuarioBE.Login_Usuario == txtLogin.Text.Trim() &&
                         objUsuarioBE.Pass_Usuario == txtPassword.Text.Trim())
                {
                    // Si las credenciales son correctas
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;

                    // Guardamos las credenciales

                    // Mosramos el MDI
                    MDIPrincipal objMDI = new MDIPrincipal();
                    objMDI.ShowDialog();
                }


                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
