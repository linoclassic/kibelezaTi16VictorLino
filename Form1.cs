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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width /2 - pnlLogin.Width / 2, this.Height /2 - pnlLogin.Height /2);
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?" , "SAIR" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
