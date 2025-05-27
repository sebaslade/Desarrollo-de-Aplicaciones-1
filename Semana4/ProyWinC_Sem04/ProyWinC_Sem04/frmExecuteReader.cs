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
    public partial class frmExecuteReader : Form
    {
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("Server=DESKTOP-OQA5P2T\\MSSQLSEBASTIAN;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();

        public frmExecuteReader()
        {
            InitializeComponent();
        }
       

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cmd.Parameters.Clear();

                // Abrir conexion y ejecutar
                cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                // Consumimos el dtr
                lstProductos.Items.Clear();
                while(dtr.Read())
                {
                    lstProductos.Items.Add(dtr["Des_pro"].ToString());
                }
                dtr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open )
                {
                    cnx.Close();

                }

            }


        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();

                // Abrir conexion y ejecutar
                cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                // Consumimos el dtr
                lstProveedores.Items.Clear();
                while (dtr.Read())
                {
                    lstProveedores.Items.Add(dtr["Raz_soc_prv"].ToString() + "-" + dtr["Dir_prv"].ToString());
                }
                dtr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();

                }

            }
        }
    }
}
