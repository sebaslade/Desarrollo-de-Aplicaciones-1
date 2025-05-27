using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaCliente : Form
    {
       
        public frmConsultaCliente()
        {
            InitializeComponent();
        }
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("Server = DESKTOP-OQA5P2T\\MSSQLSEBASTIAN; Database=VentasLeon;Integrated Security = true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique
            try
            {
                if(e.KeyChar == 13)
                {
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarCliente";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text.Trim());

                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if(dtr.HasRows == true)
                    {
                        dtr.Read();
                        lblRaz.Text = dtr["Raz_soc_cli"].ToString();
                        lblDir.Text = dtr["Dir_cli"].ToString();
                        lblRuc.Text = dtr["Ruc_cli"].ToString();
                        lblTel.Text = dtr["Tel_cli"].ToString() ;
                        Single sngDeuda = Convert.ToSingle(dtr["Deuda"]);
                        lblDeuda.Text = sngDeuda.ToString("###,###,##0.00 soles");
                    }
                    else
                    {
                        MessageBox.Show("Cliente no existe", "Aviso");
                        // limpias los labels
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }
    }
}
