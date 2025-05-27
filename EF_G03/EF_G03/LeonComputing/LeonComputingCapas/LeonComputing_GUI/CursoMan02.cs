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
    public partial class CursoMan02 : Form
    {
        EspecialidadBL objEspecialidadBL = new EspecialidadBL();
        CursoBE objCursoBE = new CursoBE();
        CursoBL objCursoBL = new CursoBL();
        public CursoMan02()
        {
            InitializeComponent();
        }

        private void CursoMan02_Load(object sender, EventArgs e)
        {

            DataTable dtEspecialidad = objEspecialidadBL.ListarEspecialidades();
            DataRow drEspecialidad;
            drEspecialidad = dtEspecialidad.NewRow();
            drEspecialidad["IdEspecialidad"] = 0;
            drEspecialidad["DescEspecialidad"] = "--Seleccione--";
            dtEspecialidad.Rows.InsertAt(drEspecialidad, 0);
            cboEspecialidad.DataSource = dtEspecialidad;
            cboEspecialidad.DisplayMember = "DescEspecialidad";
            cboEspecialidad.ValueMember = "IdEspecialidad";

            DataTable dtDificultad = objCursoBL.ListarCurso();
            List<DataRow> uniqueDificultades = new List<DataRow>();
            HashSet<string> seenDificultades = new HashSet<string>();
            foreach (DataRow row in dtDificultad.Rows)
            {
                string nivelDificultad = row["nivel_dificultad"].ToString();
                if (!seenDificultades.Contains(nivelDificultad))
                {
                    seenDificultades.Add(nivelDificultad);
                    uniqueDificultades.Add(row);
                }
            }

            DataTable dtUniqueDificultad = dtDificultad.Clone();
            foreach (DataRow row in uniqueDificultades)
            {
                dtUniqueDificultad.ImportRow(row);
            }

            DataRow drDificultad = dtUniqueDificultad.NewRow();
            drDificultad["cod_curso"] = 0;
            drDificultad["nivel_dificultad"] = "--Seleccione--";
            dtUniqueDificultad.Rows.InsertAt(drDificultad, 0);

            cboDificultad.DataSource = dtUniqueDificultad;
            cboDificultad.DisplayMember = "nivel_dificultad";
            cboDificultad.ValueMember = "cod_curso";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCurso.Text.Trim() == String.Empty)
                {
                    throw new Exception("El curso debe tener un nombre");
                }
                if (cboDificultad.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una dificultad");
                }
                if (cboEspecialidad.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una especialidad");
                }

                objCursoBE.descripcion = txtCurso.Text.Trim();
                objCursoBE.horas_teoria = Convert.ToInt16(textHora_Teorica.Text);
                objCursoBE.horas_practica = Convert.ToInt16(textHora_Practica.Text);
                objCursoBE.nivel_dificultad = cboDificultad.Text.Trim();
                objCursoBE.comentarios = txtComentarios.Text.Trim();
                objCursoBE.idEspecialidad = Convert.ToInt16(cboEspecialidad.SelectedValue);
                objCursoBE.Usu_registro = clsCredenciales.Usuario;
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
                if (objCursoBL.InsertarCurso(objCursoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el curso correctamente, Contacte con IT");
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

        private void textHora_Teorica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
