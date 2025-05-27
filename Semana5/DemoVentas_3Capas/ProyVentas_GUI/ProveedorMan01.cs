using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Agregar...
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProveedorMan01 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv;
       
        public ProveedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            // Codifique
            // Construimos el objeto DataView dtv en base al DataTable devuelto por el metodo ListarProveedor
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objProveedorBL.ListarProveedor());
            dtv.RowFilter = "raz_soc_prv like '%" + strFiltro + "%'";
            dtgProveedor.DataSource = dtv;
            lblRegistros.Text = dtgProveedor.Rows.Count.ToString();
        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           try
           {
                //Codifique
                // Creamos la instancia de ProveedorMan02 y lo mostramos de manera modal
                ProveedorMan02 prov02 = new ProveedorMan02();
                prov02.ShowDialog();

                // Al retornar, refrescamos la vista y cargamos los datos para visualizar al proveedor agregado
                dtv = new DataView(objProveedorBL.ListarProveedor());
                CargarDatos(txtFiltro.Text.Trim());
           }
           catch (Exception ex)
           {
                MessageBox.Show("Error : " + ex.Message);
           }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                ProveedorMan03 prov03 = new ProveedorMan03();
                // Se toma el valor de la columna cero de la fila seleccionada en el datagridview
                prov03.Codigo = dtgProveedor.CurrentRow.Cells[0].Value.ToString();
                prov03.ShowDialog();

                // Al retornar, refrescamos la vista y cargamos los datos para ver los cambios del proveedor actualizado
                dtv = new DataView(objProveedorBL.ListarProveedor());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Codifique
            // Pasaremos al metodo CargarDatos el texto que se va escribiendo
            // en la caja de texto 
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
