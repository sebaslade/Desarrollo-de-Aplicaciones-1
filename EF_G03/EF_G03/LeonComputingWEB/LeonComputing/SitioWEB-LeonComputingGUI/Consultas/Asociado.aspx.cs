using LeonComputing_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_LeonComputingGUI.Consultas
{
    public partial class Asociado : System.Web.UI.Page
    {
        AsociadoBL objAsociadoBL = new AsociadoBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Page.IsPostBack == false)
                {
                    CargarAsociados("");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error : " + ex.Message;
                PopMensaje.Show();
            }
        }

        private void CargarAsociados(string strFiltro)
        {
            System.Threading.Thread.Sleep(2000);

            if (strFiltro == String.Empty)
            {
                //Mostramos todos los vendedores....
                grvAsociados.DataSource = objAsociadoBL.ListarAsociado();
            }
            else
            {
                grvAsociados.DataSource =
                    objAsociadoBL.ListarAsociado().Where(miAsociado => miAsociado.Cod_asociado.Contains(strFiltro)).ToList();
            }

            grvAsociados.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAsociados(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
            }
        }

        protected void grvAsociados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Codifique
            // Para la paginacion en Gridview...
            grvAsociados.PageIndex = e.NewPageIndex;
            CargarAsociados(txtFiltro.Text);
        }
    }
}