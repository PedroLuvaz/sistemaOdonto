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
    public partial class frmEditarDentista : Form
    {
        // Status do formulário
        public string status;
        // Objeto Dentista
        Dentista obj = new Dentista();
        // Serviço de Dentista
        DentistaService service = new DentistaService();

        // Construtor que inicializa o formulário com um objeto Dentista
        public frmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            InicializarFormulario(obj);
        }

        // Método para inicializar o formulário com os dados do objeto Dentista
        private void InicializarFormulario(Dentista objP)
        {
            this.obj = objP;
            lblCodigo.Text = obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
            txtCRO.Text = this.obj.CRO;
            txtEmail.Text = this.obj.Email;
        }

        // Evento de carregamento do formulário
        private void frmConDentista_Load(object sender, EventArgs e)
        {

        }

        // Evento de clique no label1
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento de clique no lblCod
        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        // Evento de clique no botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if (ts.Text == "Sucesso!")
            {
                if (lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "Apagado";
                    MessageBox.Show("Este registro acabou de ser apagado.");
                }
                else
                {
                    status = "Editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Email = txtEmail.Text;
                    obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.CRO = txtCRO.Text;
                    service.Atualizar(this.obj);
                    MessageBox.Show("Edição feita com sucesso!");
                    this.Close();
                }
            }

        }

        // Método para validar os campos do formulário
        public string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo nome!";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo celular!";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo telefone!";
            }
            else if (txtCRO.Text == string.Empty)
            {
                return "Preencha o campo CRO!";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo email!";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso!";
            }
        }

        // Evento de clique no botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao() == true)
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Registro excluído com sucesso!");
                status = "Apagado";
                this.Close();
            }
        }

        // Método para validar a exclusão do registro
        public bool ValidarExclusao()
        {
            DialogResult confirmation = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmation == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
