using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BL;
using LeonComputing_BE;

namespace LeonComputing_GUI
{
    public partial class AsociadoMan03 : Form
    {
        AsociadoBL objAsociadoBL = new AsociadoBL();
        AsociadoBE objAsociadoBE = new AsociadoBE();
        EmpresaBL objEmpresaBL = new EmpresaBL();
        Boolean blnCambio;
        Byte[] FotoOriginal;

        public AsociadoMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void AsociadoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objAsociadoBE = objAsociadoBL.ConsultarAsociado(this.Codigo);
                DataTable dt = objEmpresaBL.ListarEmpresa();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_Empresa"] = 0;
                dr["Razon_Social"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEmpresa.DataSource = dt;
                cboEmpresa.ValueMember = "Id_Empresa";
                cboEmpresa.DisplayMember = "Razon_Social";


                lblCod.Text = objAsociadoBE.Cod_asociado;
                txtApePaterno.Text = objAsociadoBE.Ape_paterno;
                txtApeMaterno.Text = objAsociadoBE.Ape_materno;
                txtDireccion.Text = objAsociadoBE.Dir_aso;
                txtNombres.Text = objAsociadoBE.Nom_aso;
                mskDNI.Text = objAsociadoBE.Dni;
                txtTel.Text = objAsociadoBE.Tlf_celular;
                txtTelDom.Text = objAsociadoBE.Tlf_domicilio;
                txtCorreo.Text = objAsociadoBE.Correo;
                cboEmpresa.SelectedValue = objAsociadoBE.Id_Empresa.ToString();
                chkEstado.Checked = Convert.ToBoolean(objAsociadoBE.Est_aso);


                if (objAsociadoBE.foto == null || objAsociadoBE.foto.Length == 0)
                {
                    pcbFoto.Image = null;

                }
                else // Pero si tiene foto
                {
                    MemoryStream fotoStream = new MemoryStream(objAsociadoBE.foto);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original , por si no se hace cambios...
                    FotoOriginal = objAsociadoBE.foto;
                }

                String Id_Ubigeo = objAsociadoBE.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
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

                objAsociadoBE.Cod_asociado = lblCod.Text;
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
                objAsociadoBE.Est_aso = Convert.ToInt16(chkEstado.Checked);

                objAsociadoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Si cambio la foto...
                if (blnCambio == true)
                {
                    objAsociadoBE.foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objAsociadoBE.foto = FotoOriginal;
                }
                if (objAsociadoBL.ActualizarAsociado(objAsociadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo correctamente, contacte con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en la categoria.
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    blnCambio = true;
                }
                else // de lo contrario la variable blnCambio se mantiene en falso
                {
                    blnCambio = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
