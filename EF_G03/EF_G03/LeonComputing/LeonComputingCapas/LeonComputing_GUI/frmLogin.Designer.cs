namespace LeonComputing_GUI
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 82);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(145, 79);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "mallca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 121);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "12345";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(80, 171);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(170, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 36);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 0;
            label3.Text = "Bienvenido a LeonComputing";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 231);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingrese su Login y password";
            FormClosed += frmLogin_FormClosed;
            KeyDown += frmLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private Label label2;
        private TextBox txtPassword;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}