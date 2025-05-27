﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class ProveedorMan02 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();

        public ProveedorMan02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14","01","01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa,String IdProv,String IdDist)
        {
            // Codifique
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
                //Codifique
                // Validamos que este la razon social
                if(txtRS.Text.Trim() == String.Empty)
                {
                    throw new Exception("La razón social es obligatoria");
                }
                // Validamos que el RUC este lleno
                if(mskRuc.MaskFull == false)
                {
                    throw new Exception("El RUC debe tener 11 caracteres");
                }
                
                // Pasamos los valores a las propiedades de la instancia...
                objProveedorBE.Raz_soc_prv = txtRS.Text.Trim();
                objProveedorBE.Dir_prv = txtDir.Text.Trim();
                objProveedorBE.Tel_prv = txtTel.Text.Trim();
                objProveedorBE.Ruc_prv = mskRuc.Text.Trim();
                objProveedorBE.Dir_prv = txtDir.Text.Trim();
                objProveedorBE.Rep_ven = txtRepVen.Text.Trim();

                // Recuerde que el IdUbigeo es la concatenacion de los valores del Id Departamento,
                // Id Provincia y Id Distrito seleccionados desde los respectivos combos
                objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                // Se asignara por ahora al usuario jleon como usuario de registro
                objProveedorBE.Usu_Registro = clsCredenciales.Usuario;
                objProveedorBE.Est_prv = Convert.ToInt16(chkEstado.Checked);
                if(objProveedorBL.InsertarProveedor(objProveedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro. Contacte con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
