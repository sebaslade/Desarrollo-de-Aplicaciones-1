using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.PasandoDatos
{
    public partial class Origen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String strURL = "Destino1.aspx?P1="+txtNombre.Text+"&P2="+txtApellido.Text;
                Response.Redirect(strURL);
            }
            catch (Exception ex)
            {
                lblMensaje.Text ="Error:" + ex.Message;
            }
        }

        protected void btnDestino2_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardamos los datos en variables de sesion
                Session["Nombre"] = txtNombre.Text;
                Session["Apellido"] = txtApellido.Text;

                // Redireccionamos al Destino2.aspx
                Response.Redirect("Destino2.aspx");
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error:" + ex.Message;
            }
        }
    }
}