using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BE;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProductoMan02 : Form
    {
        // Instancias...
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ProductoMan02()
        {
            InitializeComponent();
        }

        private void ProductoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                // Cargar los combos
                DataTable dt = objCategoriaBL.ListarCategoria();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_Cat"] = 0;
                dr["Des_cat"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboCategoria.DataSource = dt;
                cboCategoria.DisplayMember = "Des_cat";
                cboCategoria.ValueMember = "Id_Cat";

                dt = objUnidadMedidaBL.ListarUM();
                dr = dt.NewRow();
                dr["Id_UM"] = 0;
                dr["Des_UM"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.DisplayMember = "Des_UM";
                cboUM.ValueMember = "Id_UM";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                if(txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }
                if(cboUM.SelectedIndex == 0 || cboCategoria.SelectedIndex == 0) 
                {
                    throw new Exception("Debe seleccionar categoria y unidad de medida correctas");
                }

                objProductoBE.Des_pro = txtDescripcion.Text.Trim();
                objProductoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text);
                objProductoBE.Stk_act = Convert.ToInt16(txtStkAct.Text);
                objProductoBE.Stk_min = Convert.ToInt16(txtStkMin.Text);
                objProductoBE.Est_pro = Convert.ToInt16(chkActivo.Checked);
                objProductoBE.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);
                objProductoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);

                //Origen
                if(optImportado.Checked == true)
                {
                    objProductoBE.Importado = 1;
                }
                else if(optNacional.Checked == true)
                {
                    objProductoBE.Importado = 0;
                }
                else
                {
                    throw new Exception("Debe seleccionar un origen");
                }

                objProductoBE.Usu_Registro = clsCredenciales.Usuario;

                //Insertamos el producto
                if(objProductoBL.InsertarProducto(objProductoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
