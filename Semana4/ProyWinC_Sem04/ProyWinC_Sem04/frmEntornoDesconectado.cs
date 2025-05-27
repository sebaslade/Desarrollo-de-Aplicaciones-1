using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyWinC_Sem04
{
    public partial class frmEntornoDesconectado : Form
    {
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("Server = DESKTOP-OQA5P2T\\MSSQLSEBASTIAN; Database=VentasLeon;Integrated Security = true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;

        public frmEntornoDesconectado()
        {
            InitializeComponent();
        }

        private void frmEntornoDesconectado_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";
                cmd.Parameters.Clear();

                //Configuracion del DataSet
                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Clientes");

                //Enlazamos el combo al datatable Clientes
                cboCliente.DataSource = dts.Tables["Clientes"];
                cboCliente.ValueMember = "Cod_cli";
                cboCliente.DisplayMember = "Raz_soc_cli";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                lblCod1.Text = cboCliente.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();

                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Proveedores");

                dtgProveedores.DataSource = dts.Tables["Proveedores"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
