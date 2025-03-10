namespace SistemaOdonto
{
    partial class frmEditarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPaciente));
            lblCodigo = new Label();
            lblCod = new Label();
            statusStrip1 = new StatusStrip();
            ts = new ToolStripStatusLabel();
            tsNenhuma = new ToolStripStatusLabel();
            btnExcluir = new Button();
            btnEditar = new Button();
            cbSexo = new ComboBox();
            label3 = new Label();
            dtNascimento = new DateTimePicker();
            txtData = new Label();
            txtEndereco = new TextBox();
            txtComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
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
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(76, 12);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(19, 15);
            lblCodigo.TabIndex = 51;
            lblCodigo.Text = "01";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(10, 12);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(46, 15);
            lblCod.TabIndex = 50;
            lblCod.Text = "Código";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ts, tsNenhuma });
            statusStrip1.Location = new Point(0, 354);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(666, 22);
            statusStrip1.TabIndex = 48;
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
            btnExcluir.Location = new Point(151, 289);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 50);
            btnExcluir.TabIndex = 47;
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(30, 289);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 50);
            btnEditar.TabIndex = 46;
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbSexo.Location = new Point(329, 47);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(54, 23);
            cbSexo.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 50);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 68;
            label3.Text = "Sexo:";
            // 
            // dtNascimento
            // 
            dtNascimento.Location = new Point(113, 235);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(146, 23);
            dtNascimento.TabIndex = 67;
            // 
            // txtData
            // 
            txtData.AutoSize = true;
            txtData.Location = new Point(11, 240);
            txtData.Name = "txtData";
            txtData.Size = new Size(101, 15);
            txtData.TabIndex = 66;
            txtData.Text = "Data Nascimento:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(105, 179);
            txtEndereco.Margin = new Padding(3, 2, 3, 2);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(154, 23);
            txtEndereco.TabIndex = 65;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(105, 205);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(154, 23);
            txtComplemento.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 210);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 63;
            label1.Text = "Complemento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 182);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 62;
            label2.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(104, 46);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 61;
            // 
            // txtCEP
            // 
            txtCEP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCEP.Location = new Point(105, 152);
            txtCEP.Margin = new Padding(3, 2, 3, 2);
            txtCEP.Mask = "00.000-00";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(154, 23);
            txtCEP.TabIndex = 60;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(104, 125);
            txtCelular.Margin = new Padding(3, 2, 3, 2);
            txtCelular.Mask = "(00) 0.0000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(154, 23);
            txtCelular.TabIndex = 59;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(104, 98);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 58;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 72);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 57;
            // 
            // lblCRO
            // 
            lblCRO.AutoSize = true;
            lblCRO.Location = new Point(11, 156);
            lblCRO.Name = "lblCRO";
            lblCRO.Size = new Size(31, 15);
            lblCRO.TabIndex = 56;
            lblCRO.Text = "CEP:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(11, 129);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 55;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(11, 103);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 54;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(11, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 53;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 52;
            lblName.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(389, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 245);
            panel1.TabIndex = 70;
            // 
            // frmEditarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 376);
            Controls.Add(panel1);
            Controls.Add(cbSexo);
            Controls.Add(label3);
            Controls.Add(dtNascimento);
            Controls.Add(txtData);
            Controls.Add(txtEndereco);
            Controls.Add(txtComplemento);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(txtCEP);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblCRO);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblCodigo);
            Controls.Add(lblCod);
            Controls.Add(statusStrip1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Paciente";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCod;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ts;
        private ToolStripStatusLabel tsNenhuma;
        private Button btnExcluir;
        private Button btnEditar;
        private ComboBox cbSexo;
        private Label label3;
        private DateTimePicker dtNascimento;
        private Label txtData;
        private TextBox txtEndereco;
        private TextBox txtComplemento;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
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
    }
}