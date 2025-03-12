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
    public partial class frmEditarPaciente : Form
    {
        public string status;

        Paciente obj = new Paciente();

        PacienteService service = new PacienteService();
        public frmEditarPaciente(Paciente obj)
        {
            InitializeComponent();
            InicializarFormulario(obj);
        }

        private void InicializarFormulario(Paciente objP)
        {
            this.obj = objP;
            lblCodigo.Text = obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
            txtEmail.Text = this.obj.Email;
            txtComplemento.Text = this.obj.Complemento;
            txtEndereco.Text = this.obj.Endereco;
            txtCEP.Text = this.obj.CEP;
            cbSexo.Text = this.obj.Sexo;
            dtNascimento.Text = this.obj.Nascimento.ToString();
        }

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
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo email!";
            }
            else if (txtComplemento.Text == string.Empty)
            {
                return "Preencha o campo complemento!";
            }
            else if (txtCEP.Text == string.Empty)
            {
                return "Preencha o campo CEP";
            }
            else if (cbSexo.Text == string.Empty)
            {
                return "Preencha o campo Sexo";
            }
            else if (dtNascimento.Text == string.Empty)
            {
                return "Preencha o campo Data de Nascimento";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso!";
            }
        }

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
                    this.obj.CEP = txtCEP.Text;
                    this.obj.Endereco = txtEndereco.Text;
                    this.obj.Complemento = txtComplemento.Text;
                    this.obj.Sexo = cbSexo.Text;
                    this.obj.Nascimento = Convert.ToDateTime(dtNascimento.Value);
                    service.Atualizar(this.obj);
                    this.Close();
                }
            }
        }
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
    }
}
