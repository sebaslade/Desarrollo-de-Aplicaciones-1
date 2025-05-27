using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;

namespace SitioWEB_VentasGUI.Consultas
{
    public partial class WebGraficosFacturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Page.IsPostBack == false)
                {
                    FacturaBL objFacturaBL = new FacturaBL();

                    grvFacturacion.DataSource = objFacturaBL.ListarFacturacionAnual();
                    grvFacturacion.DataBind();

                    grafTotales.Series.Add("Totales");
                    grafTotales.Series["Totales"].Points.DataBindXY(objFacturaBL.ListarFacturacionAnual(), "Año",objFacturaBL.ListarFacturacionAnual(),"TotalAnual");
                    grafTotales.Series["Totales"].IsValueShownAsLabel = true;
                    grafTotales.Series["Totales"].LabelFormat = "c"; // formato monetario

                    grafCantidad.Series.Add("Cantidades");
                    grafCantidad.Series["Cantidades"].Points.DataBindXY(objFacturaBL.ListarFacturacionAnual(), "Año",objFacturaBL.ListarFacturacionAnual(), "CantFacturas");
                    grafCantidad.Series["Cantidades"].IsValueShownAsLabel = true;
                    grafCantidad.Series["Cantidades"].LabelFormat = "n"; // formato numerico
                }
            }
            catch (Exception ex) 
            { 
                lblMensaje.Text = ex.Message;
            }
        }
    }
}