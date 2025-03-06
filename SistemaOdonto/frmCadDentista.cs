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
            if(txtNome.Text == "")
            {
                return "Preencha o campo nome!";
            }else if(txtCelular.Text == string.Empty)
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
    }
}
