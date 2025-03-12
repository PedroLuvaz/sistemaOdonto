namespace SistemaOdonto
{
    partial class frmCadPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPaciente));
            btnBuscar = new Button();
            btnLimpar = new Button();
            txtNome = new TextBox();
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            btnSave = new Button();
            txtCEP = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            lblCRO = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            panel1 = new Panel();
            txtEndereco = new TextBox();
            txtComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtData = new Label();
            dtNascimento = new DateTimePicker();
            label3 = new Label();
            cbSexo = new ComboBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Control;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(276, 254);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 50);
            btnBuscar.TabIndex = 33;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Control;
            btnLimpar.BackgroundImage = (Image)resources.GetObject("btnLimpar.BackgroundImage");
            btnLimpar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(175, 254);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(82, 50);
            btnLimpar.TabIndex = 32;
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(103, 17);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 31;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 30;
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
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = Properties.Resources.salvar2;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(66, 254);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 50);
            btnSave.TabIndex = 29;
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCEP
            // 
            txtCEP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCEP.Location = new Point(104, 123);
            txtCEP.Margin = new Padding(3, 2, 3, 2);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(154, 23);
            txtCEP.TabIndex = 28;
            txtCEP.MaskInputRejected += txtCEP_MaskInputRejected;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(103, 96);
            txtCelular.Margin = new Padding(3, 2, 3, 2);
            txtCelular.Mask = "(00) 0.0000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(154, 23);
            txtCelular.TabIndex = 27;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(103, 69);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 26;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.MaskInputRejected += txtTelefone_MaskInputRejected;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 43);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 25;
            // 
            // lblCRO
            // 
            lblCRO.AutoSize = true;
            lblCRO.Location = new Point(10, 127);
            lblCRO.Name = "lblCRO";
            lblCRO.Size = new Size(31, 15);
            lblCRO.TabIndex = 24;
            lblCRO.Text = "CEP:";
            lblCRO.Click += lblCRO_Click;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(10, 100);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 23;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(10, 74);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 46);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 20;
            lblName.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(391, 21);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 245);
            panel1.TabIndex = 34;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(104, 150);
            txtEndereco.Margin = new Padding(3, 2, 3, 2);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(154, 23);
            txtEndereco.TabIndex = 38;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(104, 176);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(154, 23);
            txtComplemento.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 181);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 36;
            label1.Text = "Complemento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 153);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 35;
            label2.Text = "Endereço:";
            label2.Click += label2_Click;
            // 
            // txtData
            // 
            txtData.AutoSize = true;
            txtData.Location = new Point(10, 211);
            txtData.Name = "txtData";
            txtData.Size = new Size(101, 15);
            txtData.TabIndex = 39;
            txtData.Text = "Data Nascimento:";
            // 
            // dtNascimento
            // 
            dtNascimento.Location = new Point(112, 206);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(146, 23);
            dtNascimento.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 21);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 41;
            label3.Text = "Sexo:";
            label3.Click += label3_Click;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbSexo.Location = new Point(328, 18);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(54, 23);
            cbSexo.TabIndex = 42;
            cbSexo.SelectedIndexChanged += cbSexo_SelectedIndexChanged;
            // 
            // frmCadPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(cbSexo);
            Controls.Add(label3);
            Controls.Add(dtNascimento);
            Controls.Add(txtData);
            Controls.Add(txtEndereco);
            Controls.Add(txtComplemento);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpar);
            Controls.Add(txtNome);
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(txtCEP);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblCRO);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Paciente";
            Load += frmCadPaciente_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnLimpar;
        private TextBox txtNome;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private ToolStripStatusLabel tsNenhuma;
        private Button btnSave;
        private MaskedTextBox txtCEP;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblCRO;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblName;
        private Panel panel1;
        private TextBox txtEndereco;
        private TextBox txtComplemento;
        private Label label1;
        private Label label2;
        private Label txtData;
        private DateTimePicker dtNascimento;
        private Label label3;
        private ComboBox cbSexo;
    }
}