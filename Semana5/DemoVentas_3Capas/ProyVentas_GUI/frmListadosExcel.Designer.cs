namespace ProyVentas_GUI
{
    partial class frmListadosExcel
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
            btnListarProveedor = new Button();
            btnListarFactura = new Button();
            pcbImagen = new PictureBox();
            lblMensaje = new Label();
            prgBar = new ProgressBar();
            bkgDatos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pcbImagen).BeginInit();
            SuspendLayout();
            // 
            // btnListarProveedor
            // 
            btnListarProveedor.Location = new Point(305, 64);
            btnListarProveedor.Name = "btnListarProveedor";
            btnListarProveedor.Size = new Size(173, 73);
            btnListarProveedor.TabIndex = 0;
            btnListarProveedor.Text = "Listar Proveedor";
            btnListarProveedor.UseVisualStyleBackColor = true;
            btnListarProveedor.Click += btnListarProveedor_Click;
            // 
            // btnListarFactura
            // 
            btnListarFactura.Location = new Point(305, 183);
            btnListarFactura.Name = "btnListarFactura";
            btnListarFactura.Size = new Size(173, 71);
            btnListarFactura.TabIndex = 1;
            btnListarFactura.Text = "Listar Factura";
            btnListarFactura.UseVisualStyleBackColor = true;
            // 
            // pcbImagen
            // 
            pcbImagen.Image = Properties.Resources.indicator;
            pcbImagen.InitialImage = null;
            pcbImagen.Location = new Point(209, 272);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(55, 53);
            pcbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagen.TabIndex = 2;
            pcbImagen.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(440, 289);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(112, 15);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Cargando Reporte...";
            // 
            // prgBar
            // 
            prgBar.Location = new Point(235, 361);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(300, 23);
            prgBar.TabIndex = 4;
            // 
            // bkgDatos
            // 
            bkgDatos.WorkerReportsProgress = true;
            // 
            // frmListadosExcel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(prgBar);
            Controls.Add(lblMensaje);
            Controls.Add(pcbImagen);
            Controls.Add(btnListarFactura);
            Controls.Add(btnListarProveedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListadosExcel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listados Excel";
            Load += frmListadosExcel_Load;
            ((System.ComponentModel.ISupportInitialize)pcbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarProveedor;
        private Button btnListarFactura;
        private PictureBox pcbImagen;
        private Label lblMensaje;
        private ProgressBar prgBar;
        private System.ComponentModel.BackgroundWorker bkgDatos;
    }
}