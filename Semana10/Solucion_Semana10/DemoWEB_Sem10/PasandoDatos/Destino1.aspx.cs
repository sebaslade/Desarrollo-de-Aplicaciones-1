using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.PasandoDatos
{
    public partial class Destino1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    lblNombre.Text = Request.QueryString["P1"];
                    lblApellido.Text = Request.QueryString["P2"];
                }
            }
            catch(Exception ex)
            { 
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}