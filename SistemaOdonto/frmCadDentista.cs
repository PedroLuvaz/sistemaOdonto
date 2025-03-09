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
    public partial class frmCadDentista : Form
    {
        // Instância do serviço de dentista
        DentistaService service = new DentistaService();

        public frmCadDentista()
        {
            InitializeComponent();
            // Inicializa o campo txtNome com o valor de txtCelular
            txtNome.Text = txtCelular.Text;
        }

        // Método para validar o cadastro do dentista
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento de clique no label1
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento de clique no label3
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Evento de clique no label6
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Evento de clique no label5
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Evento de rejeição de entrada no maskedTextBox1
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Evento de clique no statusStrip1
        }

        // Método para salvar o cadastro do dentista
        private void btnSave_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso!")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Dentista cadastrado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao salvar" + ex.Message);
            }
        }

        // Método para gerar o objeto Dentista a partir dos campos do formulário
        public Dentista objGerado()
        {
            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CRO = txtCRO.Text;

            return obj;
        }

        private void txtCRO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Evento de rejeição de entrada no txtCRO
        }

        // Método para limpar os campos do formulário
        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCRO.Text = string.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }
    }
}
