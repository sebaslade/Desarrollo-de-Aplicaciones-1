namespace LeonComputing_GUI
{
    partial class CursoMan03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoMan03));
            txtCurso = new TextBox();
            txtComentarios = new TextBox();
            label8 = new Label();
            cboDificultad = new ComboBox();
            optEjecutado = new RadioButton();
            optEnCurso = new RadioButton();
            optProgramado = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboEspecialidad = new ComboBox();
            textHora_Practica = new TextBox();
            textHora_Teorica = new TextBox();
            groupBoxAgregar = new GroupBox();
            lblCodigo = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            groupBoxAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // txtCurso
            // 
            txtCurso.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtCurso, "txtCurso");
            txtCurso.Name = "txtCurso";
            // 
            // txtComentarios
            // 
            txtComentarios.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtComentarios, "txtComentarios");
            txtComentarios.Name = "txtComentarios";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // cboDificultad
            // 
            cboDificultad.Cursor = Cursors.Hand;
            cboDificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDificultad.FormattingEnabled = true;
            resources.ApplyResources(cboDificultad, "cboDificultad");
            cboDificultad.Name = "cboDificultad";
            // 
            // optEjecutado
            // 
            resources.ApplyResources(optEjecutado, "optEjecutado");
            optEjecutado.Name = "optEjecutado";
            optEjecutado.TabStop = true;
            optEjecutado.UseVisualStyleBackColor = true;
            // 
            // optEnCurso
            // 
            resources.ApplyResources(optEnCurso, "optEnCurso");
            optEnCurso.Name = "optEnCurso";
            optEnCurso.TabStop = true;
            optEnCurso.UseVisualStyleBackColor = true;
            // 
            // optProgramado
            // 
            resources.ApplyResources(optProgramado, "optProgramado");
            optProgramado.Name = "optProgramado";
            optProgramado.TabStop = true;
            optProgramado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.Cursor = Cursors.Hand;
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            resources.ApplyResources(cboEspecialidad, "cboEspecialidad");
            cboEspecialidad.Name = "cboEspecialidad";
            // 
            // textHora_Practica
            // 
            textHora_Practica.Cursor = Cursors.IBeam;
            resources.ApplyResources(textHora_Practica, "textHora_Practica");
            textHora_Practica.Name = "textHora_Practica";
            textHora_Practica.KeyPress += textHora_Practica_KeyPress;
            // 
            // textHora_Teorica
            // 
            textHora_Teorica.Cursor = Cursors.IBeam;
            resources.ApplyResources(textHora_Teorica, "textHora_Teorica");
            textHora_Teorica.Name = "textHora_Teorica";
            textHora_Teorica.KeyPress += textHora_Teorica_KeyPress;
            // 
            // groupBoxAgregar
            // 
            groupBoxAgregar.Controls.Add(lblCodigo);
            groupBoxAgregar.Controls.Add(label7);
            groupBoxAgregar.Controls.Add(label5);
            groupBoxAgregar.Controls.Add(btnCancelar);
            groupBoxAgregar.Controls.Add(btnGrabar);
            groupBoxAgregar.Controls.Add(txtCurso);
            groupBoxAgregar.Controls.Add(txtComentarios);
            groupBoxAgregar.Controls.Add(label8);
            groupBoxAgregar.Controls.Add(cboDificultad);
            groupBoxAgregar.Controls.Add(optEjecutado);
            groupBoxAgregar.Controls.Add(optEnCurso);
            groupBoxAgregar.Controls.Add(optProgramado);
            groupBoxAgregar.Controls.Add(label6);
            groupBoxAgregar.Controls.Add(label3);
            groupBoxAgregar.Controls.Add(label4);
            groupBoxAgregar.Controls.Add(label2);
            groupBoxAgregar.Controls.Add(label1);
            groupBoxAgregar.Controls.Add(cboEspecialidad);
            groupBoxAgregar.Controls.Add(textHora_Practica);
            groupBoxAgregar.Controls.Add(textHora_Teorica);
            resources.ApplyResources(groupBoxAgregar, "groupBoxAgregar");
            groupBoxAgregar.Name = "groupBoxAgregar";
            groupBoxAgregar.TabStop = false;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(lblCodigo, "lblCodigo");
            lblCodigo.Name = "lblCodigo";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCancelar, "btnCancelar");
            btnCancelar.Name = "btnCancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Cursor = Cursors.Hand;
            resources.ApplyResources(btnGrabar, "btnGrabar");
            btnGrabar.Name = "btnGrabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // CursoMan03
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAgregar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoMan03";
            Load += CursoMan03_Load;
            groupBoxAgregar.ResumeLayout(false);
            groupBoxAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCurso;
        private TextBox txtComentarios;
        private Label label8;
        private ComboBox cboDificultad;
        private RadioButton optEjecutado;
        private RadioButton optEnCurso;
        private RadioButton optProgramado;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cboEspecialidad;
        private TextBox textHora_Practica;
        private TextBox textHora_Teorica;
        private GroupBox groupBoxAgregar;
        private Label lblCodigo;
        private Label label5;
        private Button btnCancelar;
        private Button btnGrabar;
    }
}