namespace ProyWinC_Sem03
{
    partial class frmVisorImagenes
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
            Label1 = new Label();
            pcbFoto = new PictureBox();
            txtFiltro = new TextBox();
            bttnFile = new Button();
            ListBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Location = new Point(14, 10);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(149, 27);
            Label1.TabIndex = 14;
            Label1.Text = "Ingrese patrón de filtro:";
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
            pcbFoto.Location = new Point(14, 47);
            pcbFoto.Margin = new Padding(4, 3, 4, 3);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(205, 166);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 13;
            pcbFoto.TabStop = false;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltro.Location = new Point(182, 10);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(46, 22);
            txtFiltro.TabIndex = 12;
            txtFiltro.Text = "*.*";
            txtFiltro.TextAlign = HorizontalAlignment.Right;
            // 
            // bttnFile
            // 
            bttnFile.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnFile.Location = new Point(266, 1);
            bttnFile.Margin = new Padding(4, 3, 4, 3);
            bttnFile.Name = "bttnFile";
            bttnFile.Size = new Size(205, 37);
            bttnFile.TabIndex = 11;
            bttnFile.Text = "Seleccionar Archivos";
            bttnFile.Click += bttnFile_Click;
            // 
            // ListBox1
            // 
            ListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBox1.ItemHeight = 14;
            ListBox1.Location = new Point(229, 47);
            ListBox1.Margin = new Padding(4, 3, 4, 3);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(375, 158);
            ListBox1.TabIndex = 10;
            ListBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(427, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // frmVisorImagenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 227);
            Controls.Add(numericUpDown1);
            Controls.Add(Label1);
            Controls.Add(pcbFoto);
            Controls.Add(txtFiltro);
            Controls.Add(bttnFile);
            Controls.Add(ListBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVisorImagenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisorImagenes";
            Load += frmVisorImagenes_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox pcbFoto;
        internal System.Windows.Forms.TextBox txtFiltro;
        internal System.Windows.Forms.Button bttnFile;
        internal System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NumericUpDown numericUpDown1;
    }
}