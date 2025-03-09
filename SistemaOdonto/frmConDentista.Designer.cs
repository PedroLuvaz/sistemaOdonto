namespace SistemaOdonto
{
    partial class frmConDentista
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
            ts = new TabControl();
            SuspendLayout();
            // 
            // ts
            // 
            ts.Location = new Point(0, 0);
            ts.Multiline = true;
            ts.Name = "ts";
            ts.SelectedIndex = 0;
            ts.Size = new Size(803, 451);
            ts.SizeMode = TabSizeMode.Fixed;
            ts.TabIndex = 0;
            // 
            // frmConDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmConDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentistas";
            ResumeLayout(false);
        }

        #endregion

        private TabControl ts;
    }
}