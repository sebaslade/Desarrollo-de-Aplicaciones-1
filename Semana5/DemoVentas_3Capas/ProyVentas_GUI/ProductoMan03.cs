using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyVentas_BE;
using ProyVentas_BL;
namespace ProyVentas_GUI
{
    public partial class ProductoMan03 : Form
    {
        // Instancias...
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ProductoMan03()
        {
            InitializeComponent();
        }

        // Propiedad que recibe el codigo del producto que se actualizara, enviado
        // desde el ProductoMan01

        public String Codigo { get; set; }

        private void ProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...
                DataTable dt = objCategoriaBL.ListarCategoria();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_Cat"] = 0;
                dr["Des_cat"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboCategoria.DataSource = dt;
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Des_cat";

                dt = objUnidadMedidaBL.ListarUM();
                dr = dt.NewRow();
                dr["Id_UM"] = 0;
                dr["Des_UM"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.ValueMember = "Id_UM";
                cboUM.DisplayMember = "Des_UM";

                // Codifique                
                // mostramos los datos del producto
                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);

                lblCodigo.Text = objProductoBE.Cod_pro;
                txtDescripcion.Text = objProductoBE.Des_pro;
                txtPrecio.Text = objProductoBE.Pre_pro.ToString();
                txtStkAct.Text = objProductoBE.Stk_act.ToString();
                txtStkMin.Text = objProductoBE.Stk_min.ToString();

                cboCategoria.SelectedValue = objProductoBE.Id_Cat.ToString();
                cboUM.SelectedValue = objProductoBE.Id_UM.ToString();

                if(objProductoBE.Importado == 1)
                {
                    optImportado.Checked = true;
                }
                else
                {
                    optNacional.Checked = true;
                }

                chkActivo.Checked = Convert.ToBoolean(objProductoBE.Est_pro);
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
                if (txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }
                if (cboUM.SelectedIndex == 0 || cboCategoria.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar categoria y unidad de medida correctas");
                }

                objProductoBE.Cod_pro = lblCodigo.Text;
                objProductoBE.Des_pro = txtDescripcion.Text.Trim();
                objProductoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text);
                objProductoBE.Stk_act = Convert.ToInt16(txtStkAct.Text);
                objProductoBE.Stk_min = Convert.ToInt16(txtStkMin.Text);
                objProductoBE.Est_pro = Convert.ToInt16(chkActivo.Checked);
                objProductoBE.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);
                objProductoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);

                //Origen
                if (optImportado.Checked == true)
                {
                    objProductoBE.Importado = 1;
                }
                else if (optNacional.Checked == true)
                {
                    objProductoBE.Importado = 0;
                }
                else
                {
                    throw new Exception("Debe seleccionar un origen");
                }

                objProductoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                //Actualizar el producto
                if (objProductoBL.ActualizarProducto(objProductoBE) == true)
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
