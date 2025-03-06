namespace SistemaOdonto
{
    partial class frmCadDentista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDentista));
            lblName = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblCRO = new Label();
            panel1 = new Panel();
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtCRO = new MaskedTextBox();
            btnSave = new Button();
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            txtNome = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 63);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.Click += label3_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(10, 91);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(10, 117);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "Celular:";
            lblCelular.Click += label5_Click;
            // 
            // lblCRO
            // 
            lblCRO.AutoSize = true;
            lblCRO.Location = new Point(10, 144);
            lblCRO.Name = "lblCRO";
            lblCRO.Size = new Size(34, 15);
            lblCRO.TabIndex = 5;
            lblCRO.Text = "CRO:";
            lblCRO.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._2560667;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(341, 10);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 307);
            panel1.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 61);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(76, 86);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 10;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(76, 112);
            txtCelular.Margin = new Padding(3, 2, 3, 2);
            txtCelular.Mask = "(00) 0.0000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(154, 23);
            txtCelular.TabIndex = 11;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCRO
            // 
            txtCRO.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCRO.Location = new Point(76, 139);
            txtCRO.Margin = new Padding(3, 2, 3, 2);
            txtCRO.Mask = "?? 00-000";
            txtCRO.Name = "txtCRO";
            txtCRO.Size = new Size(154, 23);
            txtCRO.TabIndex = 12;
            txtCRO.MaskInputRejected += txtCRO_MaskInputRejected;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = Properties.Resources.salvar2;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(102, 233);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 50);
            btnSave.TabIndex = 13;
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
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
            // txtNome
            // 
            txtNome.Location = new Point(76, 34);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 17;
            // 
            // frmCadDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtNome);
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(txtCRO);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            Controls.Add(lblCRO);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Dentistas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblCRO;
        private Panel panel1;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtCRO;
        private Button btnSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private TextBox txtNome;
        private ToolStripStatusLabel tsNenhuma;
    }
}