namespace SistemaOdonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }

        private void menuAgendasDentista_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }
    }
}
