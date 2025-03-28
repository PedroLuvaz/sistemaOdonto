namespace SistemaOdonto
{
    partial class frmEditarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarConsulta));
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            dtHora = new DateTimePicker();
            label4 = new Label();
            cbPaciente = new ComboBox();
            label2 = new Label();
            cbDentista = new ComboBox();
            label3 = new Label();
            dtData = new DateTimePicker();
            txtData = new Label();
            txtAnotacoes = new TextBox();
            label1 = new Label();
            dtInicio = new DateTimePicker();
            label5 = new Label();
            dtFim = new DateTimePicker();
            label6 = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 546);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(725, 26);
            statusStrip1.TabIndex = 68;
            statusStrip1.Text = "statusStrip1";
            // 
            // ts
            // 
            ts.Name = "ts";
            ts.Size = new Size(85, 20);
            ts.Text = "Mensagem:";
            // 
            // tsNenhuma
            // 
            tsNenhuma.Name = "tsNenhuma";
            tsNenhuma.Size = new Size(73, 20);
            tsNenhuma.Text = "Nenhuma";
            // 
            // dtHora
            // 
            dtHora.CustomFormat = "HH:mm";
            dtHora.Format = DateTimePickerFormat.Custom;
            dtHora.Location = new Point(400, 97);
            dtHora.Margin = new Padding(3, 4, 3, 4);
            dtHora.Name = "dtHora";
            dtHora.ShowUpDown = true;
            dtHora.Size = new Size(166, 27);
            dtHora.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 101);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 63;
            label4.Text = "Hora:";
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(90, 27);
            cbPaciente.Margin = new Padding(3, 4, 3, 4);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(154, 28);
            cbPaciente.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 31);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 61;
            label2.Text = "Paciente:";
            // 
            // cbDentista
            // 
            cbDentista.FormattingEnabled = true;
            cbDentista.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbDentista.Location = new Point(91, 99);
            cbDentista.Margin = new Padding(3, 4, 3, 4);
            cbDentista.Name = "cbDentista";
            cbDentista.Size = new Size(154, 28);
            cbDentista.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 59;
            label3.Text = "Dentista:";
            // 
            // dtData
            // 
            dtData.Location = new Point(400, 23);
            dtData.Margin = new Padding(3, 4, 3, 4);
            dtData.Name = "dtData";
            dtData.Size = new Size(166, 27);
            dtData.TabIndex = 58;
            // 
            // txtData
            // 
            txtData.AutoSize = true;
            txtData.Location = new Point(354, 27);
            txtData.Name = "txtData";
            txtData.Size = new Size(44, 20);
            txtData.TabIndex = 57;
            txtData.Text = "Data:";
            // 
            // txtAnotacoes
            // 
            txtAnotacoes.Location = new Point(104, 216);
            txtAnotacoes.Multiline = true;
            txtAnotacoes.Name = "txtAnotacoes";
            txtAnotacoes.Size = new Size(522, 179);
            txtAnotacoes.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 219);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 55;
            label1.Text = "Anotaçoes:";
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "HH:mm";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(72, 160);
            dtInicio.Margin = new Padding(3, 4, 3, 4);
            dtInicio.Name = "dtInicio";
            dtInicio.ShowUpDown = true;
            dtInicio.Size = new Size(166, 27);
            dtInicio.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 164);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 69;
            label5.Text = "Início:";
            // 
            // dtFim
            // 
            dtFim.CustomFormat = "HH:mm";
            dtFim.Format = DateTimePickerFormat.Custom;
            dtFim.Location = new Point(400, 160);
            dtFim.Margin = new Padding(3, 4, 3, 4);
            dtFim.Name = "dtFim";
            dtFim.ShowUpDown = true;
            dtFim.Size = new Size(166, 27);
            dtFim.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 164);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 71;
            label6.Text = "Fim:";
            // 
            // btnExcluir
            // 
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(320, 426);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(136, 82);
            btnExcluir.TabIndex = 74;
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(190, 426);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(136, 82);
            btnEditar.TabIndex = 73;
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // frmEditarConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 572);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(dtFim);
            Controls.Add(label6);
            Controls.Add(dtInicio);
            Controls.Add(label5);
            Controls.Add(statusStrip1);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditarConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edição de Consultas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private ToolStripStatusLabel tsNenhuma;
        private DateTimePicker dtHora;
        private Label label4;
        private ComboBox cbPaciente;
        private Label label2;
        private ComboBox cbDentista;
        private Label label3;
        private DateTimePicker dtData;
        private Label txtData;
        private TextBox txtAnotacoes;
        private Label label1;
        private DateTimePicker dtInicio;
        private Label label5;
        private DateTimePicker dtFim;
        private Label label6;
        private Button btnExcluir;
        private Button btnEditar;
    }
}