namespace LeonComputing_GUI
{
    partial class AsociadoMan03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociadoMan03));
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            cboEmpresa = new ComboBox();
            label15 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            txtTelDom = new TextBox();
            txtTel = new TextBox();
            mskDNI = new MaskedTextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtNombres = new TextBox();
            txtApeMaterno = new TextBox();
            txtApePaterno = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            grpDatos = new GroupBox();
            btnCargar = new Button();
            lblCod = new Label();
            pcbFoto = new PictureBox();
            label13 = new Label();
            label16 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(578, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 31);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.Location = new Point(483, 364);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(77, 31);
            btnGrabar.TabIndex = 30;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(163, 360);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 29;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboEmpresa
            // 
            cboEmpresa.Cursor = Cursors.Hand;
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(163, 332);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(220, 23);
            cboEmpresa.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(22, 336);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 27;
            label15.Text = "Empresa";
            // 
            // cboDistrito
            // 
            cboDistrito.Cursor = Cursors.Hand;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(163, 306);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(220, 23);
            cboDistrito.TabIndex = 26;
            // 
            // cboProvincia
            // 
            cboProvincia.Cursor = Cursors.Hand;
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(163, 280);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(220, 23);
            cboProvincia.TabIndex = 25;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.Cursor = Cursors.Hand;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(163, 254);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(220, 23);
            cboDepartamento.TabIndex = 24;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // txtTelDom
            // 
            txtTelDom.Location = new Point(163, 228);
            txtTelDom.MaxLength = 7;
            txtTelDom.Name = "txtTelDom";
            txtTelDom.Size = new Size(134, 23);
            txtTelDom.TabIndex = 23;
            txtTelDom.KeyPress += txtTel_KeyPress;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(163, 202);
            txtTel.MaxLength = 9;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(134, 23);
            txtTel.TabIndex = 22;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(163, 173);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(134, 23);
            mskDNI.TabIndex = 17;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(163, 147);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(220, 23);
            txtDireccion.TabIndex = 16;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(163, 121);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(220, 23);
            txtCorreo.TabIndex = 15;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(163, 95);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(178, 23);
            txtNombres.TabIndex = 14;
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Location = new Point(163, 69);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(134, 23);
            txtApeMaterno.TabIndex = 13;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Location = new Point(163, 43);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(134, 23);
            txtApePaterno.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 362);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 11;
            label12.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 125);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 10;
            label11.Text = "Correo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 232);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 9;
            label10.Text = "Telefono Domicilio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 177);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 8;
            label9.Text = "DNI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 310);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 7;
            label8.Text = "Distrito:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 284);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 6;
            label7.Text = "Provincia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 258);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Departamento:";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnCargar);
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(pcbFoto);
            grpDatos.Controls.Add(label13);
            grpDatos.Controls.Add(label16);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(cboEmpresa);
            grpDatos.Controls.Add(label15);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(txtTelDom);
            grpDatos.Controls.Add(txtTel);
            grpDatos.Controls.Add(mskDNI);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(txtNombres);
            grpDatos.Controls.Add(txtApeMaterno);
            grpDatos.Controls.Add(txtApePaterno);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(13, 13);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(668, 411);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // btnCargar
            // 
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.Location = new Point(530, 183);
            btnCargar.Margin = new Padding(4, 3, 4, 3);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(88, 27);
            btnCargar.TabIndex = 37;
            btnCargar.Text = "Cargar foto";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(163, 23);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(74, 17);
            lblCod.TabIndex = 33;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(483, 16);
            pcbFoto.Margin = new Padding(4, 3, 4, 3);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(173, 161);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 36;
            pcbFoto.TabStop = false;
            // 
            // label13
            // 
            label13.Location = new Point(414, 21);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(61, 18);
            label13.TabIndex = 35;
            label13.Text = "Foto:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 23);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 32;
            label16.Text = "Codigo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 206);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 151);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Materno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido Paterno:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AsociadoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 436);
            Controls.Add(grpDatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AsociadoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Asociado";
            Load += AsociadoMan03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private CheckBox chkEstado;
        private ComboBox cboEmpresa;
        private Label label15;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private TextBox txtTelDom;
        private TextBox txtTel;
        private MaskedTextBox mskDNI;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtNombres;
        private TextBox txtApeMaterno;
        private TextBox txtApePaterno;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox grpDatos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCod;
        private Label label16;
        private Button btnCargar;
        private PictureBox pcbFoto;
        internal Label label13;
        private OpenFileDialog openFileDialog1;
    }
}