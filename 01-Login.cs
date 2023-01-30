using MySql.Data.MySqlClient;
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

            txtEmail.Focus();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?" , "SAIR" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
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
            Variaveis.usuario = txtEmail.Text;
            Variaveis.senha = txtSenha.Text;

            if (Variaveis.usuario == "Victor" && Variaveis.senha == "1234")
            {
                Variaveis.nivel = "ADIMINISTRADOR";
                new frmMenuPrincipal().Show();
                Hide();
            }
            else
            {
                try
                {
                    Banco.Conectar();
                    string selecionar = "SELECT `idFuncionario`, `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `nivelFuncionario`, `statusFuncionario` FROM `funcionario` WHERE `emailFuncionario` =@email AND `senhaFuncionario` =@senha AND `statusFuncionario` =@status;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                    cmd.Parameters.AddWithValue("@email", Variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Variaveis.usuario = reader.GetString(1);
                        Variaveis.nivel = reader.GetString(4);
                        new frmMenuPrincipal().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao selecionar Usuário de login" + ex,"ERRO");
                   
                }
            }

           
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
               btnEntrar.Focus();
            }
        }

       
    }
}
