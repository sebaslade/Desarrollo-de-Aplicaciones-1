using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyVentas_BL;
using OfficeOpenXml; //  EPPlus

namespace ProyVentas_GUI
{
    public partial class frmListadosExcel : Form
    {
        // Instancias
        ProveedorBL objProveedorBL = new ProveedorBL();

        public frmListadosExcel()
        {
            InitializeComponent();
        }

        private void frmListadosExcel_Load(object sender, EventArgs e)
        {
            MostrarControles(false);
            // Manejamos la licencia de EPPlus
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void MostrarControles(Boolean valor)
        {
            pcbImagen.Visible = valor;
            lblMensaje.Visible = valor;
            prgBar.Visible = valor;
        }

        private void btnListarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo plantilla del reporte.
                // Asegurate que la ruta exista en tu equipo y que el archivo plantilla este dentro de la ruta
                String rutaarchivo = @"C:\ReportesExcel\ListadoProveedores.xlsx";
                // Obtenemos los proveedores
                DataTable dtProveedores = new DataTable();
                dtProveedores = objProveedorBL.ListarProveedor();
                // Definimos la fila de inicio del reporte
                Int16 fila1 = 5;

                // Creamos una instancia de ExcelPackage en base al archivo plantilla...

                using (var pck = new ExcelPackage(new FileInfo(rutaarchivo)))
                {

                    // Indicamos en que hoja de la plantilla se implementara el reporte
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                    //Escribimos en las celdas los datos de los proveedores
                    foreach (DataRow drProveedor in dtProveedores.Rows)
                    {
                        ws.Cells[fila1, 1].Value = drProveedor["Cod_prv"].ToString();
                        ws.Cells[fila1, 2].Value = drProveedor["Raz_Soc_prv"].ToString();
                        ws.Cells[fila1, 3].Value = drProveedor["Dir_prv"].ToString();
                        ws.Cells[fila1, 4].Value = drProveedor["Tel_prv"].ToString();
                        ws.Cells[fila1, 5].Value = drProveedor["Departamento"].ToString() + "-" +
                                                                  drProveedor["Provincia"].ToString() + "-" +
                                                                  drProveedor["Distrito"].ToString();
                        ws.Cells[fila1, 6].Value = drProveedor["Rep_ven"].ToString();
                        fila1 += 1;
                    }

                    //Modificamos el ancho de las columnas
                    ws.Column(1).Width = 30;
                    ws.Column(2).Width = 50;
                    ws.Column(3).Width = 90;
                    ws.Column(4).Width = 40;
                    ws.Column(5).Width = 45;
                    ws.Column(6).Width = 45;

                    // Creamos el nombre asociado al usuario logueado....
                    String filename = "ListadoProveedores_" + clsCredenciales.Usuario + ".xlsx";
                    // Creamos el nuevo archivo...
                    FileStream fs = new FileStream(@"C:\ReportesExcel\" + filename, FileMode.Create);
                    pck.SaveAs(fs);

                    // Destruimos las instancias....
                    pck.Dispose();
                    fs.Dispose();

                    // Enviamos el mensaje al usuario de conformidad de creacion del archivo Excel....
                    MessageBox.Show("El archivo :" + filename + " se ha generado con exito.", "Mensaje",
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
