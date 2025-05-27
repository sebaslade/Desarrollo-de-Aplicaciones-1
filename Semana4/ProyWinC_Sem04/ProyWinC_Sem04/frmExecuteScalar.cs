using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar..
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmExecuteScalar : Form
    {
        // Creamos las instancias ...
        SqlConnection cnx = new SqlConnection("Server=DESKTOP-OQA5P2T\\MSSQLSEBASTIAN;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();

        public frmExecuteScalar()
        {
            InitializeComponent();
        }

        private void btnObtenerMaximoPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaximoPrecioProducto";
                cmd.Parameters.Clear();
                
                // Abrir la conexion y ejecutamos
                cnx.Open();
                MessageBox.Show("El maximo precio de producto es " + cmd.ExecuteScalar(), "Resultado");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally // Finalmente ,Si la conexion esta abierta la cerramos
            {
                // Codifique
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void btnObtenerVentaAnual_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_VentaAnual";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@año", mskAño.Text);

                // Abrimos la conexión
                cnx.Open();
                Single sngVentas = Convert.ToSingle(cmd.ExecuteScalar());
                lblVentaAnual.Text = sngVentas.ToString("###.###.##0.00 soles");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            catch (Exception ex1)
            {

                MessageBox.Show("Error: " + ex1.Message, "Error");
            }
            finally // Finalmente ,si la conexion esta abierta la cerramos
            {
                // Codifique
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
