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
        DentistaService service = new DentistaService();
        public frmCadDentista()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;
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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if(ts.Text == "Sucesso!")
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

        }
    }
}
