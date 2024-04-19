namespace ProyWinC_Sem02
{
    partial class frmCombos
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
            label1 = new Label();
            cboCargos = new ComboBox();
            label2 = new Label();
            lblBonificacion = new Label();
            label4 = new Label();
            lstEC = new ListBox();
            label5 = new Label();
            txtNomApe = new TextBox();
            label6 = new Label();
            lblSueldo = new Label();
            label8 = new Label();
            btnCalcular = new Button();
            label9 = new Label();
            lblCodDistrito = new Label();
            label3 = new Label();
            cboDistrito = new ComboBox();
            label7 = new Label();
            lblEdad = new Label();
            label10 = new Label();
            mskDni = new MaskedTextBox();
            dtpFecNac = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 162);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione estado civil:";
            // 
            // cboCargos
            // 
            cboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargos.FormattingEnabled = true;
            cboCargos.Location = new Point(262, 119);
            cboCargos.Name = "cboCargos";
            cboCargos.Size = new Size(208, 23);
            cboCargos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 432);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Bonificacion:";
            // 
            // lblBonificacion
            // 
            lblBonificacion.BorderStyle = BorderStyle.FixedSingle;
            lblBonificacion.Location = new Point(262, 424);
            lblBonificacion.Name = "lblBonificacion";
            lblBonificacion.Size = new Size(123, 23);
            lblBonificacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 119);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "Seleccione cargo:";
            // 
            // lstEC
            // 
            lstEC.FormattingEnabled = true;
            lstEC.ItemHeight = 15;
            lstEC.Items.AddRange(new object[] { "Soltero", "Casado", "Divorciado", "Viudo", "Conviviente" });
            lstEC.Location = new Point(262, 162);
            lstEC.Name = "lstEC";
            lstEC.Size = new Size(178, 109);
            lstEC.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 80);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 0;
            label5.Text = "Ingrese nombre y apellido:";
            // 
            // txtNomApe
            // 
            txtNomApe.Location = new Point(262, 80);
            txtNomApe.Name = "txtNomApe";
            txtNomApe.Size = new Size(259, 23);
            txtNomApe.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 382);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 2;
            label6.Text = "Sueldo:";
            // 
            // lblSueldo
            // 
            lblSueldo.BorderStyle = BorderStyle.FixedSingle;
            lblSueldo.Location = new Point(262, 381);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(123, 23);
            lblSueldo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 20);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 0;
            label8.Text = "Ingrese DNI:";
            // 
            // btnCalcular
            // 
            btnCalcular.ImageAlign = ContentAlignment.MiddleRight;
            btnCalcular.Location = new Point(262, 329);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 469);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 2;
            label9.Text = "Cod. Distrito:";
            // 
            // lblCodDistrito
            // 
            lblCodDistrito.BorderStyle = BorderStyle.FixedSingle;
            lblCodDistrito.Location = new Point(262, 468);
            lblCodDistrito.Name = "lblCodDistrito";
            lblCodDistrito.Size = new Size(123, 23);
            lblCodDistrito.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 291);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 0;
            label3.Text = "Seleccione distrito:";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(262, 291);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(208, 23);
            cboDistrito.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 510);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 2;
            label7.Text = "Edad:";
            // 
            // lblEdad
            // 
            lblEdad.BorderStyle = BorderStyle.FixedSingle;
            lblEdad.Location = new Point(262, 509);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(123, 23);
            lblEdad.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 52);
            label10.Name = "label10";
            label10.Size = new Size(161, 15);
            label10.TabIndex = 0;
            label10.Text = "Ingrese fecha de Nacimiento:";
            // 
            // mskDni
            // 
            mskDni.Location = new Point(262, 18);
            mskDni.Mask = "99999999";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(135, 23);
            mskDni.TabIndex = 9;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(262, 52);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(200, 23);
            dtpFecNac.TabIndex = 10;
            // 
            // frmCombos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 577);
            Controls.Add(dtpFecNac);
            Controls.Add(mskDni);
            Controls.Add(btnCalcular);
            Controls.Add(txtNomApe);
            Controls.Add(lstEC);
            Controls.Add(lblSueldo);
            Controls.Add(label6);
            Controls.Add(lblEdad);
            Controls.Add(label7);
            Controls.Add(lblCodDistrito);
            Controls.Add(label9);
            Controls.Add(lblBonificacion);
            Controls.Add(label2);
            Controls.Add(cboDistrito);
            Controls.Add(label3);
            Controls.Add(cboCargos);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "frmCombos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manejo de Combos y Listas ";
            Load += frmCombos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCargos;
        private Label label2;
        private Label lblBonificacion;
        private Label label4;
        private ListBox lstEC;
        private Label label5;
        private TextBox txtNomApe;
        private Label label6;
        private Label lblSueldo;
        private Label label8;
        private Button btnCalcular;
        private Label label9;
        private Label lblCodDistrito;
        private Label label3;
        private ComboBox cboDistrito;
        private Label label7;
        private Label lblEdad;
        private Label label10;
        private MaskedTextBox mskDni;
        private DateTimePicker dtpFecNac;
    }
}