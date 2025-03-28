using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class frmConsultas : Form
    {
        // Instâncias dos serviços para manipulação de consultas, dentistas e pacientes
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        // Dicionário para armazenar DataGridViews associados aos dentistas
        private Dictionary<int, DataGridView> DataGridViews = new Dictionary<int, DataGridView>();

        public frmConsultas()
        {
            InitializeComponent();
            IniciarForm();
        }

        // Método para inicializar o formulário
        private void IniciarForm()
        {
            // Obtém a lista de dentistas
            var listaD = serviceD.Listar();
            foreach (var dentista in listaD)
            {
                // Adiciona uma nova aba para cada dentista
                tbAgenda.TabPages.Add(dentista.Id.ToString(), dentista.Nome);

                // Cria um novo DataGridView para o dentista
                DataGridView dgv = new DataGridView();

                // Adiciona o DataGridView ao dicionário
                DataGridViews.Add(dentista.Id, dgv);

                // Gera a tabela no DataGridView
                GerarTabela(dgv);

                // Adiciona o DataGridView à aba correspondente
                tbAgenda.TabPages[dentista.Id.ToString()].Controls.Add(dgv);
            }
        }

        // Método para gerar a tabela no DataGridView
        private void GerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.Columns.Add("ColunaCodigoConsulta", "CodigoConsulta");
            dgv.Columns[0].Visible = false;
            dgv.Columns.Add("ColunaHora", "");
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Paciente";
            link.Name = "ColunaNomePaciente";
            dgv.Columns.Add(link);
            dgv.Columns.Add("ColunaStatus", "Status");
            DataGridViewLinkColumn link2 = new DataGridViewLinkColumn();
            link2.HeaderText = "";
            link2.Name = "ColunaVerConsulta";
            dgv.Columns.Add(link2);

            dgv.CellContentClick += new DataGridViewCellEventHandler(this.Tabela_Clicada);
        }

        private void Tabela_Clicada(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var idConsulta = dgv.Rows[e.RowIndex].Cells[0].Value;
            Consulta c = service.Buscar(Convert.ToInt32(idConsulta));

            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex != -1)
                {
                    Paciente p = serviceP.Buscar(c.IdPaciente);
                    frmEditarPaciente frm = new frmEditarPaciente(p);
                    frm.ShowDialog();
                    AtualizarLinhas();
                }
                if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    var Form = new frmEditarConsulta(c);
                    Form.ShowDialog();
                    AtualizarLinhas();
                }
            }
        }

        public void GerarLinha(DataGridView dgv, int dentistaId)
        {
            var dentista = serviceD.Buscar(dentistaId);
            List<Consulta> consultas = service.Buscar(dentista, Convert.ToDateTime(dtpDataMostrada.Value.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada).ToList();

            foreach (var consulta in consultas)
            {
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = consulta.IdConsulta;
                dgv.Rows[linhaAtual].Cells[1].Value = consulta.HoraMarcada.Value.ToString("HH:mm");
                dgv.Rows[linhaAtual].Cells[2].Value = serviceP.Buscar(consulta.IdPaciente).Nome;
                dgv.Rows[linhaAtual].Cells[3].Value = consulta.Status;
                dgv.Rows[linhaAtual].Cells[4].Value = "Ver Consulta";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLinhas();
        }

        private void AtualizarLinhas()
        {
            if(tbAgenda.SelectedTab.Name != "HomeAgenda")
            {
                var indiceTab = Convert.ToInt32(tbAgenda.SelectedTab.Name);
                DataGridViews[indiceTab].Rows.Clear();
                GerarLinha(DataGridViews[indiceTab], indiceTab);
            }
        }
    }
}
