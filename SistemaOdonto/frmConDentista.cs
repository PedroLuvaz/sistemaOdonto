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
    public partial class frmConDentista : Form
    {
        // Instância do serviço de dentistas
        DentistaService service = new DentistaService();

        public frmConDentista()
        {
            InitializeComponent();
            IniciarForm();
        }

        // Método para iniciar o formulário e listar os dentistas
        public void IniciarForm()
        {
            // Obtém a lista de dentistas do serviço
            var lista = service.Listar();
            if (lista == null)
            {
                // Exibe mensagem se não houver dentistas cadastrados
                MessageBox.Show("Não há dentistas cadastrados");
            }
            else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                // Itera sobre a lista de dentistas
                foreach (var dado in lista)
                {
                    // Obtém a primeira letra do nome do dentista
                    char primeiraLetra = dado.Nome.Trim()[0];
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        // Adiciona uma linha na tabela existente se a letra for a mesma
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        // Cria uma nova aba e tabela para a nova letra
                        numTabela = numTabela + 1;
                        ts.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        ts.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }
                    // Atualiza a letra anterior
                    letraAnterior = primeiraLetra;
                }
            }
        }

        // Método para gerar a tabela
        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dg.Columns.Add("Código", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";
            link.Name = "Nome";
            dg.Columns.Add(link);

            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.ts_click);
        }

        // Método que trata o evento de clique em uma célula do DataGridView
        private void ts_click(object? sender, DataGridViewCellEventArgs e)
        {
            // Converte o sender para DataGridView
            DataGridView dg = sender as DataGridView;
            try
            {
                // Verifica se a coluna clicada é a coluna de nome (índice 1) e se a linha clicada não é o cabeçalho
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    // Obtém o ID do dentista da célula da primeira coluna (índice 0) da linha clicada
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    // Busca o objeto Dentista pelo ID
                    Dentista obj = service.Buscar(Convert.ToInt32(id));

                    // Abre o formulário de edição do dentista
                    var form = new frmEditarDentista(obj);
                    form.ShowDialog();
                    this.Close();

                    // Verifica o status do formulário de edição após o fechamento
                    if (form.status == "Apagado")
                    {
                        // Se o dentista foi apagado, fecha o formulário atual e abre um novo
                        this.Close();
                        frmConDentista frm = new frmConDentista();
                        frm.ShowDialog();
                    }
                    if (form.status == "Editado")
                    {
                        // Se o dentista foi editado, remove a linha antiga e adiciona a linha atualizada
                        dg.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dg, obj);
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao selecionar o dentista " + ex.Message);
            }
        }
        


        // Método para gerar as linhas da grid
        private void GerarLinha(DataGridView data, Dentista dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            //data.Rows[linhaAtual].Cells[2].Value = dado.Email;
            data.Rows[linhaAtual].Cells[2].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[3].Value = dado.Celular.ToString("(00) 00000-0000");
            //data.Rows[linhaAtual].Cells[5].Value = dado.CRO;
        }

        //método para clickar na grid e ter evento.
    } 
}
