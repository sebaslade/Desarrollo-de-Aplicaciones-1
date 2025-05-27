using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonComputing_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();

            IsMdiContainer = true;
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Usuario;
            // Manejamos la seguridad por roles
            if (clsCredenciales.Nivel == 1)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = false;
                listadosToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Visible = true;
            }
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            AsociadoMan01 objAsoMan01 = new AsociadoMan01();
            objAsoMan01.MdiParent = this;
            objAsoMan01.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            EventoMan01 objEveMan01 = new EventoMan01();
            objEveMan01.MdiParent = this;
            objEveMan01.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CursoMan01 objCurMan01 = new CursoMan01();
            objCurMan01.MdiParent = this;
            objCurMan01.Show();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
