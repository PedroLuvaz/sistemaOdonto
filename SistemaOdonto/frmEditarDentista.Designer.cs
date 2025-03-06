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
            button2 = new Button();
            button1 = new Button();
            txtCRO = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            lblCRO = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            label1 = new Label();
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
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(168, 223);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 50);
            button2.TabIndex = 32;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(54, 223);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 50);
            button1.TabIndex = 31;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
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
            lblTelefone.Size = new Size(54, 15);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 36;
            label1.Text = "01";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(10, 9);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(46, 15);
            lblCod.TabIndex = 35;
            lblCod.Text = "Código";
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
            Controls.Add(label1);
            Controls.Add(lblCod);
            Controls.Add(txtNome);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button2;
        private Button button1;
        private MaskedTextBox txtCRO;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblCRO;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblName;
        private Label label1;
        private Label lblCod;
        private Panel panel1;
    }
}