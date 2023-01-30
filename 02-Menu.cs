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
    public partial class frmMenuPrincipal : Form
    {
        int hora = DateTime.Now.Hour;
        int clickReserva;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlMenuPrincipal.Location = new Point(this.Width / 2 - pnlMenuPrincipal.Width / 2, this.Height / 2 - pnlMenuPrincipal.Height / 2);

            

            timer1.Start();

            if (hora >= 6 && hora < 12)
            {
                lblMensagem.Text = "Bom dia " + Variaveis.usuario + "!";
            }
            else if (hora >= 12 && hora < 18)
            {
                lblMensagem.Text = "Boa tarde "  + Variaveis.usuario + "!";
            }
            else 
            {
                lblMensagem.Text = "Boa noite " + Variaveis.usuario + "!";
            }

            if (Variaveis.nivel != "ADMINISTRADOR")
            {
                pctFuncionario.Enabled = false;
                pctEmpresa.Enabled = false;
            }
            else
            {
                pctFuncionario.Enabled = true;
                pctEmpresa.Enabled=true;
            }



        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(resposta == DialogResult.No)
            {
                new frmLogin().Show();
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmAjuda().Show();
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {
            
        }

        private void pctReserva_Click(object sender, EventArgs e)
        {
            if (clickReserva == 0 )
            {
                pctReserva.BackColor = Color.FromArgb(162, 52, 96);
                btnAgendar.Visible = true;
                btnAguardar.Visible = true;
                btnAprovar.Visible = true;
                btnCancelar.Visible = true;
                btnEditar.Visible = true;
                btnFinalizar.Visible = true;
                clickReserva = 1;
            }
            else
            {
                esconderBotoes();
            }
        }

        private void esconderBotoes()
        {
            pctReserva.BackColor = Color.FromArgb(70, 10, 45);
            btnAgendar.Visible = false;
            btnAguardar.Visible = false;
            btnAprovar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnFinalizar.Visible = false;
            clickReserva = 0;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            esconderBotoes();   
        }

        private void pctEmpresa_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void pctServico_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void pctRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().Show();
            Hide();
        }

        private void lblSobre_Click(object sender, EventArgs e)
        {
            new frmSobre().Show();
            Hide();
        }
    }
}
