using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class MDIPrincipal : Form
    {
        // Instancias y variables
        TimeSpan horaEntrada = new TimeSpan();
        Computer miEquipo = new Computer();
        String miRed;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            //Refrescamos la imagen...
            this.Refresh();
        }

        private void visorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creamos una instancia del formulario a mostrar...
            frmVisorImagenes frm1 = new frmVisorImagenes();
            // Se establece como contenedor de la instancia al MDIPrincipal
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void resgistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPersonal frm2 = new frmRegistroPersonal();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void vistaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVistaPersonal frm3 = new frmVistaPersonal();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solicitamos la confirmacion del cierre del formulario
            DialogResult vrpta = MessageBox.Show("¿Esta seguro de salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Enviar respuesta
            if (vrpta == DialogResult.No)
            {
                //Cancelamos el cierre de formulario
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Finalizamos la aplicacion
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mostramos fecha y hora del sistema en el texto del formulario
            this.Text = "Menu Principal " + DateTime.Now.ToString();

            // Mostramos el tiempo iniciada la sesion...
            lblSesion.Text = "Tiempo sesion: " + DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0,8); //-> desde la posicion 0 -> 8 posiciones
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            // Registramos la hora de entrada...
            horaEntrada = DateTime.Now.TimeOfDay;

            // Obtenemos si el equipo actual tiene o no disponibilidad de conexion a red local...
            if(miEquipo.Network.IsAvailable == true)
            {
                miRed = "Equipo con conexion disponible";
            }
            else
            {
                miRed = "Equipo sin conexion disponible";
            }
            // Mostramos en el lblEquipo el nombre y su disponibilidad de red
            lblEquipo.Text = "Equipo: " + miEquipo.Name+". "+miRed;
        }
    }
}
