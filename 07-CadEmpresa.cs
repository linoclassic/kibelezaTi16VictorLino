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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarDadosEmpresa()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM  `empresa` WHERE `idempresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.nomeEmpresa = dr.GetString(1);
                    Variaveis.cnpjCpfEmpresa = dr.GetString(2);
                    Variaveis.razaoSocialEmpresa = dr.GetString(3);
                    Variaveis.emailEmpresa = dr.GetString(4);
                    Variaveis.statusEmpresa = dr.GetString(5);
                    Variaveis.dataCadastroEmpresa = dr.GetDateTime(6);
                    Variaveis.horarioAtendimentoEmpresa = DateTime.Parse(dr.GetString(7));

                    txtCodigo.Text = Variaveis.codEmpresa.ToString();
                    txtNomeFantEmpresa.Text = Variaveis.nomeEmpresa;
                    mskdCnpjCpf.Text = Variaveis.cnpjCpfEmpresa;
                    if (mskdCnpjCpf.Text.Length > 15)
                    {
                        cmbDocumento.Text = "CNPJ";
                    }
                    else
                    {
                        cmbDocumento.Text = "CPF";
                    }
                    txtRazaoSocial.Text = Variaveis.razaoSocialEmpresa;
                    txtEmail.Text = Variaveis.emailEmpresa;
                    cmbStatus.Text = Variaveis.statusEmpresa;
                    mskdDataDeCadastro.Text = Variaveis.dataCadastroEmpresa.ToString("dd/MM/yyyy");
                    cmbCargaHoraria.Text = Variaveis.horarioAtendimentoEmpresa.ToString("HH:mm");
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados da empresa. \n \n" + ex);
            }
        }

        private void InserirEmpresa()
        {
            try
            {
                Banco.Conectar();
                String inserir = "INSERT INTO `empresa`(`idempresa`, `nomeFantasiaEmpresa`, `cnpjCpfEmpresa`, `razaoSocialEmpresa`, `emailEmpresa`, `statusEmpresa`, `dataCadEmpresa`, `horarioAtendEmpresa`) VALUES (DEFAULT,@nomeEmpresa,@cnpjCpf,@razaoSocial,@emailEmpresa,@statusEmpresa,@dataEmpresa,@horarioEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", Variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", Variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial",Variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", Variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", Variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@dataCadEmpresa", Variaveis.dataCadastroEmpresa.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horarioEmpresa", Variaveis.horarioAtendimentoEmpresa.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DA EMPRESA REALIZADO COM SUCESSO!!", "CADASTRO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar a Empresa. \n \n" + ex);
            }
        }

        private void AlterarEmpresa()
        {
            try
            {
                Banco.Conectar();
                String alterar = "UPDATE `empresa` SET `nomeFantasiaEmpresa`=@nomeEmpresa,`cnpjCpfEmpresa`=@cnpjCpf,`razaoSocialEmpresa`=@razaoSocial,`emailEmpresa`=@emailEmpresa,`statusEmpresa`=@statusEmpresa,`horarioAtendEmpresa`=@horarioEmpresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", Variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", Variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial", Variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", Variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", Variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@horarioEmpresa", Variaveis.horarioAtendimentoEmpresa.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DA EMPRESA REALIZADA COM SUCESSO!!", "ALTERAR");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar a Empresa. \n \n" + ex);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadEmpresa.Location = new Point(this.Width / 2 - pnlCadEmpresa.Width / 2, this.Height / 2 - pnlCadEmpresa.Height / 2);

            cmbDocumento.Text = "CNPJ";

            if (Variaveis.funcao == "ALTERAR")
            {
                CarregarDadosEmpresa();
                lblTitulo.Text = "ALTERAR EMPRESA";
            }
          

            if (txtCodigo.Text != "")
            {
                pnlTelefone02.Enabled = true;
                btnSalvar.Enabled = true;
                cmbDocumento.Enabled = true;
                mskdCnpjCpf.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true; 
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFantEmpresa.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome da Empresa");
                txtNomeFantEmpresa.Focus();
            }
            else if (mskdCnpjCpf.MaskCompleted == false)
            {
                MessageBox.Show("Preencher completamente o número do documento");
                mskdCnpjCpf.Focus();
            }
            else if (txtRazaoSocial.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a razão social");
                txtRazaoSocial.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txtEmail.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else if (cmbCargaHoraria.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o horário");
                cmbCargaHoraria.Focus();
            }
            else
            {
                Variaveis.nomeEmpresa = txtNomeFantEmpresa.Text;
                Variaveis.cnpjCpfEmpresa = mskdCnpjCpf.Text;
                Variaveis.razaoSocialEmpresa = txtRazaoSocial.Text;
                Variaveis.emailEmpresa = txtEmail.Text;
                Variaveis.statusEmpresa = cmbStatus.Text;
                if (Variaveis.funcao == "CADASTRAR")
                {
                    mskdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    Variaveis.dataCadastroEmpresa = DateTime.Parse(mskdDataDeCadastro.Text);    
                }
                Variaveis.horarioAtendimentoEmpresa = DateTime.Parse(cmbCargaHoraria.Text);

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirEmpresa();
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarEmpresa();
                }

             


            }
        }
    }
}
