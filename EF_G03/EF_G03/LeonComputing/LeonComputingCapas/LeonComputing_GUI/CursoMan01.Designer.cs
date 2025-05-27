namespace LeonComputing_GUI
{
    partial class CursoMan01
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoMan01));
            dtgDatos = new DataGridView();
            cod_curso = new DataGridViewTextBoxColumn();
            DescEspecialidad = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            horas_teoria = new DataGridViewTextBoxColumn();
            horas_practica = new DataGridViewTextBoxColumn();
            nivel_dificultad = new DataGridViewTextBoxColumn();
            comentarios = new DataGridViewTextBoxColumn();
            fecha_registro = new DataGridViewTextBoxColumn();
            tipo_estado = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnAgregar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { cod_curso, DescEspecialidad, descripcion, horas_teoria, horas_practica, nivel_dificultad, comentarios, fecha_registro, tipo_estado });
            dtgDatos.Location = new Point(12, 76);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1160, 369);
            dtgDatos.TabIndex = 0;
            // 
            // cod_curso
            // 
            cod_curso.DataPropertyName = "cod_curso";
            cod_curso.HeaderText = "Codigo curso";
            cod_curso.Name = "cod_curso";
            // 
            // DescEspecialidad
            // 
            DescEspecialidad.DataPropertyName = "DescEspecialidad";
            DescEspecialidad.HeaderText = "Especialidad";
            DescEspecialidad.Name = "DescEspecialidad";
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripción";
            descripcion.Name = "descripcion";
            // 
            // horas_teoria
            // 
            horas_teoria.DataPropertyName = "horas_teoria";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            horas_teoria.DefaultCellStyle = dataGridViewCellStyle1;
            horas_teoria.HeaderText = "Horas teoricas";
            horas_teoria.Name = "horas_teoria";
            // 
            // horas_practica
            // 
            horas_practica.DataPropertyName = "horas_practica";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            horas_practica.DefaultCellStyle = dataGridViewCellStyle2;
            horas_practica.HeaderText = "Horas practicas";
            horas_practica.Name = "horas_practica";
            // 
            // nivel_dificultad
            // 
            nivel_dificultad.DataPropertyName = "nivel_dificultad";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            nivel_dificultad.DefaultCellStyle = dataGridViewCellStyle3;
            nivel_dificultad.HeaderText = "Dificultad";
            nivel_dificultad.Name = "nivel_dificultad";
            // 
            // comentarios
            // 
            comentarios.DataPropertyName = "comentarios";
            comentarios.HeaderText = "Comentarios";
            comentarios.Name = "comentarios";
            // 
            // fecha_registro
            // 
            fecha_registro.DataPropertyName = "fecha_registro";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            fecha_registro.DefaultCellStyle = dataGridViewCellStyle4;
            fecha_registro.HeaderText = "Fecha de registro";
            fecha_registro.Name = "fecha_registro";
            // 
            // tipo_estado
            // 
            tipo_estado.DataPropertyName = "tipo_estado";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            tipo_estado.DefaultCellStyle = dataGridViewCellStyle5;
            tipo_estado.HeaderText = "Estado";
            tipo_estado.Name = "tipo_estado";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1060, 484);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(89, 32);
            btnCerrar.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(281, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese filtro por nivel del curso (Baja, Media y Alta):";
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(324, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(185, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(858, 484);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 32);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1078, 453);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(72, 20);
            lblRegistros.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1001, 456);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Registros:";
            // 
            // CursoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Curso";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnCerrar;
        private Button btnActualizar;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnAgregar;
        internal Label lblRegistros;
        private Label label2;
        private DataGridViewTextBoxColumn cod_curso;
        private DataGridViewTextBoxColumn DescEspecialidad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn horas_teoria;
        private DataGridViewTextBoxColumn horas_practica;
        private DataGridViewTextBoxColumn nivel_dificultad;
        private DataGridViewTextBoxColumn comentarios;
        private DataGridViewTextBoxColumn fecha_registro;
        private DataGridViewTextBoxColumn tipo_estado;
    }
}