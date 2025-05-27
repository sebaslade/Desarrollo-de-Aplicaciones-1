using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyVentas_BL;
using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class frmConsFacturasCliente : Form
    {
        FacturaBL objFacturaBL = new FacturaBL();
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public frmConsFacturasCliente()
        {
            InitializeComponent();
        }

        private void frmConsFacturasCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // Desactivamos la generacion de columnas automaticas del datagrid...
                dtgFacturas.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                // Obtener los datos del cliente
                objClienteBE = objClienteBL.ConsultarCliente(txtCod.Text.Trim());
                // Evaluamos el resultado de la consulta
                if(objClienteBE.Raz_soc_cli == null)
                {
                    // Si el cliente no existe...
                    LimpiarResultados();
                    throw new Exception("El cliente no existe");
                }
                else
                {
                    // Mostramos los datos del cliente...
                    lblRazSoc.Text = objClienteBE.Raz_soc_cli;
                    lblDir.Text = objClienteBE.Dir_cli;
                    lblTel.Text = objClienteBE.Tel_cli;
                    lblRuc.Text = objClienteBE.Ruc_cli;
                    lblUbicacion.Text = objClienteBE.Departamento + "-" + objClienteBE.Provincia + "-" + objClienteBE.Distrito;

                    // Mostramos el estado...
                    if(objClienteBE.Est_cli == 1)
                    {
                        lblEstado.Text = "Activo";
                    }
                    else
                    {
                        lblEstado.Text = "Inactivo";
                    }

                    //Mostramos la deuda
                    lblDeuda.Text = objClienteBE.Deuda.ToString("###,###,###.00 soles");

                    // Mostramos la facturación
                    dtgFacturas.DataSource = objFacturaBL.ListarFacturasClienteFechas(txtCod.Text.Trim(), dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                    lblRegistros.Text = dtgFacturas.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
              

        private void LimpiarResultados()
        {
            // Limpiamos los label  de resultado...
            foreach (Control miControl in this.Controls)
            {
                if (miControl.Name.StartsWith("lbl") == true)
                {
                    miControl.Text = String.Empty;
                }

            }
            // Limpiamos el datagridview
            dtgFacturas.DataSource = null;
            txtCod.SelectAll();
            txtCod.Focus();
        }
    }
}
