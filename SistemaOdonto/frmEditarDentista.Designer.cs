namespace SistemaOdonto
{
    partial class frmEditarDentista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarDentista));
            txtNome = new TextBox();
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            btnExcluir = new Button();
            btnEditar = new Button();
            txtCRO = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            lblCRO = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblCodigo = new Label();
            lblCod = new Label();
            panel1 = new Panel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 29);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 34;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 33;
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
            // btnExcluir
            // 
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(168, 223);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 50);
            btnExcluir.TabIndex = 32;
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(54, 223);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 50);
            btnEditar.TabIndex = 31;
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtCRO
            // 
            txtCRO.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCRO.Location = new Point(76, 134);
            txtCRO.Margin = new Padding(3, 2, 3, 2);
            txtCRO.Mask = "?? 00-000";
            txtCRO.Name = "txtCRO";
            txtCRO.Size = new Size(154, 23);
            txtCRO.TabIndex = 29;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(76, 107);
            txtCelular.Margin = new Padding(3, 2, 3, 2);
            txtCelular.Mask = "(00) 0.0000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(154, 23);
            txtCelular.TabIndex = 28;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(76, 81);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 27;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 56);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 26;
            // 
            // lblCRO
            // 
            lblCRO.AutoSize = true;
            lblCRO.Location = new Point(10, 139);
            lblCRO.Name = "lblCRO";
            lblCRO.Size = new Size(34, 15);
            lblCRO.TabIndex = 23;
            lblCRO.Text = "CRO:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(10, 112);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 22;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(10, 86);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 21;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 58);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 19;
            lblName.Text = "Nome:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(76, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(19, 15);
            lblCodigo.TabIndex = 36;
            lblCodigo.Text = "01";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(10, 9);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(46, 15);
            lblCod.TabIndex = 35;
            lblCod.Text = "Código";
            lblCod.Click += lblCod_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._2560667;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(326, 7);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 307);
            panel1.TabIndex = 37;
            // 
            // frmEditarDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(lblCodigo);
            Controls.Add(lblCod);
            Controls.Add(txtNome);
            Controls.Add(statusStrip1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtCRO);
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
            Name = "frmEditarDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Dentistas";
            Load += frmConDentista_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private ToolStripStatusLabel tsNenhuma;
        private Button btnExcluir;
        private Button btnEditar;
        private MaskedTextBox txtCRO;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblCRO;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblName;
        private Label lblCodigo;
        private Label lblCod;
        private Panel panel1;
    }
}