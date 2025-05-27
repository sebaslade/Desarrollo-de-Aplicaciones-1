using ProyVentas_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_VentasGUI.Consultas
{
    public partial class WebListarVendedores : System.Web.UI.Page
    {
        VendedorBL objVendedorBL = new VendedorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    CargarDatos("");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error : " + ex.Message;
                PopMensaje.Show();
            }
        }

        private void CargarDatos(string strFiltro)
        {
            // Codifique
            System.Threading.Thread.Sleep(2000);

            if (strFiltro == String.Empty) 
            {
                // mostramos todos los vendedores...
                grvVendedores.DataSource = objVendedorBL.ListarVendedor();
            }
            else
            {
                grvVendedores.DataSource = objVendedorBL.ListarVendedor().Where(miVendedor => miVendedor.Ape_ven.Contains(strFiltro)).ToList();
            }
            grvVendedores.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
            }
        }

        protected void grvVendedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Para la paginacion en Gridview
            grvVendedores.PageIndex = e.NewPageIndex;
            CargarDatos(txtFiltro.Text);
        }
    }
}