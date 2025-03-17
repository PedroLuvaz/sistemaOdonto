namespace SistemaOdonto
{
    partial class frmCadConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadConsulta));
            dtData = new DateTimePicker();
            txtData = new Label();
            txtAnotacoes = new TextBox();
            label1 = new Label();
            cbDentista = new ComboBox();
            label3 = new Label();
            cbPaciente = new ComboBox();
            label2 = new Label();
            dtHora = new DateTimePicker();
            label4 = new Label();
            btnBuscar = new Button();
            btnLimpar = new Button();
            btnSave = new Button();
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtData
            // 
            dtData.Location = new Point(351, 25);
            dtData.Name = "dtData";
            dtData.Size = new Size(146, 23);
            dtData.TabIndex = 44;
            // 
            // txtData
            // 
            txtData.AutoSize = true;
            txtData.Location = new Point(311, 28);
            txtData.Name = "txtData";
            txtData.Size = new Size(34, 15);
            txtData.TabIndex = 43;
            txtData.Text = "Data:";
            txtData.Click += txtData_Click;
            // 
            // txtAnotacoes
            // 
            txtAnotacoes.Location = new Point(85, 172);
            txtAnotacoes.Margin = new Padding(3, 2, 3, 2);
            txtAnotacoes.Multiline = true;
            txtAnotacoes.Name = "txtAnotacoes";
            txtAnotacoes.Size = new Size(412, 135);
            txtAnotacoes.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 172);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 41;
            label1.Text = "Anotaçoes:";
            // 
            // cbDentista
            // 
            cbDentista.FormattingEnabled = true;
            cbDentista.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbDentista.Location = new Point(74, 80);
            cbDentista.Name = "cbDentista";
            cbDentista.Size = new Size(135, 23);
            cbDentista.TabIndex = 46;
            cbDentista.SelectedIndexChanged += cbDentista_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 45;
            label3.Text = "Dentista:";
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(74, 28);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(135, 23);
            cbPaciente.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 47;
            label2.Text = "Paciente:";
            // 
            // dtHora
            // 
            dtHora.CustomFormat = "HH:mm";
            dtHora.Format = DateTimePickerFormat.Custom;
            dtHora.Location = new Point(351, 80);
            dtHora.Name = "dtHora";
            dtHora.Size = new Size(146, 23);
            dtHora.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 83);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 49;
            label4.Text = "Hora:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Control;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(311, 326);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 67);
            btnBuscar.TabIndex = 53;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Control;
            btnLimpar.BackgroundImage = (Image)resources.GetObject("btnLimpar.BackgroundImage");
            btnLimpar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(210, 326);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 67);
            btnLimpar.TabIndex = 52;
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = Properties.Resources.salvar2;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(101, 326);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 67);
            btnSave.TabIndex = 51;
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 54;
            statusStrip1.Text = "statusStrip1";
            // 
            // ts
            // 
            ts.Name = "ts";
            ts.Size = new Size(69, 17);
            ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            tsNenhuma.Name = "tsNenhuma";
            tsNenhuma.Size = new Size(60, 17);
            tsNenhuma.Text = "Nenhuma";
            // 
            // frmCadConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSave);
            Controls.Add(dtHora);
            Controls.Add(label4);
            Controls.Add(cbPaciente);
            Controls.Add(label2);
            Controls.Add(cbDentista);
            Controls.Add(label3);
            Controls.Add(dtData);
            Controls.Add(txtData);
            Controls.Add(txtAnotacoes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCadConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Consultas";
            Load += frmCadConsulta_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtData;
        private Label txtData;
        private TextBox txtAnotacoes;
        private Label label1;
        private ComboBox cbDentista;
        private Label label3;
        private ComboBox cbPaciente;
        private Label label2;
        private DateTimePicker dtHora;
        private Label label4;
        private Button btnBuscar;
        private Button btnLimpar;
        private Button btnSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private ToolStripStatusLabel tsNenhuma;
    }
}