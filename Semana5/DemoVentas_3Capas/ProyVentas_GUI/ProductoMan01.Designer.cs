namespace ProyVentas_GUI
{
    partial class ProductoMan01
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
            dtgDatos = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            Cod_pro = new DataGridViewTextBoxColumn();
            Des_pro = new DataGridViewTextBoxColumn();
            Pre_pro = new DataGridViewTextBoxColumn();
            Des_cat = new DataGridViewTextBoxColumn();
            Des_UM = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            MejorPrecioAbast = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Cod_pro, Des_pro, Pre_pro, Des_cat, Des_UM, Fec_Registro, Estado, MejorPrecioAbast });
            dtgDatos.Location = new Point(12, 69);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(971, 340);
            dtgDatos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(509, 466);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 32);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(625, 466);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(740, 466);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(886, 466);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por descripcion:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(215, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(314, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 421);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(899, 421);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Cod_pro
            // 
            Cod_pro.DataPropertyName = "Cod_pro";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Cod_pro.DefaultCellStyle = dataGridViewCellStyle1;
            Cod_pro.HeaderText = "Codigo producto";
            Cod_pro.Name = "Cod_pro";
            Cod_pro.ReadOnly = true;
            // 
            // Des_pro
            // 
            Des_pro.DataPropertyName = "Des_pro";
            Des_pro.HeaderText = "Descripcion";
            Des_pro.Name = "Des_pro";
            Des_pro.ReadOnly = true;
            // 
            // Pre_pro
            // 
            Pre_pro.DataPropertyName = "Pre_pro";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            Pre_pro.DefaultCellStyle = dataGridViewCellStyle2;
            Pre_pro.HeaderText = "Precio (S/.)";
            Pre_pro.Name = "Pre_pro";
            Pre_pro.ReadOnly = true;
            // 
            // Des_cat
            // 
            Des_cat.DataPropertyName = "Des_cat";
            Des_cat.HeaderText = "Categoría";
            Des_cat.Name = "Des_cat";
            Des_cat.ReadOnly = true;
            // 
            // Des_UM
            // 
            Des_UM.DataPropertyName = "Des_UM";
            Des_UM.HeaderText = "U. Medida";
            Des_UM.Name = "Des_UM";
            Des_UM.ReadOnly = true;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            Fec_Registro.DefaultCellStyle = dataGridViewCellStyle3;
            Fec_Registro.HeaderText = "Fec. Registro";
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // MejorPrecioAbast
            // 
            MejorPrecioAbast.DataPropertyName = "MejorPrecioAbast";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            MejorPrecioAbast.DefaultCellStyle = dataGridViewCellStyle4;
            MejorPrecioAbast.HeaderText = "Mejor Precio";
            MejorPrecioAbast.Name = "MejorPrecioAbast";
            MejorPrecioAbast.ReadOnly = true;
            // 
            // ProductoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 510);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Productos";
            Load += ProductoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Cod_pro;
        private DataGridViewTextBoxColumn Des_pro;
        private DataGridViewTextBoxColumn Pre_pro;
        private DataGridViewTextBoxColumn Des_cat;
        private DataGridViewTextBoxColumn Des_UM;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn MejorPrecioAbast;
    }
}