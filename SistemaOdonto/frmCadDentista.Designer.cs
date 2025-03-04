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
            lblCod = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblCRO = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnSave = new Button();
            button1 = new Button();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusMsg = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(12, 20);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(58, 20);
            lblCod.TabIndex = 0;
            lblCod.Text = "Código";
            lblCod.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 84);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.Click += label3_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 121);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(12, 156);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(58, 20);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "Celular:";
            lblCelular.Click += label5_Click;
            // 
            // lblCRO
            // 
            lblCRO.AutoSize = true;
            lblCRO.Location = new Point(12, 192);
            lblCRO.Name = "lblCRO";
            lblCRO.Size = new Size(41, 20);
            lblCRO.TabIndex = 5;
            lblCRO.Text = "CRO:";
            lblCRO.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._2560667;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(390, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 409);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 21);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 7;
            label1.Text = "01";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(175, 27);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(87, 114);
            txtTelefone.Mask = "(00) 0.0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(175, 27);
            txtTelefone.TabIndex = 10;
            txtTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(87, 149);
            maskedTextBox1.Mask = "(00) 0.0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(175, 27);
            maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(87, 185);
            maskedTextBox2.Mask = "?? 00-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(175, 27);
            maskedTextBox2.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = Properties.Resources.salvar2;
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(12, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 66);
            btnSave.TabIndex = 13;
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(144, 315);
            button1.Name = "button1";
            button1.Size = new Size(94, 66);
            button1.TabIndex = 14;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(274, 315);
            button2.Name = "button2";
            button2.Size = new Size(94, 66);
            button2.TabIndex = 15;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusMsg });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(85, 20);
            toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // toolStripStatusMsg
            // 
            toolStripStatusMsg.Name = "toolStripStatusMsg";
            toolStripStatusMsg.Size = new Size(65, 20);
            toolStripStatusMsg.Text = "Nenhum";
            // 
            // frmCadDentista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblCRO);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblCod);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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

        private Label lblCod;
        private Label lblName;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblCRO;
        private Panel panel1;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button btnSave;
        private Button button1;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusMsg;
    }
}