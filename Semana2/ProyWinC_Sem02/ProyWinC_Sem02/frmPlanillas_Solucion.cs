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
    public partial class frmPlanillas_Solucion : Form
    {
        public frmPlanillas_Solucion()
        {
            InitializeComponent();
        }


        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validamos que solo se permita la pulsacion de BackSpace y digitos...
            if (e.KeyChar != 8) // Si no es BackSpace
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {
                    // Se atrapa el caracter pulsado y no se imprime
                    e.Handled = true;
                }

            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            // Preguntamos por la longitud de lo escrito...
            if (txtDNI.Text.Trim().Length != 8)
            {
                // Se cancela el ingreso...
                e.Cancel = true;

                errorProvider1.SetError(txtDNI, "El DNI es obligatorio y de 8 caracteres.");

                txtDNI.SelectAll();

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmPlanillas_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario seleccionar por defecto el primer item del cboCategorias
            cboCategorias.SelectedIndex = 0;
        }

        private void txtHoras_Validating(object sender, CancelEventArgs e)
        {
            // Definimos cual de los 2 controles genero el evento mediante el objeto Sender
            TextBox mitxt = (TextBox)sender;
            
            // Validacion de las horas dictadas....
            Int16 intHoras;
           

            if (mitxt.Text.Trim() == String.Empty) // Si se dejo en blanco
            {
                e.Cancel = true;
                errorProvider1.SetError(mitxt, "Las horas de dictado y de asesoria son  obligatorias.");
            }
            else  // Si se ingreso un valor hay que validar que este entre 1 y 50
            {
                intHoras = Convert.ToInt16(mitxt.Text);
                if (intHoras < 1 | intHoras > 50)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(mitxt, "Las horas de dictado y de asesoria deben estar entre 1 y 50.");
                    mitxt.SelectAll();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos los textbox del formulario...
            foreach (Control miControl in this.Controls)// Recorremos los controles de este formulario
            {
                if (miControl is TextBox) // Limpiamos todas las cajas de texto
                {
                    miControl.Text = "";
                }
              
            }

            // Limpiamos los label de resultado dentro del groupbox
            foreach (Control miControl in grpResultados.Controls)// Recorremos los controles del groupbox1
            {
                if (miControl is Label) // Limpiamos todos los label de resultados
                {
                    if (miControl.Name.StartsWith("lbl") == true)
                    {
                        miControl.Text = "";
                    }
                }

            }
            
            // Colocamos los demas controles en sus estados originales...
            chkDescuento.Checked = false;
            cboCategorias.SelectedIndex = 0;
            // Enviamos cursor a la caja de txtDNI...
            txtDNI.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardamos las horas dictadas y de asesoria
                Int16 intHorasDictadas = Convert.ToInt16(txtHorasDictadas.Text);
                Int16 intHorasAsesoria = Convert.ToInt16 (txtHorasAsesoria.Text);   

                // Manejamos la tarifa horaria
                // Validamos que se haya seleccionado una categoria correcta
                if (cboCategorias.SelectedIndex == 0)
                {
                    throw new Exception("Por favor, seleccione una categoria");
                }

                // Evaluamos que categoria se selecciono
                Single sngTarifa=0;
                switch (cboCategorias.SelectedIndex)
                {
                    case 1:
                        sngTarifa = 50;
                        break;
                    case 2:
                        sngTarifa = 40;
                        break;
                    case 3:
                        sngTarifa = 50;
                        break;
                }

                // Se calcula el Pago por horas
                Single sngPagoHoras = sngTarifa * (intHorasDictadas+ intHorasAsesoria );

                // Se evalua si se aplica descuento de 5ta categoria
                Single sngDescuento;
                if (chkDescuento.Checked == true)
                {
                    sngDescuento = Convert.ToSingle(sngPagoHoras * 0.1);
                }
                else
                {
                    sngDescuento = 0;
                }

                // Se obtiene el bono segun tipo de dictado
                Single sngBono=0;
                if (optPresencial.Checked == true)
                {
                    sngBono = 200;
                }
                else if (optRemota.Checked == true)
                {
                    sngBono = 100;
                }
                else if (optMixta.Checked == true)
                {
                    sngBono = 300;
                }
                else
                {
                    throw new Exception("Debe seleccionar una modalidad de dictado");
                }
                // Se calcula el neto a pagar 
                Single sngNeto = sngPagoHoras + sngBono - sngDescuento;

                // Se muestran los resultados...
                lblTarifa.Text = sngTarifa.ToString("#0.00");
                lblPagoHoras.Text = sngPagoHoras.ToString("#,##0.00");
                lblDescuento.Text = sngDescuento.ToString("##0.00");
                lblBono.Text = sngBono.ToString("##0.00");
                lblNeto.Text = sngNeto.ToString("##,##0.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show ("Error: " +ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        private void frmPlanillas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}