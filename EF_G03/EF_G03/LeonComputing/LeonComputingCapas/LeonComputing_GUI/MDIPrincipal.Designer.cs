namespace LeonComputing_GUI
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            asociadosToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, listadosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asociadosToolStripMenuItem, cursosToolStripMenuItem, eventosToolStripMenuItem });
            mantenimientosToolStripMenuItem.Image = Properties.Resources.mantenimiento;
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(122, 20);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // asociadosToolStripMenuItem
            // 
            asociadosToolStripMenuItem.Image = Properties.Resources.asociado;
            asociadosToolStripMenuItem.Name = "asociadosToolStripMenuItem";
            asociadosToolStripMenuItem.Size = new Size(128, 22);
            asociadosToolStripMenuItem.Text = "Asociados";
            asociadosToolStripMenuItem.Click += asociadosToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Image = Properties.Resources.curso;
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(128, 22);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Image = Properties.Resources.evento;
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(128, 22);
            eventosToolStripMenuItem.Text = "Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Image = Properties.Resources.consulta;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(87, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.Image = Properties.Resources.listado;
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(78, 20);
            listadosToolStripMenuItem.Text = "Listados";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Image = Properties.Resources.salida;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(57, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = Properties.Resources.salir;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUsuario });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.ControlDarkDark;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 17);
            toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(16, 17);
            lblUsuario.Text = "...";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.fondoLeon1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 561);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1075, 558);
            Name = "MDIPrincipal";
            Text = "Menu Principal - Modulo de Control";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem listadosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem asociadosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}