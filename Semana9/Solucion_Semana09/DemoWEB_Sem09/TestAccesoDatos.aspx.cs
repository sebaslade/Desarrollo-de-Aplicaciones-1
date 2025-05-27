using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem09
{
    public partial class TestAccesoDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                try
                {
                    // Creamos una instancia de la clase clsConsultas
                    clsConsultas objConsultas = new clsConsultas();

                    // Cargar el cbo1, con codigo y razon social de clientes...
                    String strSQL = "SELECT cod_cli, raz_soc_cli FROM vw_VistaClientes";
                    cbo1.DataSource = objConsultas.EjecutaSelect(strSQL);
                    cbo1.DataValueField = "cod_cli";
                    cbo1.DataTextField = "raz_soc_cli";
                    cbo1.DataBind();

                    // Cargamos cbo2 con codigo y razon social de proveedores
                    strSQL = "SELECT cod_prv, raz_soc_prv FROM vw_VistaProveedores ORDER BY raz_soc_prv";
                    cbo2.DataSource = objConsultas.EjecutaSelect(strSQL);
                    cbo2.DataValueField = "cod_prv";
                    cbo2.DataTextField = "raz_soc_prv";
                    cbo2.DataBind();

                    // Cargamos la grilla con codigo, nombre, apellido y sueldo de vendedores
                    grv1.DataSource = objConsultas.EjecutaSelect("SELECT cod_ven, ape_ven, nom_ven, sue_ven FROM Tb_Vendedor ORDER BY ape_ven");
                    grv1.DataBind();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            // Mostramos el codigo del cliente seleccionado en el lblCod1
            lblcod1.Text = cbo1.SelectedValue.ToString();
        }

        protected void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcod2.Text = cbo2.SelectedValue.ToString();
        }
    }
}