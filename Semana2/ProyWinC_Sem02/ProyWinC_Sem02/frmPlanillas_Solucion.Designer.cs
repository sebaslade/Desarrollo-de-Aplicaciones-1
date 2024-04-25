
namespace ProyWinC_Sem02
{
    partial class frmPlanillas_Solucion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.chkDescuento = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblBono = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPagoHoras = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorasDictadas = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHorasAsesoria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.optRemota = new System.Windows.Forms.RadioButton();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpResultados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(138, 27);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(165, 23);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtDNI_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(138, 75);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 23);
            this.txtApellidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(526, 75);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(259, 23);
            this.txtNombres.TabIndex = 2;
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.Location = new System.Drawing.Point(48, 128);
            this.chkDescuento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(168, 19);
            this.chkDescuento.TabIndex = 3;
            this.chkDescuento.Text = "Aplica descuento por renta";
            this.chkDescuento.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Items.AddRange(new object[] {
            "--Seleccione--",
            "Tiempo completo",
            "Tiempo parcial",
            "Asistente laboratorio"});
            this.cboCategorias.Location = new System.Drawing.Point(338, 128);
            this.cboCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(257, 23);
            this.cboCategorias.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 221);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 27);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lblBono);
            this.grpResultados.Controls.Add(this.lblDescuento);
            this.grpResultados.Controls.Add(this.label9);
            this.grpResultados.Controls.Add(this.lblNeto);
            this.grpResultados.Controls.Add(this.label10);
            this.grpResultados.Controls.Add(this.label12);
            this.grpResultados.Controls.Add(this.lblPagoHoras);
            this.grpResultados.Controls.Add(this.label8);
            this.grpResultados.Controls.Add(this.lblTarifa);
            this.grpResultados.Controls.Add(this.label6);
            this.grpResultados.Location = new System.Drawing.Point(48, 277);
            this.grpResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpResultados.Size = new System.Drawing.Size(369, 233);
            this.grpResultados.TabIndex = 9;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // lblBono
            // 
            this.lblBono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBono.Location = new System.Drawing.Point(148, 143);
            this.lblBono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(121, 25);
            this.lblBono.TabIndex = 0;
            this.lblBono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Location = new System.Drawing.Point(148, 103);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(121, 25);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bono:";
            // 
            // lblNeto
            // 
            this.lblNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNeto.Location = new System.Drawing.Point(148, 183);
            this.lblNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(121, 25);
            this.lblNeto.TabIndex = 0;
            this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Descuento renta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Neto a pagar:";
            // 
            // lblPagoHoras
            // 
            this.lblPagoHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagoHoras.Location = new System.Drawing.Point(148, 65);
            this.lblPagoHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagoHoras.Name = "lblPagoHoras";
            this.lblPagoHoras.Size = new System.Drawing.Size(121, 25);
            this.lblPagoHoras.TabIndex = 0;
            this.lblPagoHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pago por horas:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarifa.Location = new System.Drawing.Point(148, 27);
            this.lblTarifa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(121, 25);
            this.lblTarifa.TabIndex = 0;
            this.lblTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarifa horaria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horas dictadas:";
            // 
            // txtHorasDictadas
            // 
            this.txtHorasDictadas.Location = new System.Drawing.Point(150, 172);
            this.txtHorasDictadas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasDictadas.MaxLength = 2;
            this.txtHorasDictadas.Name = "txtHorasDictadas";
            this.txtHorasDictadas.Size = new System.Drawing.Size(66, 23);
            this.txtHorasDictadas.TabIndex = 5;
            this.txtHorasDictadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHorasDictadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtHorasDictadas.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoras_Validating);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.CausesValidation = false;
            this.btnLimpiar.Location = new System.Drawing.Point(637, 396);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 27);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Horas asesoria:";
            // 
            // txtHorasAsesoria
            // 
            this.txtHorasAsesoria.Location = new System.Drawing.Point(388, 172);
            this.txtHorasAsesoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasAsesoria.MaxLength = 2;
            this.txtHorasAsesoria.Name = "txtHorasAsesoria";
            this.txtHorasAsesoria.Size = new System.Drawing.Size(66, 23);
            this.txtHorasAsesoria.TabIndex = 6;
            this.txtHorasAsesoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHorasAsesoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtHorasAsesoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoras_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optMixta);
            this.groupBox1.Controls.Add(this.optRemota);
            this.groupBox1.Controls.Add(this.optPresencial);
            this.groupBox1.Location = new System.Drawing.Point(526, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidad de dictado";
            // 
            // optMixta
            // 
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(39, 72);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(115, 19);
            this.optMixta.TabIndex = 2;
            this.optMixta.Text = "Modalidad mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            // 
            // optRemota
            // 
            this.optRemota.AutoSize = true;
            this.optRemota.Location = new System.Drawing.Point(39, 47);
            this.optRemota.Name = "optRemota";
            this.optRemota.Size = new System.Drawing.Size(123, 19);
            this.optRemota.TabIndex = 1;
            this.optRemota.Text = "Modalidad remota";
            this.optRemota.UseVisualStyleBackColor = true;
            // 
            // optPresencial
            // 
            this.optPresencial.AutoSize = true;
            this.optPresencial.Checked = true;
            this.optPresencial.Location = new System.Drawing.Point(39, 22);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(138, 19);
            this.optPresencial.TabIndex = 0;
            this.optPresencial.TabStop = true;
            this.optPresencial.Text = "Modalidad presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDescuento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasAsesoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHorasDictadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPlanillas";
            this.Text = "Planillas Instituto \"Leon Computer\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlanillas_FormClosing);
            this.Load += new System.EventHandler(this.frmPlanillas_Load);
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.CheckBox chkDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPagoHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHorasDictadas;
        private System.Windows.Forms.Button btnLimpiar;
        private Label label7;
        private TextBox txtHorasAsesoria;
        private Label lblBono;
        private Label label9;
        private GroupBox groupBox1;
        private RadioButton optMixta;
        private RadioButton optRemota;
        private RadioButton optPresencial;
        private ErrorProvider errorProvider1;
    }
}