using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button miBoton = (Button)sender; //sender es el objeto que propicia el evento
            MessageBox.Show("No olvidarse de enviar la bitacora la proxima clase", miBoton.Name); // miBoton añade el nombre del evento
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validamos si la tecla pulsada no es BackSpace...
            if (e.KeyChar != 8)
            {
                // Validamos si la tecla pulsada no es un digito...
                if (char.IsDigit(e.KeyChar) == false)
                {
                    // Atrapa la tecla pulsada y no permite su tipeo
                    e.Handled = true;
                }
            }
        }
    }
}
