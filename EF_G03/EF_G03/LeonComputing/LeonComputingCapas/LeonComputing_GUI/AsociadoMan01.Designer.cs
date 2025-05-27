namespace LeonComputing_GUI
{
    partial class AsociadoMan01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociadoMan01));
            label1 = new Label();
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            cod_asociado = new DataGridViewTextBoxColumn();
            ape_paterno = new DataGridViewTextBoxColumn();
            ape_materno = new DataGridViewTextBoxColumn();
            nombres = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            tlf_celular = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            Razon_Social = new DataGridViewTextBoxColumn();
            fecha_registro = new DataGridViewTextBoxColumn();
            tipo_estado = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegistros = new Label();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por apellido:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(229, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(299, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { cod_asociado, ape_paterno, ape_materno, nombres, dni, tlf_celular, correo, direccion, Razon_Social, fecha_registro, tipo_estado });
            dtgDatos.Location = new Point(12, 64);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1160, 369);
            dtgDatos.TabIndex = 5;
            // 
            // cod_asociado
            // 
            cod_asociado.DataPropertyName = "cod_asociado";
            cod_asociado.HeaderText = "Codigo asociado";
            cod_asociado.Name = "cod_asociado";
            cod_asociado.ReadOnly = true;
            // 
            // ape_paterno
            // 
            ape_paterno.DataPropertyName = "ape_paterno";
            ape_paterno.HeaderText = "Apellido paterno";
            ape_paterno.Name = "ape_paterno";
            ape_paterno.ReadOnly = true;
            // 
            // ape_materno
            // 
            ape_materno.DataPropertyName = "ape_materno";
            ape_materno.HeaderText = "Apellido materno";
            ape_materno.Name = "ape_materno";
            ape_materno.ReadOnly = true;
            // 
            // nombres
            // 
            nombres.DataPropertyName = "nombres";
            nombres.HeaderText = "Nombres";
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dni.DefaultCellStyle = dataGridViewCellStyle1;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // tlf_celular
            // 
            tlf_celular.DataPropertyName = "tlf_celular";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            tlf_celular.DefaultCellStyle = dataGridViewCellStyle2;
            tlf_celular.HeaderText = "Celular";
            tlf_celular.Name = "tlf_celular";
            tlf_celular.ReadOnly = true;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // Razon_Social
            // 
            Razon_Social.DataPropertyName = "Razon_Social";
            Razon_Social.HeaderText = "Empresa";
            Razon_Social.Name = "Razon_Social";
            Razon_Social.ReadOnly = true;
            // 
            // fecha_registro
            // 
            fecha_registro.DataPropertyName = "fecha_registro";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            fecha_registro.DefaultCellStyle = dataGridViewCellStyle3;
            fecha_registro.HeaderText = "Fecha de registro";
            fecha_registro.Name = "fecha_registro";
            fecha_registro.ReadOnly = true;
            // 
            // tipo_estado
            // 
            tipo_estado.DataPropertyName = "tipo_estado";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            tipo_estado.DefaultCellStyle = dataGridViewCellStyle4;
            tipo_estado.HeaderText = "Estado";
            tipo_estado.Name = "tipo_estado";
            tipo_estado.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1001, 456);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1078, 453);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(72, 20);
            lblRegistros.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1060, 484);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(89, 32);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(959, 484);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 32);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(858, 484);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AsociadoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AsociadoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Asociado";
            Load += AsociadoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label label2;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnAgregar;
        internal Label lblRegistros;
        private DataGridViewTextBoxColumn cod_asociado;
        private DataGridViewTextBoxColumn ape_paterno;
        private DataGridViewTextBoxColumn ape_materno;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn tlf_celular;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn Razon_Social;
        private DataGridViewTextBoxColumn fecha_registro;
        private DataGridViewTextBoxColumn tipo_estado;
    }
}