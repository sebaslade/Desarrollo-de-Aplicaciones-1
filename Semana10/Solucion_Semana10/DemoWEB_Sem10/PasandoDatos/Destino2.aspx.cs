using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.PasandoDatos
{
    public partial class Destino2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Mostramos el contenido de cada variable de sesion
                lblNombre.Text = Session["Nombre"].ToString();
                lblApellido.Text = Session["Apellido"].ToString();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error:" + ex.Message;
            }
        }
    }
}