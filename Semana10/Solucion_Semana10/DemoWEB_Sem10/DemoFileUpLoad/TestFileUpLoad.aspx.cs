using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoFileUpLoad
{
    public partial class TestFileUpLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                // Definir la ruta destino...
                String strRuta = Server.MapPath("/") + @"Documentos\";

                // Validamos que se envie el archivo
                if (ful1.HasFile == false)
                {
                    throw new Exception("Debes seleccionar un archivo antes de enviar");
                }

                // Si todo esta ok
                String strNombreArchivo = ful1.FileName;
                // Obtenemos la extension del archivo seleccionado
                String strExtension = Path.GetExtension(strNombreArchivo);
                // Analizamos si el archivo es Word o Excel
                if (strExtension == ".doc" || strExtension == ".docx" || strExtension == ".xls" || strExtension == ".xlsx")
                {
                    strRuta += strNombreArchivo;

                    // Enviamos el archivo al servidor
                    ful1.SaveAs(strRuta);

                    //Enviamos el mensajed e conformidad
                    lblMensaje1.ForeColor = Color.Blue;
                    lblMensaje1.Text = "Envio de archivo satisfactorio";
                }
                else
                {
                    throw new Exception("Formato de archivo incorrecto, solo se permite Word o Excel.");
                }
            }
            catch (Exception ex)
            {
                lblMensaje1.Text = "Error:" + ex.Message;
            }
        }

        protected void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                // Definir la ruta destino...
                String strRuta = Server.MapPath("/") + @"Documentos\";

                // Validamos la existencia del archivo
                if (ful2.HasFile == true)
                {
                    if(ful2.PostedFile.ContentLength <= 4200000)
                    {
                        // Construir la coleccion de extensiones permitidas
                        List<String> strListaExtensiones = new List<String>();
                        strListaExtensiones.Add(".jpg");
                        strListaExtensiones.Add(".jpeg");
                        strListaExtensiones.Add(".ico");
                        strListaExtensiones.Add(".gif");
                        strListaExtensiones.Add(".png");

                        // obtenemos la extension del archivo a postear
                        String strExtension = Path.GetExtension(ful2.FileName).ToLower();

                        // Validamos si la extension del archivo esta dentro de las extensiones permitidas..
                        if(strListaExtensiones.Contains(strExtension) == true)
                        {
                            // Enviamos el archivo
                            strRuta += ful2.FileName;
                            ful2.SaveAs(strRuta);

                            lblMensaje2.ForeColor = Color.Blue;
                            lblMensaje2.Text = "Archivo enviado con exito.";
                        }
                        else
                        {
                            throw new Exception("El archivo no tiene el formato correcto");
                        }
                    }
                    else
                    {
                        throw new Exception("El archivo sobrepasa los 4 MB.");
                    }
                }
                else
                {
                    throw new Exception("Debes seleccionar un archivo antes de enviar");
                }
            }
            catch (Exception ex)
            {
                lblMensaje2.ForeColor = Color.Red;
                lblMensaje2.Text = "Error:" + ex.Message;
            }
        }
    }
}