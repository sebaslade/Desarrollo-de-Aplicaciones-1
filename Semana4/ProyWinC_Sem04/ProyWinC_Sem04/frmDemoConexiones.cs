using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmDemoConexiones : Form
    {
        // Agregue la conexion aqui...
        SqlConnection cnx = new SqlConnection("Server=DESKTOP-OQA5P2T\\MSSQLSEBASTIAN;Database=VentasLeon;Integrated Security=true");

        public frmDemoConexiones()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                // Abrimos la conexión y enviamos un mensaje...
                cnx.Open();
                MessageBox.Show("Conexión abierta con exito", "Conexion OK");

                // Manejamos los botones
                btnAbrir.Enabled = false;
                btnCerrar.Enabled = true;
            }
            catch (SqlException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message, "Error SQL");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error: " + ex2.Message, "Error Generico");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Codifique
            // Cerramos la conexión y enviamos mensaje
            cnx.Close();
            MessageBox.Show("Conexión cerrada con exito","Conexión cerrada");

            // Manejamos los botones
            btnAbrir.Enabled=true;
            btnCerrar.Enabled=false;
        }
    }
}
