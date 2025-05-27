using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeonComputing_BE;
using LeonComputing_BL;

namespace SitioWEB_LeonComputingGUI.Consultas
{
    public partial class Evento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    EventoBL objEventoBL = new EventoBL();
                    List<PresupuestoMensual> presupuestoMensualList = objEventoBL.ListarPresupuestoMensual();

                    grvPresupuestoMensual.DataSource = presupuestoMensualList;
                    grvPresupuestoMensual.DataBind();

                    // Configuración del gráfico de Presupuesto
                    grafPresupuesto.Series.Clear();
                    grafPresupuesto.Series.Add("Total");
                    grafPresupuesto.Series["Total"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Column;
                    grafPresupuesto.Series["Total"].XValueType = System.Web.UI.DataVisualization.Charting.ChartValueType.String;
                    grafPresupuesto.ChartAreas[0].AxisX.LabelStyle.Angle = 45; // Opcional
                    grafPresupuesto.ChartAreas[0].AxisX.Interval = 1;
                    grafPresupuesto.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

                    foreach (var item in presupuestoMensualList)
                    {
                        grafPresupuesto.Series["Total"].Points.AddXY(item.Mes, item.Presupuesto);
                    }
                    grafPresupuesto.Series["Total"].IsValueShownAsLabel = true;
                    grafPresupuesto.Series["Total"].LabelFormat = "N2";

                    // Configuración del gráfico de Cupos
                    grafCupos.Series.Clear();
                    grafCupos.Series.Add("Cupos");
                    grafCupos.Series["Cupos"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Column;
                    grafCupos.Series["Cupos"].XValueType = System.Web.UI.DataVisualization.Charting.ChartValueType.String;
                    grafCupos.ChartAreas[0].AxisX.LabelStyle.Angle = 45; // Opcional
                    grafCupos.ChartAreas[0].AxisX.Interval = 1;
                    grafCupos.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

                    foreach (var item in presupuestoMensualList)
                    {
                        grafCupos.Series["Cupos"].Points.AddXY(item.Mes, item.Cupos);
                    }
                    grafCupos.Series["Cupos"].IsValueShownAsLabel = true;
                    grafCupos.Series["Cupos"].LabelFormat = "N0";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}