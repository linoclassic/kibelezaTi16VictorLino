using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
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

        private void CarregarUltimaEmpresa()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT MAX(idEmpresa) FROM `empresa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codEmpresa = dr.GetInt32(0);
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar última Empresa. \n \n" + ex);
            }
        }

        private void CarregarTelefones()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM foneempresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneEmpresa.DataSource = dt;
                dgvFoneEmpresa.Columns[0].Visible = false;
                dgvFoneEmpresa.Columns[1].HeaderText = "NÚMERO";
                dgvFoneEmpresa.Columns[2].HeaderText = "OPERADORA";
                dgvFoneEmpresa.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneEmpresa.Columns[4].Visible = false;

                dgvFoneEmpresa.ClearSelection();

                Banco.Desconectar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar telefones!!!. \n \n" + ex);
            }
        }

        private void CarregarFoneEmpresa()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM foneempresa WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataReader dr = cmd.ExecuteReader();   
                if (dr.Read())
                {
                    Variaveis.codFoneEmpresa = dr.GetInt32(0);
                    Variaveis.numeroFoneEmpresa = dr.GetString(1);
                    Variaveis.operadoraEmpresa = dr.GetString(2);
                    Variaveis.descricaoEmpresa  = dr.GetString(3);
                    Variaveis.codEmpresa = dr.GetInt32(4);
                    txtCodigo.Text = Variaveis.codFoneEmpresa.ToString();
                    mskdNumeroTelefone.Text = Variaveis.numeroFoneEmpresa;
                    cmbOperadora.Text = Variaveis.operadoraEmpresa;
                    txtDescricao.Text = Variaveis.descricaoEmpresa;
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados do telefone!!!. \n \n" + ex);
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

        private void InserirFoneEmpresa()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO `foneempresa`(`idFoneEmpresa`, `numeroEmpresa`, `operFoneEmpresa`, `descFoneEmpresa`, `idEmpresa`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", Variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operfone", Variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", Variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", Variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA CADADASTRADO COM SUCESSO!!", "CADASTRO");
                Banco.Desconectar();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar a telefone. \n \n " + ex);
            }
        }

        private void AlterarFoneEmpresa()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `foneEmpresa` SET `numeroEmpresa`=@numeroFone, `operFoneEmpresa`=@operFone, `descFoneEmpresa`=@descFone WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", Variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operfone", Variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", Variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", Variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA ALTERADO COM SUCESSO!!", "ALTERAR");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar o telefone!! \n \n" + ex);
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
                    CarregarUltimaEmpresa();
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarEmpresa();
                }

             


            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR FONE";
            pnlTelefone.Visible = true;
            pnlTelefone.Location = new Point(this.Width / 2 - pnlTelefone.Width / 2, this.Height / 2 - pnlTelefone.Height / 2);
            pnlCadEmpresa.Enabled = false;  
            mskdNumeroTelefone.Focus();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR FONE";
            pnlTelefone.Visible = true;

            CarregarFoneEmpresa();

            pnlTelefone.Visible = true;
            pnlTelefone.Location = new Point(this.Width / 2 - pnlTelefone.Width / 2, this.Height / 2 - pnlTelefone.Height / 2);
            pnlCadEmpresa.Enabled = false;
            mskdNumeroTelefone.Focus();
        }

        private void btmFecharTel_Click(object sender, EventArgs e)
        {
            pnlCadEmpresa.Enabled = true;
            CarregarTelefones();

            pnlTelefone.Visible = false;
            pnlTelefone.Location = new Point(this.Width / 2 - pnlTelefone.Width / 2, this.Height / 2 - pnlTelefone.Height / 2);

        }

        private void mskdNumeroTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbOperadora.Enabled = true;
                cmbOperadora.Focus();
            }
        }

        private void cmbOperadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
            }
        }

        private void btnSalvarTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnSalvarTel_Click(object sender, EventArgs e)
        {
            if (mskdNumeroTelefone.MaskCompleted == false)
            {
                MessageBox.Show("Preencher o telefone");
                mskdNumeroTelefone.Focus();
            }
            else if (cmbOperadora.Text == "")
            {
                MessageBox.Show("Preencher a operadora");
                cmbOperadora.Focus();
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencher a descrição");
                txtDescricao.Focus();
            }
            else
            {
                Variaveis.numeroFoneEmpresa = mskdNumeroTelefone.Text;
                Variaveis.operadoraEmpresa = cmbOperadora.Text;
                Variaveis.descricaoEmpresa = txtDescricao.Text;

                InserirFoneEmpresa();
            }

            if (Variaveis.funcao == "CADASTRAR FONE")
            {
                InserirFoneEmpresa();
            }
            else if (Variaveis.funcao == "ALTERAR FONE")
            {
                AlterarFoneEmpresa();
            }

            btnLimparTel.PerformClick();
        }

        private void btnLimparTel_Click(object sender, EventArgs e)
        {
            mskdNumeroTelefone.Text = String.Empty;
            cmbOperadora.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            cmbOperadora.Enabled = false;
            txtDescricao.Enabled = false;
            btnSalvarTel.Enabled = false;
            mskdNumeroTelefone.Focus();




        }

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocumento.Text == "CNPJ")
            {
                mskdCnpjCpf.Mask = "00,000,000/0000-00";
            }
            else if (cmbDocumento.Text == "CPF")
            {
                mskdCnpjCpf.Mask = "000,000,000-00";
            }
        }
    }
}
