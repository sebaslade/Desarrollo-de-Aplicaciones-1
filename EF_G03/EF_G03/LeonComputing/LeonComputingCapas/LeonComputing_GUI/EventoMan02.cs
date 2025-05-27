using LeonComputing_BL;
using LeonComputing_BE;
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
    public partial class EventoMan02 : Form
    {
        EventoBL objEventoBL = new EventoBL();
        EventoBE objEventosBE = new EventoBE();
        ExpositorBL objExpositorBL = new ExpositorBL();
        EmpresaBL objEmpresaBL = new EmpresaBL();
        CursoBL objCursoBL = new CursoBL();
        public EventoMan02()
        {
            InitializeComponent();
        }

        private void EventoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtExpositor = objExpositorBL.ListarExpositor();
                DataRow drExpositor;
                drExpositor = dtExpositor.NewRow();
                drExpositor["Id_Expositor"] = 0;
                drExpositor["Nombre"] = "--Seleccione--";
                drExpositor["Apellido_paterno"] = "";
                dtExpositor.Rows.InsertAt(drExpositor, 0);
                cboExpositor.DataSource = dtExpositor;
                cboExpositor.DisplayMember = "Nombre";
                cboExpositor.ValueMember = "Id_Expositor";

                foreach (DataRow row in dtExpositor.Rows)
                {
                    row["Nombre"] = row["Nombre"] + " " + row["Apellido_paterno"];
                }

                DataTable dtFrecuencia = objEventoBL.ListarEvento();
                List<DataRow> uniqueFrecuencia = new List<DataRow>();
                HashSet<string> seenFrecuencia = new HashSet<string>();
                foreach (DataRow row in dtFrecuencia.Rows)
                {
                    string tiempoFrecuencia = row["frecuencia"].ToString();
                    if (!seenFrecuencia.Contains(tiempoFrecuencia))
                    {
                        seenFrecuencia.Add(tiempoFrecuencia);
                        uniqueFrecuencia.Add(row);
                    }
                }

                DataTable dtUniqueFrecuencia = dtFrecuencia.Clone();
                foreach (DataRow row in uniqueFrecuencia)
                {
                    dtUniqueFrecuencia.ImportRow(row);
                }

                DataRow drFrecuencia = dtUniqueFrecuencia.NewRow();
                drFrecuencia["id_frecuencia"] = 0;
                drFrecuencia["frecuencia"] = "--Seleccione--";
                dtUniqueFrecuencia.Rows.InsertAt(drFrecuencia, 0);
                cboFrecuencia.DataSource = dtUniqueFrecuencia;
                cboFrecuencia.DisplayMember = "frecuencia";
                cboFrecuencia.ValueMember = "id_frecuencia";
        

                DataTable dtCurso = objCursoBL.ListarCurso();
                DataRow drCurso;
                drCurso = dtCurso.NewRow();
                drCurso["Cod_Curso"] = 0;
                drCurso["Descripcion"] = "--Seleccione--";
                dtCurso.Rows.InsertAt(drCurso, 0);
                cboCurso.DataSource = dtCurso;
                cboCurso.DisplayMember = "Descripcion";
                cboCurso.ValueMember = "Cod_Curso";

                DataTable dtEmpresa = objEmpresaBL.ListarEmpresa();
                DataRow drEmpresa;
                drEmpresa = dtEmpresa.NewRow();
                drEmpresa["Id_Empresa"] = 0;
                drEmpresa["Razon_Social"] = "--Seleccione--";
                dtEmpresa.Rows.InsertAt(drEmpresa, 0);
                cboEmpresa.DataSource = dtEmpresa;
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
                if (cboEmpresa.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una empresa");
                }
                if (cboExpositor.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar un expositor");
                }
                if (cboFrecuencia.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una frecuencia");
                }
                if (!optManana.Checked && !optTarde.Checked && !optNoche.Checked)
                {
                    throw new Exception("Debe seleccionar un turno (mañana, tarde o noche)");
                }


                objEventosBE.id_empresa = Convert.ToInt16(cboEmpresa.SelectedValue);
                objEventosBE.id_frecuencia = Convert.ToInt16(cboFrecuencia.SelectedValue.ToString()); 
                objEventosBE.presupuesto_requerido = Convert.ToDecimal(txtPresu.Text.Trim());
                objEventosBE.dirección_evento = txtDireccion.Text.Trim();
                objEventosBE.cupos_programados = Convert.ToInt16(txtCupos.Text.Trim());
                objEventosBE.id_Expositor = cboExpositor.SelectedValue.ToString();
                objEventosBE.id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objEventosBE.cod_curso = cboCurso.SelectedValue.ToString();
                objEventosBE.fecha_inicio = dtpFecInicio.Value.Date;
                objEventosBE.fecha_fin = dtpFecFin.Value.Date;
                objEventosBE.usu_registro = clsCredenciales.Usuario;
                objEventosBE.estado_eve = Convert.ToInt16(chkEstado.Checked);

                if (optManana.Checked == true)
                {
                    objEventosBE.id_turno = 0;
                }
                else if (optTarde.Checked == true)
                {
                    objEventosBE.id_turno = 1;
                }
                else if (optNoche.Checked == true)
                {
                    objEventosBE.id_turno = 2 ;
                }
                if (objEventoBL.InsertarEvento(objEventosBE) == true)
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
    }
}
