using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem09
{
    public partial class TestClaseNumero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                clsNumero objNumero = new clsNumero();
                lblFactorial.Text = objNumero.Factorial(Convert.ToDouble(txtNumero.Text)).ToString();

                if (objNumero.EsPrimo(Convert.ToDouble(txtNumero.Text)) == true)
                {
                    lblEsPrimo.Text = "Si es primo";
                }
                else
                {
                    lblEsPrimo.Text = "No es primo";
                }

                //Se muestra el mensaje...
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Datos calculados con exito";
            }
            catch(Exception ex)
            {
                lblFactorial.Text = String.Empty;
                lblEsPrimo.Text = String.Empty;
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}