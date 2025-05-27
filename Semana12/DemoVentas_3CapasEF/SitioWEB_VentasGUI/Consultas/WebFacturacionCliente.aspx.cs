using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;
using System.Data;
// Para la descarga Excel (no olvide instalar EPPlus)
//using System.IO;
//using OfficeOpenXml;
namespace SitioWEB_VentasGUI.Consultas
{
    
    public partial class WebFacturacionCliente : System.Web.UI.Page
    {
        // Instancias ...
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        FacturaBL objFacturaBL = new FacturaBL();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // Codifique
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulamos demora en la consulta de 2 segundos
                System.Threading.Thread.Sleep(2000);
                // Obtenemos los datos del cliente consultado
                objClienteBE = objClienteBL.ConsultarCliente(txtCod.Text.Trim());

                // Validamos la existencia del cliente
                if (objClienteBE.Cod_cli == String.Empty)
                {
                    LimpiarDatos(this);
                    // Mostramos el mensaje el el lblMensaje del panel y lanzamos el modal de mensajes
                    throw new Exception("Cliente no existe.");
                }
                else
                {
                    txtRazSoc.Text = objClienteBE.Raz_soc_cli;
                    txtDir.Text = objClienteBE.Dir_cli;
                    txtTel.Text = objClienteBE.Tel_cli;
                    txtUbicacion.Text = objClienteBE.Departamento + "-" + objClienteBE.Provincia + "-" + objClienteBE.Distrito;
                    txtRUC.Text = objClienteBE.Ruc_cli;
                    if (objClienteBE.Est_cli == 1)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else
                    {
                        txtEstado.Text = "Inactivo";
                    }
                    //Mostramos la deuda
                    txtDeuda.Text = Convert.ToSingle(objClienteBE.Deuda).ToString("C2");
                    // Mostramos las facturas
                    grvFacturas.DataSource = objFacturaBL.ListarFacturasClienteFechas(txtCod.Text.Trim(),
                     Convert.ToDateTime(txtFecIni.Text.Trim()), Convert.ToDateTime(txtFecFin.Text.Trim()));
                    grvFacturas.DataBind();
                    lblRegistros.Text = "Cantidad de facturas : " + grvFacturas.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }


        protected void LimpiarDatos(Control _control)
         {
            foreach (Control miControl in _control.Controls)
            {
               // Limpiamos los controles sin son textBox
                if (miControl is TextBox)
                {
                    TextBox miCaja = new TextBox();
                    miCaja = (TextBox)miControl;
                    miCaja.Text = String.Empty;
                }
                // Si el control tiene controles hijos, recórrelos también
                if (miControl.Controls.Count > 0)
                {
                    LimpiarDatos(miControl);
                }                    
            }
            // Limpiamos el GridView y lblRegistros
            grvFacturas.DataSource = null;
            grvFacturas.DataBind();
            lblRegistros.Text = "Registros : ";
        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique..
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }
    }
}