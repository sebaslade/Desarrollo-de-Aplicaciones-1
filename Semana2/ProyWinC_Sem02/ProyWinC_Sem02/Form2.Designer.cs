namespace ProyWinC_Sem02
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtRuc = new TextBox();
            label3 = new Label();
            txtPuntaje = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(158, 116);
            button1.Name = "button1";
            button1.Size = new Size(122, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(443, 115);
            button2.Name = "button2";
            button2.Size = new Size(124, 52);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 218);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(162, 253);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ejm: 68534578";
            txtDni.Size = new Size(219, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 296);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese RUC:";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(164, 326);
            txtRuc.MaxLength = 11;
            txtRuc.Name = "txtRuc";
            txtRuc.PlaceholderText = "Ejm: 10002485267";
            txtRuc.Size = new Size(217, 23);
            txtRuc.TabIndex = 5;
            txtRuc.KeyPress += txtDni_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 374);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Puntaje:";
            // 
            // txtPuntaje
            // 
            txtPuntaje.Location = new Point(163, 402);
            txtPuntaje.MaxLength = 2;
            txtPuntaje.Name = "txtPuntaje";
            txtPuntaje.PlaceholderText = "Entre 0 a 20";
            txtPuntaje.Size = new Size(217, 23);
            txtPuntaje.TabIndex = 7;
            txtPuntaje.KeyPress += txtDni_KeyPress;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(txtPuntaje);
            Controls.Add(label3);
            Controls.Add(txtRuc);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Ejemplos de delegacion de eventos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtRuc;
        private Label label3;
        private TextBox txtPuntaje;
    }
}