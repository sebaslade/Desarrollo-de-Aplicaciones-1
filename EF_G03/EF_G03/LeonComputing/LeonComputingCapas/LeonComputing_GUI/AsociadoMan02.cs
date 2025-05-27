using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BE;
using LeonComputing_BL;

namespace LeonComputing_GUI
{
    public partial class AsociadoMan02 : Form
    {
        AsociadoBL objAsociadoBL = new AsociadoBL();
        AsociadoBE objAsociadoBE = new AsociadoBE();
        EmpresaBL objEmpresaBL = new EmpresaBL();

        public AsociadoMan02()
        {
            InitializeComponent();
        }

        private void AsociadoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objEmpresaBL.ListarEmpresa();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_Empresa"] = 0;
                dr["Razon_Social"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEmpresa.DataSource = dt;
                cboEmpresa.DisplayMember = "Razon_Social";
                cboEmpresa.ValueMember = "Id_Empresa";

                //Cargar Ubigeo
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApeMaterno.Text.Trim() == String.Empty || txtApePaterno.Text.Trim() == String.Empty || txtNombres.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre, el apellido materno y paterno son obligatorios");
                }
                if (cboEmpresa.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una empresa");
                }
                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 números");
                }

                if (!(txtCorreo.Text.Trim().EndsWith("@gmail.com") || txtCorreo.Text.Trim().EndsWith("@outlook.com") || txtCorreo.Text.Trim().EndsWith("@hotmail.com")))
                {
                    throw new Exception("El correo debe terminar en '@gmail.com', '@outlook.com' o '@hotmail.com'.");
                }

                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                objAsociadoBE.Ape_paterno = txtApePaterno.Text.Trim();
                objAsociadoBE.Ape_materno = txtApeMaterno.Text.Trim();
                objAsociadoBE.Nom_aso = txtNombres.Text.Trim();
                objAsociadoBE.Dir_aso = txtDireccion.Text.Trim();
                objAsociadoBE.Dni = mskDNI.Text.Trim();
                objAsociadoBE.Tlf_domicilio = txtTelDom.Text.Trim();
                objAsociadoBE.Tlf_celular = txtTel.Text.Trim();
                objAsociadoBE.Correo = txtCorreo.Text.Trim();
                objAsociadoBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objAsociadoBE.Id_Empresa = Convert.ToInt16(cboEmpresa.SelectedValue);
                objAsociadoBE.Usu_registro = clsCredenciales.Usuario;
                objAsociadoBE.Est_aso = Convert.ToInt16(chkEstado.Checked);
                objAsociadoBE.foto = File.ReadAllBytes(openFileDialog1.FileName);
                if (objAsociadoBL.InsertarAsociado(objAsociadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro correctamente, Contacte con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != String.Empty)
            {
                pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
