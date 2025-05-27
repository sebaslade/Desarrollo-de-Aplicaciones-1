namespace ProyWinC_Sem04
{
    partial class frmDemoConexiones
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
            grpConexiones = new GroupBox();
            btnCerrar = new Button();
            btnAbrir = new Button();
            grpConexiones.SuspendLayout();
            SuspendLayout();
            // 
            // grpConexiones
            // 
            grpConexiones.Controls.Add(btnCerrar);
            grpConexiones.Controls.Add(btnAbrir);
            grpConexiones.Location = new Point(79, 27);
            grpConexiones.Name = "grpConexiones";
            grpConexiones.Size = new Size(429, 118);
            grpConexiones.TabIndex = 0;
            grpConexiones.TabStop = false;
            grpConexiones.Text = "Manejo de Conexiones";
            // 
            // btnCerrar
            // 
            btnCerrar.Enabled = false;
            btnCerrar.Location = new Point(232, 51);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(102, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar conexion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(77, 51);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(102, 23);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir conexion";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // frmDemoConexiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 191);
            Controls.Add(grpConexiones);
            Name = "frmDemoConexiones";
            Text = "Demo Conexiones";
            grpConexiones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConexiones;
        private Button btnCerrar;
        private Button btnAbrir;
    }
}