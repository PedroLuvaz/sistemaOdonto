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
    public partial class frmCadConsulta : Form
    {

        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();
        public frmCadConsulta()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            try
            {
                // Obtém a lista de dentistas do serviço
                var lista = serviceD.Listar();
                // Cria um dicionário para armazenar os dentistas
                var listaD = new Dictionary<int, string>();
                // Adiciona uma opção padrão ao dicionário
                listaD.Add(0, "Selecione um Dentista");
                // Adiciona cada dentista ao dicionário
                foreach (var item in lista)
                {
                    listaD.Add(item.Id, item.Nome);
                }
                // Define a fonte de dados do combobox de dentistas
                cbDentista.DataSource = new BindingSource(listaD, null);
                // Define o campo a ser exibido no combobox
                cbDentista.DisplayMember = "value";
                // Define o campo de valor do combobox
                cbDentista.ValueMember = "key";
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }

            try
            {
                // Obtém a lista de pacientes do serviço
                var lista2 = serviceP.Listar();
                // Cria um dicionário para armazenar os pacientes
                var listaP = new Dictionary<int, string>();
                // Adiciona uma opção padrão ao dicionário
                listaP.Add(0, "Selecione um Paciente");
                // Adiciona cada paciente ao dicionário
                foreach (var item in lista2)
                {
                    listaP.Add(item.Id, item.Nome);
                }
                // Define a fonte de dados do combobox de pacientes
                cbPaciente.DataSource = new BindingSource(listaP, null);
                // Define o campo a ser exibido no combobox
                cbPaciente.DisplayMember = "value";
                // Define o campo de valor do combobox
                cbPaciente.ValueMember = "key";
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }
        }

        public string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (Convert.ToInt32(cbDentista.SelectedValue) == 0)
            {
                return "Selecione um dentista!!!";
            }
            else if (Convert.ToInt32(cbPaciente.SelectedValue) == 0)
            {
                return "Selecione um paciente!!!";
            }
            else if (dtData.Text == String.Empty)
            {
                return "Escolha uma data";
            }
            else if (dtHora.Text == String.Empty)
            {
                return "Escolha um horário";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso!";
            }
        }

        private void frmCadConsulta_Load(object sender, EventArgs e)
        {

        }

        private void txtData_Click(object sender, EventArgs e)
        {

        }

        private void cbDentista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Consulta objGerado()
        {
            Consulta obj = new Consulta();
            obj.IdDentista = Convert.ToInt32(cbDentista.SelectedValue);
            obj.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
            obj.Data = Convert.ToDateTime(dtData.Value.ToString("dd/MM/yyyy"));
            obj.HoraMarcada = dtHora.Value;
            obj.HoraInicio = Convert.ToDateTime("00:00");
            obj.HoraFim = Convert.ToDateTime("00:00");
            obj.Observacao = txtAnotacoes.Text;
            obj.Status = "Não Confirmado";


            return obj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso!")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Consulta Cadastrada com Sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao salvar" + ex.Message);
            }
        }
    }
}
