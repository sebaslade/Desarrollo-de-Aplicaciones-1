using LeonComputing_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonComputing_GUI
{
    public partial class CursoMan01 : Form
    {

        CursoBL objCursoBL = new CursoBL();
        DataView dtv;
        public CursoMan01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(string CurFiltro)
        {
            dtv = new DataView(objCursoBL.ListarCurso());
            dtv.RowFilter = "nivel_dificultad LIKE '%" + CurFiltro + "%'";
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoMan02 objMan02 = new CursoMan02();
                objMan02.ShowDialog();

                dtv = new DataView(objCursoBL.ListarCurso());
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
                CursoMan03 objForm03 = new CursoMan03();
                objForm03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objForm03.ShowDialog();

                dtv = new DataView(objCursoBL.ListarCurso());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
