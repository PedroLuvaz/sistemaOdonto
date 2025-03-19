    namespace SistemaOdonto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            menuDentista = new ToolStripMenuItem();
            menuPaciente = new ToolStripMenuItem();
            menuConsulta = new ToolStripMenuItem();
            agendasToolStripMenuItem = new ToolStripMenuItem();
            menuAgendasDentista = new ToolStripMenuItem();
            menuAGPaciente = new ToolStripMenuItem();
            menuAGConsultas = new ToolStripMenuItem();
            btnAjuda = new ToolStripMenuItem();
            menuSuporte = new ToolStripMenuItem();
            btnSair = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, agendasToolStripMenuItem, btnAjuda, btnSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1135, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDentista, menuPaciente, menuConsulta });
            cadastrosToolStripMenuItem.Image = Properties.Resources.add;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(91, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // menuDentista
            // 
            menuDentista.Name = "menuDentista";
            menuDentista.Size = new Size(180, 22);
            menuDentista.Text = "Dentista";
            menuDentista.Click += menuDentista_Click;
            // 
            // menuPaciente
            // 
            menuPaciente.Name = "menuPaciente";
            menuPaciente.Size = new Size(180, 22);
            menuPaciente.Text = "Paciente";
            menuPaciente.Click += menuPaciente_Click;
            // 
            // menuConsulta
            // 
            menuConsulta.Name = "menuConsulta";
            menuConsulta.Size = new Size(180, 22);
            menuConsulta.Text = "Consulta";
            menuConsulta.Click += menuConsulta_Click;
            // 
            // agendasToolStripMenuItem
            // 
            agendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAgendasDentista, menuAGPaciente, menuAGConsultas });
            agendasToolStripMenuItem.Image = Properties.Resources.agenda;
            agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            agendasToolStripMenuItem.Size = new Size(85, 24);
            agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgendasDentista
            // 
            menuAgendasDentista.Name = "menuAgendasDentista";
            menuAgendasDentista.Size = new Size(180, 22);
            menuAgendasDentista.Text = "Dentistas";
            menuAgendasDentista.Click += menuAgendasDentista_Click;
            // 
            // menuAGPaciente
            // 
            menuAGPaciente.Name = "menuAGPaciente";
            menuAGPaciente.Size = new Size(180, 22);
            menuAGPaciente.Text = "Pacientes";
            menuAGPaciente.Click += menuAGPaciente_Click;
            // 
            // menuAGConsultas
            // 
            menuAGConsultas.Name = "menuAGConsultas";
            menuAGConsultas.Size = new Size(180, 22);
            menuAGConsultas.Text = "Consultas";
            menuAGConsultas.Click += menuAGConsultas_Click;
            // 
            // btnAjuda
            // 
            btnAjuda.DropDownItems.AddRange(new ToolStripItem[] { menuSuporte });
            btnAjuda.Image = Properties.Resources.ajuda;
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(70, 24);
            btnAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            menuSuporte.Name = "menuSuporte";
            menuSuporte.Size = new Size(115, 22);
            menuSuporte.Text = "Suporte";
            // 
            // btnSair
            // 
            btnSair.DropDownItems.AddRange(new ToolStripItem[] { menuSair });
            btnSair.Image = Properties.Resources.sair;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(58, 24);
            btnSair.Text = "Sair";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(93, 22);
            menuSair.Text = "Sair";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 440);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Sistema Odonto";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem agendasToolStripMenuItem;
        private ToolStripMenuItem btnAjuda;
        private ToolStripMenuItem btnSair;
        private ToolStripMenuItem menuDentista;
        private ToolStripMenuItem menuPaciente;
        private ToolStripMenuItem menuConsulta;
        private ToolStripMenuItem menuAgendasDentista;
        private ToolStripMenuItem menuAGPaciente;
        private ToolStripMenuItem menuAGConsultas;
        private ToolStripMenuItem menuSuporte;
        private ToolStripMenuItem menuSair;
    }
}
