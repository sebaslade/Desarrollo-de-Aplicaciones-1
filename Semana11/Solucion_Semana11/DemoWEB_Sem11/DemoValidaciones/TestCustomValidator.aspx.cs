using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoValidaciones
{
    public partial class TestCustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            // Validamos que todas las validaciones sean correctas
            if(Page.IsValid == true)
            {
                lblMensaje.Text = "Datos correctos";
            }
            else
            {
                lblMensaje.Text = "Datos incorrectos";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Validamos el codigo de afiliacion...
            if(txtCod.Text.StartsWith("A") && txtCod.Text.EndsWith("0"))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Validamos que el DNI tenga 8 caracteres
            if(txtDNI.Text.Length != 8)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}