using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregamos
using LeonComputing_BL;

namespace SitioWEB_LeonComputingGUI.Consultas
{
    public partial class Curso : System.Web.UI.Page
    {
        CursoBL objCursoBL = new CursoBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Page.IsPostBack == false)
                {
                    CargarDificultades("");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error : " + ex.Message;
                PopMensaje.Show();
            }
        }

        private void CargarDificultades(string strFiltro)
        {
            System.Threading.Thread.Sleep(2000);

            if (strFiltro == String.Empty)
            {
                //Mostramos todos los vendedores....
                grvCursos.DataSource = objCursoBL.ListarCurso();
            }
            else
            {
                grvCursos.DataSource =
                    objCursoBL.ListarCurso().Where(miCurso => miCurso.nivel_dificultad.Contains(strFiltro)).ToList();
            }

            grvCursos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDificultades(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
            }
        }

        protected void grvCursos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Codifique
            // Para la paginacion en Gridview...
            grvCursos.PageIndex = e.NewPageIndex;
            CargarDificultades(txtFiltro.Text);
        }
    }
}