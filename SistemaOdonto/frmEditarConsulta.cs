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
    public partial class frmEditarConsulta: Form
    {
        Consulta consulta = new Consulta();
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();
        public frmEditarConsulta(Consulta c)
        {
            InitializeComponent();
            IniciarFormulario(c);
        }

        private void IniciarFormulario(Consulta c)
        {
            this.consulta = c;

            lblCodigo.Text = this
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


    }
}
