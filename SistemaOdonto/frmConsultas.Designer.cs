namespace SistemaOdonto
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            tbAgenda = new TabControl();
            tabPage1 = new TabPage();
            lb1Agenda = new Label();
            btnBuscar = new Button();
            dtpDataMostrada = new DateTimePicker();
            btnProx = new Button();
            btnAnt = new Button();
            tbAgenda.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAgenda
            // 
            tbAgenda.Controls.Add(tabPage1);
            tbAgenda.Location = new Point(12, 25);
            tbAgenda.Name = "tbAgenda";
            tbAgenda.SelectedIndex = 0;
            tbAgenda.Size = new Size(650, 413);
            tbAgenda.TabIndex = 0;
            tbAgenda.SelectedIndexChanged += tbAgenda_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lb1Agenda);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(642, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inicio";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb1Agenda
            // 
            lb1Agenda.AutoSize = true;
            lb1Agenda.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb1Agenda.Location = new Point(15, 16);
            lb1Agenda.Name = "lb1Agenda";
            lb1Agenda.Size = new Size(381, 29);
            lb1Agenda.TabIndex = 1;
            lb1Agenda.Text = "Esta é a Agenda das Consultas";
            lb1Agenda.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.InfoText;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(570, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
            // 
            // dtpDataMostrada
            // 
            dtpDataMostrada.Location = new Point(364, 10);
            dtpDataMostrada.Name = "dtpDataMostrada";
            dtpDataMostrada.Size = new Size(200, 23);
            dtpDataMostrada.TabIndex = 3;
            // 
            // btnProx
            // 
            btnProx.Image = Properties.Resources.direction4R;
            btnProx.Location = new Point(686, 123);
            btnProx.Name = "btnProx";
            btnProx.Size = new Size(75, 60);
            btnProx.TabIndex = 4;
            btnProx.Text = "button1";
            btnProx.UseVisualStyleBackColor = true;
            // 
            // btnAnt
            // 
            btnAnt.Image = Properties.Resources.direction4L;
            btnAnt.Location = new Point(686, 207);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(75, 64);
            btnAnt.TabIndex = 5;
            btnAnt.Text = "button2";
            btnAnt.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnt);
            Controls.Add(btnProx);
            Controls.Add(dtpDataMostrada);
            Controls.Add(btnBuscar);
            Controls.Add(tbAgenda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Consultas";
            tbAgenda.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbAgenda;
        private TabPage tabPage1;
        private Label lb1Agenda;
        private Button btnBuscar;
        private DateTimePicker dtpDataMostrada;
        private Button btnProx;
        private Button btnAnt;
    }
}