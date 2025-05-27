using LeonComputing_BE;
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
    public partial class CursoMan03 : Form
    {
        CursoBL objCursoBL = new CursoBL();
        CursoBE objCursoBE = new CursoBE();
        EspecialidadBL objEspecialidadBL = new EspecialidadBL();

        public CursoMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void textHora_Teorica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textHora_Practica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CursoMan03_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dtEspecialidad = objEspecialidadBL.ListarEspecialidades();
                DataRow drEspecialidad = dtEspecialidad.NewRow();
                drEspecialidad["IdEspecialidad"] = 0;
                drEspecialidad["DescEspecialidad"] = "--Seleccione--";
                dtEspecialidad.Rows.InsertAt(drEspecialidad, 0);
                cboEspecialidad.DataSource = dtEspecialidad;
                cboEspecialidad.DisplayMember = "DescEspecialidad";
                cboEspecialidad.ValueMember = "IdEspecialidad";

                DataTable dtCursos = objCursoBL.ListarCurso();
                DataTable dtDificultad = dtCursos.DefaultView.ToTable(true, "nivel_dificultad");

                DataRow drDificultad = dtDificultad.NewRow();
                drDificultad["nivel_dificultad"] = "--Seleccione--";
                dtDificultad.Rows.InsertAt(drDificultad, 0);

                cboDificultad.DataSource = dtDificultad;
                cboDificultad.DisplayMember = "nivel_dificultad";
                cboDificultad.ValueMember = "nivel_dificultad";

                objCursoBE = objCursoBL.ConsultarCurso(this.Codigo);

                lblCodigo.Text = objCursoBE.codCurso.ToString();
                txtCurso.Text = objCursoBE.descripcion.ToString();
                textHora_Teorica.Text = objCursoBE.horas_teoria.ToString();
                textHora_Practica.Text = objCursoBE.horas_practica.ToString();
                txtComentarios.Text = objCursoBE.comentarios.ToString();
                cboDificultad.SelectedValue = objCursoBE.nivel_dificultad.ToString();

                if (objCursoBE.estado_cur == 1)
                {
                    optProgramado.Checked = true;
                }
                else if (objCursoBE.estado_cur == 2)
                {
                    optEnCurso.Checked = true;
                }
                else if (objCursoBE.estado_cur == 3)
                {
                    optEjecutado.Checked = true;
                }

                cboEspecialidad.SelectedValue = objCursoBE.idEspecialidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objCursoBE.codCurso = lblCodigo.Text.Trim();
                objCursoBE.descripcion = txtCurso.Text.Trim();
                objCursoBE.horas_teoria = Convert.ToInt16(textHora_Teorica.Text);
                objCursoBE.horas_practica = Convert.ToInt16(textHora_Practica.Text);
                objCursoBE.nivel_dificultad = cboDificultad.Text.Trim();
                objCursoBE.comentarios = txtComentarios.Text.Trim();
                objCursoBE.idEspecialidad = Convert.ToInt16(cboEspecialidad.SelectedValue);
                if (optProgramado.Checked == true)
                {
                    objCursoBE.estado_cur = 1;
                }
                else if (optEnCurso.Checked == true)
                {
                    objCursoBE.estado_cur = 2;
                }
                else if (optEjecutado.Checked == true)
                {
                    objCursoBE.estado_cur = 3;
                }
                objCursoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                if (objCursoBL.ActualizarCurso(objCursoBE) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

