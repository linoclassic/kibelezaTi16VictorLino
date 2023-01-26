using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16VictorLino
{
    public partial class FrmCadFuncionario : Form
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblDataCad_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncioario.Location = new Point(this.Width / 2 - pnlCadFuncioario.Width / 2, this.Height / 2 - pnlCadFuncioario.Height / 2);

            if (txtCodigo.Text != "")
            {
                pnlTelefone02.Enabled = true;
                btnSalvar.Enabled = true;
               txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbNivel.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
                cmbEmpresa.Enabled = true;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void lblCadFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
