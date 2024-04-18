namespace ProyWinC_Sem01
{
    partial class Form2
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
            lstPaises = new ListBox();
            label2 = new Label();
            txtPais = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 72);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Países:";
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 15;
            lstPaises.Location = new Point(128, 141);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(120, 94);
            lstPaises.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(383, 141);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(100, 23);
            txtPais.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(392, 193);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtPais);
            Controls.Add(label2);
            Controls.Add(lstPaises);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPaises;
        private Label label2;
        private TextBox txtPais;
        private Button btnAgregar;
    }
}