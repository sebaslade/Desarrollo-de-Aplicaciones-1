using System.Data;
using LeonComputing_BE;
using LeonComputing_BL;

namespace LeonComputing_GUI
{
    public partial class EventoMan01 : Form
    {
        EventoBL objEventoBL = new EventoBL();
        DataView dtv;
        public EventoMan01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objEventoBL.ListarEvento());
            dtv.RowFilter = "turno LIKE '%" + strFiltro + "%' OR descripcion  LIKE '%" + strFiltro + "%' OR descripcion LIKE '%" + strFiltro + "%' OR Razon_Social LIKE '%" + strFiltro + "%' OR frecuencia LIKE '%" + strFiltro + "%' OR direccion_evento LIKE '%" + strFiltro + "%'";
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
                EventoMan02 objMan02 = new EventoMan02();
                objMan02.ShowDialog();

                dtv = new DataView(objEventoBL.ListarEvento());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EventoMan03 objMan03 = new EventoMan03();
            objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objMan03.ShowDialog();

            dtv = new DataView(objEventoBL.ListarEvento());
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
