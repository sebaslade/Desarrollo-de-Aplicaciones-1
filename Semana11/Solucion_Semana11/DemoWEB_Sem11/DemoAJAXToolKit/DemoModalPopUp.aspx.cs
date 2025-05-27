using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_AJAX.EjemplosAJAXToolkit
{
    public partial class DemoModalPopUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            // Codifique
            lblMensaje.Text = String.Empty ;
            lblValidacion.Text = String.Empty;
            cboCategoria.SelectedIndex = 0;
            mpTarifario.Show();
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            // Codifique
            try
            {
                // Asignamos...
                Int16 intHoras = Convert.ToInt16(txtHoras.Text.Trim());
                Int16 intTarifa = Convert.ToInt16(txtTarifa.Text.Trim());
                Int16 intTardanzas = Convert.ToInt16(txtTardanzas.Text.Trim());

                // Calculamos

                Single sngMontoHoras = intHoras * intTarifa;
                Single sngMontotardanzas = intTardanzas * (intTarifa * 25 / 100);
                Single sngNeto = sngMontoHoras - sngMontotardanzas;

                //Mostramos

                txtNeto.Text = sngNeto.ToString("##,###.00 soles");

                // Mostramos un mensaje de conformidad
                lblMensaje.Text = "Calculos correctos";
                mpeMensaje.Show();
            }
            catch (Exception ex)
            {
                txtHoras.Text = String.Empty;
                txtTardanzas.Text = String.Empty;
                txtTarifa .Text = String.Empty; 
                txtNeto.Text = String.Empty;
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();

            }
        }

        protected void btnAceptarTarifa_Click(object sender, EventArgs e)
        {
            // Codifique
            try
            {
                if (cboCategoria.SelectedValue == "0")
                {
                    throw new Exception("Debe elegir una tarifa");
                }
                else
                {
                    txtTarifa.Text = cboCategoria.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                lblValidacion.Text = ex.Message;
                mpTarifario.Show();
            }

        }
    }
}