namespace ProyWinC_Sem03
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ejemplosSemana3ToolStripMenuItem = new ToolStripMenuItem();
            visorToolStripMenuItem = new ToolStripMenuItem();
            resgistroToolStripMenuItem = new ToolStripMenuItem();
            vistaDePersonalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ejemplosSemana3ToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ejemplosSemana3ToolStripMenuItem
            // 
            ejemplosSemana3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visorToolStripMenuItem, resgistroToolStripMenuItem, vistaDePersonalToolStripMenuItem });
            ejemplosSemana3ToolStripMenuItem.Image = Properties.Resources.star_green;
            ejemplosSemana3ToolStripMenuItem.Name = "ejemplosSemana3ToolStripMenuItem";
            ejemplosSemana3ToolStripMenuItem.Size = new Size(136, 20);
            ejemplosSemana3ToolStripMenuItem.Text = "Ejemplos semana 3";
            // 
            // visorToolStripMenuItem
            // 
            visorToolStripMenuItem.Image = Properties.Resources.Display1;
            visorToolStripMenuItem.Name = "visorToolStripMenuItem";
            visorToolStripMenuItem.Size = new Size(186, 22);
            visorToolStripMenuItem.Text = "Visor de imagenes";
            visorToolStripMenuItem.Click += visorToolStripMenuItem_Click;
            // 
            // resgistroToolStripMenuItem
            // 
            resgistroToolStripMenuItem.Image = Properties.Resources.Control_Panel;
            resgistroToolStripMenuItem.Name = "resgistroToolStripMenuItem";
            resgistroToolStripMenuItem.Size = new Size(186, 22);
            resgistroToolStripMenuItem.Text = "Resgistro de personal";
            resgistroToolStripMenuItem.Click += resgistroToolStripMenuItem_Click;
            // 
            // vistaDePersonalToolStripMenuItem
            // 
            vistaDePersonalToolStripMenuItem.Image = Properties.Resources.user1_preferences;
            vistaDePersonalToolStripMenuItem.Name = "vistaDePersonalToolStripMenuItem";
            vistaDePersonalToolStripMenuItem.Size = new Size(186, 22);
            vistaDePersonalToolStripMenuItem.Text = "Vista de personal";
            vistaDePersonalToolStripMenuItem.Click += vistaDePersonalToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Image = Properties.Resources.star_green;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(57, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = Properties.Resources.Shutdown_32x32_32;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblSesion });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.Control;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(47, 17);
            lblEquipo.Text = "Equipo:";
            // 
            // lblSesion
            // 
            lblSesion.BackColor = SystemColors.MenuHighlight;
            lblSesion.ForeColor = SystemColors.Control;
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(87, 17);
            lblSesion.Text = "Tiempo Sesion:";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.auto_7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIPrincipal";
            Text = "Menu Principal";
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
        private ToolStripMenuItem ejemplosSemana3ToolStripMenuItem;
        private ToolStripMenuItem visorToolStripMenuItem;
        private ToolStripMenuItem resgistroToolStripMenuItem;
        private ToolStripMenuItem vistaDePersonalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblSesion;
    }
}