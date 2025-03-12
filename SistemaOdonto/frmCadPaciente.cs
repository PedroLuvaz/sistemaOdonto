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
    public partial class frmCadPaciente : Form
    {
        PacienteService service = new PacienteService();
        public frmCadPaciente()
        {
            InitializeComponent();
            cbSexo.Text = "Masculino";
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
        private void lblCRO_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConPacientes frm = new frmConPacientes();
            frm.ShowDialog();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            dtNascimento.Text = "";
            txtCEP.Text = "";
            cbSexo.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public Paciente objGerado()
        {
            Paciente obj = new Paciente();
            obj.Nome = txtNome.Text;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Email = txtEmail.Text;
            obj.Complemento = txtComplemento.Text;
            obj.Endereco = txtEndereco.Text;
            obj.CEP = txtCEP.Text;
            obj.Sexo = cbSexo.Text;
            obj.Nascimento = Convert.ToDateTime(dtNascimento.Value);
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
                    MessageBox.Show("Paciente Cadastrado com Sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao salvar" + ex.Message);
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
