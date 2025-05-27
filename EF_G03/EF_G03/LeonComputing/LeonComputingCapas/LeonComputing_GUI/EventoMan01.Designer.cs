namespace LeonComputing_GUI
{
    partial class EventoMan01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventoMan01));
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            dtgDatos = new DataGridView();
            id_evento = new DataGridViewTextBoxColumn();
            Razon_Social = new DataGridViewTextBoxColumn();
            fecha_inicio = new DataGridViewTextBoxColumn();
            fecha_fin = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            frecuencia = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            presupuesto_requerido = new DataGridViewTextBoxColumn();
            direccion_evento = new DataGridViewTextBoxColumn();
            cupos_programados = new DataGridViewTextBoxColumn();
            Apellido_paterno = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            fecha_registro = new DataGridViewTextBoxColumn();
            tipo_estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(858, 484);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(959, 484);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 32);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1060, 484);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(89, 32);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { id_evento, Razon_Social, fecha_inicio, fecha_fin, descripcion, frecuencia, Turno, presupuesto_requerido, direccion_evento, cupos_programados, Apellido_paterno, Nombre, fecha_registro, tipo_estado });
            dtgDatos.Location = new Point(12, 64);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1160, 369);
            dtgDatos.TabIndex = 5;
            // 
            // id_evento
            // 
            id_evento.DataPropertyName = "id_evento";
            id_evento.HeaderText = "Codigo evento";
            id_evento.Name = "id_evento";
            // 
            // Razon_Social
            // 
            Razon_Social.DataPropertyName = "Razon_Social";
            Razon_Social.HeaderText = "Empresa";
            Razon_Social.Name = "Razon_Social";
            // 
            // fecha_inicio
            // 
            fecha_inicio.DataPropertyName = "fecha_inicio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            fecha_inicio.DefaultCellStyle = dataGridViewCellStyle1;
            fecha_inicio.HeaderText = "Fecha de inicio";
            fecha_inicio.Name = "fecha_inicio";
            // 
            // fecha_fin
            // 
            fecha_fin.DataPropertyName = "fecha_fin";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            fecha_fin.DefaultCellStyle = dataGridViewCellStyle2;
            fecha_fin.HeaderText = "Fecha de fin";
            fecha_fin.Name = "fecha_fin";
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Curso";
            descripcion.Name = "descripcion";
            // 
            // frecuencia
            // 
            frecuencia.DataPropertyName = "frecuencia";
            frecuencia.HeaderText = "Frecuencia";
            frecuencia.Name = "frecuencia";
            // 
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            // 
            // presupuesto_requerido
            // 
            presupuesto_requerido.DataPropertyName = "presupuesto_requerido";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            presupuesto_requerido.DefaultCellStyle = dataGridViewCellStyle3;
            presupuesto_requerido.HeaderText = "Presupuesto";
            presupuesto_requerido.Name = "presupuesto_requerido";
            // 
            // direccion_evento
            // 
            direccion_evento.DataPropertyName = "direccion_evento";
            direccion_evento.HeaderText = "Dirección";
            direccion_evento.Name = "direccion_evento";
            // 
            // cupos_programados
            // 
            cupos_programados.DataPropertyName = "cupos_programados";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cupos_programados.DefaultCellStyle = dataGridViewCellStyle4;
            cupos_programados.HeaderText = "Cupos";
            cupos_programados.Name = "cupos_programados";
            // 
            // Apellido_paterno
            // 
            Apellido_paterno.DataPropertyName = "Apellido_paterno";
            Apellido_paterno.HeaderText = "Apellido (Expositor)";
            Apellido_paterno.Name = "Apellido_paterno";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre (Expositor)";
            Nombre.Name = "Nombre";
            // 
            // fecha_registro
            // 
            fecha_registro.DataPropertyName = "fecha_registro";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            fecha_registro.DefaultCellStyle = dataGridViewCellStyle5;
            fecha_registro.HeaderText = "Fecha de registro";
            fecha_registro.Name = "fecha_registro";
            // 
            // tipo_estado
            // 
            tipo_estado.DataPropertyName = "tipo_estado";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            tipo_estado.DefaultCellStyle = dataGridViewCellStyle6;
            tipo_estado.HeaderText = "Estado";
            tipo_estado.Name = "tipo_estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1115, 467);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1078, 453);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(75, 23);
            lblRegistros.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1001, 456);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Registros:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 7;
            label3.Text = "Ingrese filtro por curso:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(229, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(299, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // EventoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(txtFiltro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Evento";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnCerrar;
        private DataGridView dtgDatos;
        private Label label1;
        private Label lblRegistros;
        private Label label2;
        private Label label3;
        private TextBox txtFiltro;
        private DataGridViewTextBoxColumn id_evento;
        private DataGridViewTextBoxColumn Razon_Social;
        private DataGridViewTextBoxColumn fecha_inicio;
        private DataGridViewTextBoxColumn fecha_fin;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn frecuencia;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn presupuesto_requerido;
        private DataGridViewTextBoxColumn direccion_evento;
        private DataGridViewTextBoxColumn cupos_programados;
        private DataGridViewTextBoxColumn Apellido_paterno;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn fecha_registro;
        private DataGridViewTextBoxColumn tipo_estado;
    }
}
