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
    public partial class frmUMedida : Form
    {

        SqlConnection cnx = new SqlConnection("Server = DESKTOP-OQA5P2T\\MSSQLSEBASTIAN; Database=VentasLeon;Integrated Security = true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;
        

        public frmUMedida()
        {
            InitializeComponent();
        }

        private void frmDistritos1_Load(object sender, EventArgs e)
        {
            try
            {
                // LLenamos el grid...
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación
                if(txtNomUM.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }

                // Codifique...
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarUM";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes", txtNomUM.Text);

                cnx.Open();
                cmd.ExecuteNonQuery();

                //Refrescar el datagridView
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }
        private void Listar()
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarUM";
            cmd.Parameters.Clear();

            DataSet dts = new DataSet();
            ada = new SqlDataAdapter(cmd);

            ada.Fill(dts, "Unidades");

            //Enlazamos el DataGrid al dataTable Unidades
            dtgUnidades.DataSource = dts.Tables["Unidades"];
            lblRegistros.Text = dtgUnidades.Rows.Count.ToString();
        }
    }
}
