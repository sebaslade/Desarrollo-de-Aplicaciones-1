using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BL;

namespace LeonComputing_GUI
{
    public partial class AsociadoMan01 : Form
    {
        AsociadoBL objAsociadoBL = new AsociadoBL();
        DataView dtv;

        public AsociadoMan01()
        {
            InitializeComponent();
        }

        private void AsociadoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objAsociadoBL.ListarAsociado());
            dtv.RowFilter = "ape_paterno LIKE '%" + strFiltro + "%' OR ape_materno LIKE '%" + strFiltro + "%' OR cod_asociado LIKE '%" + strFiltro + "%' OR dni LIKE '%" + strFiltro + "%' OR nombres LIKE '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AsociadoMan02 objMan02 = new AsociadoMan02();
                objMan02.ShowDialog();

                dtv = new DataView(objAsociadoBL.ListarAsociado());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AsociadoMan03 objMan03 = new AsociadoMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                dtv = new DataView(objAsociadoBL.ListarAsociado());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
