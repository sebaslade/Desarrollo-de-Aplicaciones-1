namespace LeonComputing_GUI
{
    partial class CursoMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoMan02));
            btnCerrar = new Button();
            btnGrabar = new Button();
            groupBoxAgregar = new GroupBox();
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
            groupBoxAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.ImeMode = ImeMode.NoControl;
            btnCerrar.Location = new Point(330, 362);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(77, 31);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrabar.ImeMode = ImeMode.NoControl;
            btnGrabar.Location = new Point(235, 362);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(77, 31);
            btnGrabar.TabIndex = 10;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // groupBoxAgregar
            // 
            groupBoxAgregar.Controls.Add(btnCerrar);
            groupBoxAgregar.Controls.Add(txtCurso);
            groupBoxAgregar.Controls.Add(btnGrabar);
            groupBoxAgregar.Controls.Add(txtComentarios);
            groupBoxAgregar.Controls.Add(label8);
            groupBoxAgregar.Controls.Add(cboDificultad);
            groupBoxAgregar.Controls.Add(optEjecutado);
            groupBoxAgregar.Controls.Add(optEnCurso);
            groupBoxAgregar.Controls.Add(optProgramado);
            groupBoxAgregar.Controls.Add(label7);
            groupBoxAgregar.Controls.Add(label6);
            groupBoxAgregar.Controls.Add(label3);
            groupBoxAgregar.Controls.Add(label4);
            groupBoxAgregar.Controls.Add(label2);
            groupBoxAgregar.Controls.Add(label1);
            groupBoxAgregar.Controls.Add(cboEspecialidad);
            groupBoxAgregar.Controls.Add(textHora_Practica);
            groupBoxAgregar.Controls.Add(textHora_Teorica);
            groupBoxAgregar.Location = new Point(12, 12);
            groupBoxAgregar.Name = "groupBoxAgregar";
            groupBoxAgregar.Size = new Size(442, 412);
            groupBoxAgregar.TabIndex = 5;
            groupBoxAgregar.TabStop = false;
            groupBoxAgregar.Text = "Datos";
            // 
            // txtCurso
            // 
            txtCurso.Cursor = Cursors.IBeam;
            txtCurso.Location = new Point(159, 17);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(100, 23);
            txtCurso.TabIndex = 1;
            // 
            // txtComentarios
            // 
            txtComentarios.Cursor = Cursors.IBeam;
            txtComentarios.Location = new Point(159, 216);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(170, 23);
            txtComentarios.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(18, 220);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 21;
            label8.Text = "Comentarios";
            // 
            // cboDificultad
            // 
            cboDificultad.Cursor = Cursors.Hand;
            cboDificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDificultad.FormattingEnabled = true;
            cboDificultad.Location = new Point(159, 166);
            cboDificultad.Name = "cboDificultad";
            cboDificultad.Size = new Size(100, 23);
            cboDificultad.TabIndex = 4;
            // 
            // optEjecutado
            // 
            optEjecutado.AutoSize = true;
            optEjecutado.Location = new Point(335, 266);
            optEjecutado.Name = "optEjecutado";
            optEjecutado.Size = new Size(77, 19);
            optEjecutado.TabIndex = 8;
            optEjecutado.Text = "Ejecutado";
            optEjecutado.UseVisualStyleBackColor = true;
            // 
            // optEnCurso
            // 
            optEnCurso.AutoSize = true;
            optEnCurso.Location = new Point(259, 266);
            optEnCurso.Name = "optEnCurso";
            optEnCurso.Size = new Size(70, 19);
            optEnCurso.TabIndex = 7;
            optEnCurso.Text = "En curso";
            optEnCurso.UseVisualStyleBackColor = true;
            // 
            // optProgramado
            // 
            optProgramado.AutoSize = true;
            optProgramado.Checked = true;
            optProgramado.Location = new Point(159, 266);
            optProgramado.Name = "optProgramado";
            optProgramado.Size = new Size(91, 19);
            optProgramado.TabIndex = 6;
            optProgramado.TabStop = true;
            optProgramado.Text = "Programado";
            optProgramado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(18, 323);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 13;
            label7.Text = "Especialidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(18, 270);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 12;
            label6.Text = "Estado del curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(18, 170);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 10;
            label3.Text = "Nivel de Dificultad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(18, 120);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Horas Practica:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(18, 70);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Horas Teoricas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Curso:";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.Cursor = Cursors.Hand;
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(159, 315);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(170, 23);
            cboEspecialidad.TabIndex = 9;
            // 
            // textHora_Practica
            // 
            textHora_Practica.Cursor = Cursors.IBeam;
            textHora_Practica.Location = new Point(159, 116);
            textHora_Practica.MaxLength = 2;
            textHora_Practica.Name = "textHora_Practica";
            textHora_Practica.Size = new Size(100, 23);
            textHora_Practica.TabIndex = 3;
            textHora_Practica.KeyPress += textHora_Teorica_KeyPress;
            // 
            // textHora_Teorica
            // 
            textHora_Teorica.Cursor = Cursors.IBeam;
            textHora_Teorica.Location = new Point(159, 66);
            textHora_Teorica.MaxLength = 2;
            textHora_Teorica.Name = "textHora_Teorica";
            textHora_Teorica.Size = new Size(100, 23);
            textHora_Teorica.TabIndex = 2;
            textHora_Teorica.KeyPress += textHora_Teorica_KeyPress;
            // 
            // CursoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 436);
            Controls.Add(groupBoxAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Curso";
            Load += CursoMan02_Load;
            groupBoxAgregar.ResumeLayout(false);
            groupBoxAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private Button btnGrabar;
        private GroupBox groupBoxAgregar;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cboEspecialidad;
        private TextBox textHora_Practica;
        private TextBox textHora_Teorica;
        private RadioButton optEjecutado;
        private RadioButton optEnCurso;
        private RadioButton optProgramado;
        private ComboBox cboDificultad;
        private Label label8;
        private TextBox txtComentarios;
        private TextBox txtCurso;
    }
}