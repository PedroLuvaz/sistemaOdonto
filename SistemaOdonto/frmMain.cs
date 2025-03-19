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

        private void menuPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void menuAGPaciente_Click(object sender, EventArgs e)
        {
            frmConPacientes frm = new frmConPacientes();
            frm.ShowDialog();
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            frmCadConsulta frm = new frmCadConsulta();
            frm.ShowDialog();
        }

        private void menuAGConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas frm = new frmConsultas();
            frm.ShowDialog();
        }
    }
}
