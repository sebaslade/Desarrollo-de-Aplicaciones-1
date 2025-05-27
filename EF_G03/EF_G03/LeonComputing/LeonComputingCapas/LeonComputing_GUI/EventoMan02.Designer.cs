namespace LeonComputing_GUI
{
    partial class EventoMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventoMan02));
            grpDatos = new GroupBox();
            dtpFecFin = new DateTimePicker();
            dtpFecInicio = new DateTimePicker();
            label13 = new Label();
            label3 = new Label();
            cboFrecuencia = new ComboBox();
            optNoche = new RadioButton();
            label2 = new Label();
            optTarde = new RadioButton();
            optManana = new RadioButton();
            cboCurso = new ComboBox();
            cboEmpresa = new ComboBox();
            txtPresu = new TextBox();
            txtCupos = new TextBox();
            btnCancelar = new Button();
            txtDireccion = new TextBox();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            cboExpositor = new ComboBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            label15 = new Label();
            label1 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(dtpFecFin);
            grpDatos.Controls.Add(dtpFecInicio);
            grpDatos.Controls.Add(label13);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(cboFrecuencia);
            grpDatos.Controls.Add(optNoche);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(optTarde);
            grpDatos.Controls.Add(optManana);
            grpDatos.Controls.Add(cboCurso);
            grpDatos.Controls.Add(cboEmpresa);
            grpDatos.Controls.Add(txtPresu);
            grpDatos.Controls.Add(txtCupos);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(cboExpositor);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(label15);
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label7);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(442, 412);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(130, 118);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(200, 23);
            dtpFecFin.TabIndex = 67;
            // 
            // dtpFecInicio
            // 
            dtpFecInicio.Format = DateTimePickerFormat.Short;
            dtpFecInicio.Location = new Point(130, 91);
            dtpFecInicio.Name = "dtpFecInicio";
            dtpFecInicio.Size = new Size(200, 23);
            dtpFecInicio.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 126);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 65;
            label13.Text = "Fecha de Fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 97);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 64;
            label3.Text = "Fecha de Inicio:";
            // 
            // cboFrecuencia
            // 
            cboFrecuencia.Cursor = Cursors.Hand;
            cboFrecuencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFrecuencia.FormattingEnabled = true;
            cboFrecuencia.Location = new Point(130, 37);
            cboFrecuencia.Name = "cboFrecuencia";
            cboFrecuencia.Size = new Size(220, 23);
            cboFrecuencia.TabIndex = 59;
            // 
            // optNoche
            // 
            optNoche.AutoSize = true;
            optNoche.ImeMode = ImeMode.NoControl;
            optNoche.Location = new Point(289, 66);
            optNoche.Name = "optNoche";
            optNoche.Size = new Size(60, 19);
            optNoche.TabIndex = 22;
            optNoche.Text = "Noche";
            optNoche.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 232);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 21;
            label2.Text = "Curso:";
            // 
            // optTarde
            // 
            optTarde.AutoSize = true;
            optTarde.ImeMode = ImeMode.NoControl;
            optTarde.Location = new Point(217, 66);
            optTarde.Name = "optTarde";
            optTarde.Size = new Size(53, 19);
            optTarde.TabIndex = 21;
            optTarde.Text = "Tarde";
            optTarde.UseVisualStyleBackColor = true;
            // 
            // optManana
            // 
            optManana.AutoSize = true;
            optManana.Checked = true;
            optManana.ImeMode = ImeMode.NoControl;
            optManana.Location = new Point(130, 67);
            optManana.Name = "optManana";
            optManana.Size = new Size(68, 19);
            optManana.TabIndex = 20;
            optManana.TabStop = true;
            optManana.Text = "Mañana";
            optManana.UseVisualStyleBackColor = true;
            // 
            // cboCurso
            // 
            cboCurso.Cursor = Cursors.Hand;
            cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(130, 229);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(220, 23);
            cboCurso.TabIndex = 7;
            // 
            // cboEmpresa
            // 
            cboEmpresa.Cursor = Cursors.Hand;
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(130, 11);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(220, 23);
            cboEmpresa.TabIndex = 1;
            // 
            // txtPresu
            // 
            txtPresu.Location = new Point(130, 144);
            txtPresu.Name = "txtPresu";
            txtPresu.Size = new Size(134, 23);
            txtPresu.TabIndex = 4;
            // 
            // txtCupos
            // 
            txtCupos.Location = new Point(130, 196);
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(134, 23);
            txtCupos.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(364, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 31);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 170);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(134, 23);
            txtDireccion.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.Location = new Point(269, 381);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(77, 31);
            btnGrabar.TabIndex = 13;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(130, 365);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 12;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboExpositor
            // 
            cboExpositor.Cursor = Cursors.Hand;
            cboExpositor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpositor.FormattingEnabled = true;
            cboExpositor.Location = new Point(130, 258);
            cboExpositor.Name = "cboExpositor";
            cboExpositor.Size = new Size(220, 23);
            cboExpositor.TabIndex = 8;
            // 
            // cboDistrito
            // 
            cboDistrito.Cursor = Cursors.Hand;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(130, 336);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(220, 23);
            cboDistrito.TabIndex = 11;
            // 
            // cboProvincia
            // 
            cboProvincia.Cursor = Cursors.Hand;
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(130, 310);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(220, 23);
            cboProvincia.TabIndex = 10;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.Cursor = Cursors.Hand;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(130, 284);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(220, 23);
            cboDepartamento.TabIndex = 9;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 339);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 25;
            label15.Text = "Distrito:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 15;
            label1.Text = "Empresa:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 365);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 26;
            label12.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 45);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 16;
            label11.Text = "Frecuencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 204);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 20;
            label10.Text = "Cupos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 71);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 17;
            label4.Text = "Turno:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 149);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 18;
            label9.Text = "Presupuesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 178);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 19;
            label5.Text = "Direccion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 313);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 24;
            label8.Text = "Provincia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 261);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 22;
            label6.Text = "Expositor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 287);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 23;
            label7.Text = "Departamento:";
            // 
            // EventoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 436);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Evento";
            Load += EventoMan02_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label15;
        private Label label1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label7;
        private CheckBox chkEstado;
        private ComboBox cboExpositor;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtCupos;
        private TextBox txtDireccion;
        private TextBox txtPresu;
        private ComboBox cboEmpresa;
        private Label label2;
        private ComboBox cboCurso;
        private RadioButton optNoche;
        private RadioButton optTarde;
        private RadioButton optManana;
        private ComboBox cboFrecuencia;
        private DateTimePicker dtpFecFin;
        private DateTimePicker dtpFecInicio;
        private Label label13;
        private Label label3;
    }
}