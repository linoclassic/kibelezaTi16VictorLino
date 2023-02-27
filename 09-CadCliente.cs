using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16VictorLino
{
    public partial class FrmCadCliente : Form
    {
        private void CarregarDadosCliente()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM  `cliente` WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.nomeCliente = dr.GetString(1);
                    Variaveis.emailCliente = dr.GetString(2);
                    Variaveis.senhaCliente = dr.GetString(3);
                    Variaveis.statusCliente = dr.GetString(4);
                    Variaveis.dataCadastroCliente = dr.GetDateTime(5);
                    Variaveis.fotoCliente = dr.GetString(6);
                    Variaveis.fotoCliente = Variaveis.fotoCliente.Remove(0,8);

                    txtCodigo.Text = Variaveis.codCliente.ToString();
                    txtNomeCliente.Text = Variaveis.nomeCliente;
                    txtEmail.Text = Variaveis.emailCliente;
                    txtSenha.Text = Variaveis.senhaCliente;
                    cmbStatus.Text = Variaveis.statusCliente;
                    mskdDataDeCadastro.Text = Variaveis.dataCadastroCliente.ToString("dd/MM/yyyy");
                    pctFoto.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServicoFtp + "cliente/" + Variaveis.fotoCliente));
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados da empresa. \n \n" + ex);
            }
        }

        private void InserirCliente()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO `idCliente`, `nomeCliente`, `emailCliente`, `senhaClienteCliente`, `statusCliente`, `dataCadCliente`, `fotoCliente`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente,@fotoCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", Variaveis.dataCadastroCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fotoCliente", Variaveis.fotoCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO CLIENTE REALIZADO COM SUCESSO !!!", "CADASTRO");
                Banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServicoFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);
                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCLiente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Foto não selecionada ou foto já existente no servidor. \n \n " + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }





            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AlterarCliente()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nomeCliente, `emailCliente`=@emailCliente, `senhaCliente`=@senhaCliente, ``statusCliente`=@statusCliente WHERE `idCliente`= @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar o cliente!!! \n \n" + ex);
            }
        }

        private void AlterarFotoCliente()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `cliente` SET `fotoCliente`=@fotoCliente WHERE `idCLiente` = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);    
                cmd.Parameters.AddWithValue("@fotoCliente", Variaveis.fotoCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                Banco.Desconectar();
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServicoFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);
                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCLiente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não selecionada ou foto já existente no servidor. \n \n " + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InserirFoneCliente()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO `fonecliente`(`idFoneCliente`, `numeroCliente`, `operFoneCliente`, `descFoneCliente`, `idCliente`) VALUES (DEFAULT, @numeroFone,@operFone,@descFone,@codCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", Variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", Variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descFone", Variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codFoneCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE ADICIONADO COM SUCESSO!", "ALTERAR");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar o telefone. \n \n" + ex);
            }
        }

        private void AlterarFoneCliente()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `foneclienteeric` SET `numeroCliente`=@numeroFone,`operFoneCliente`=@operFone,`descFoneCliente`=@descFone,`idCliente`=@codCliente";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", Variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", Variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descFone", Variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE ALTERADO COM SUCESSO!", "CADASTRO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o telefone. \n\n" + ex);
            }
        }

        private void CarregarUltimoCliente() {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT MAX(idCliente) FROM cliente'"; MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao); MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codCliente = dr.GetInt32(0);
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último Cliente. \n\n" + ex);
            }
        }

        //error
        private void CarregarTelefones()
        {
            try
            {
                Banco.Conectar(); string selecionar = "SELECT x FROM fonecliente WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                dgvFoneCliente.DataSource = dt;

                dgvFoneCliente.Columns[0].Visible = false;
                dgvFoneCliente.Columns[1].HeaderText = "NÚMERO";
                dgvFoneCliente.Columns[2].HeaderText = "OPERADORA";
                dgvFoneCliente.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneCliente.Columns[4].Visible = false; dgvFoneCliente.ClearSelection(); Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefones. \n\n" + ex);
            }
        }

        private void CarregarFoneCliente()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM 'fonecliente' WHERE 'idFoneCliente'=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codFoneCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codFoneCliente = dr.GetInt32(0);
                    Variaveis.numeroFoneCliente = dr.GetString(1);
                    Variaveis.operadoraCliente = dr.GetString(2);
                    Variaveis.descricaoCliente = dr.GetString(3);
                    Variaveis.codCliente = dr.GetInt32(4);
                    txtCodigo.Text = Variaveis.codFoneCliente.ToString();
                    mskdNumeroTelefone.Text = Variaveis.numeroFoneCliente;
                    cmbOperadora.Text = Variaveis.operadoraCliente;
                    txtDescricao.Text = Variaveis.descricaoCliente;
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Erro ao carregar dados do Telefone. \n \n" + ex); 

            }
        }

        private void ExcluirFoneCliente()
        {
            try
            {
                Banco.Conectar();
                string excluir = "DELETE FROM 'fonecliente' WHERE 'idFoneCliente =@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneCliente.DataSource = dt;

                dgvFoneCliente.ClearSelection();

                Banco.Desconectar();
            }
        
            catch (Exception erro)
            {
               MessageBox.Show("Erro ao excluir o Telefone do Cliente. \n \n" + erro.Message);

            }
        }

         
        //validação FTP
        private bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(Variaveis.enderecoServicoFtp) || string.IsNullOrEmpty(Variaveis.usuarioFtp) || string.IsNullOrEmpty(Variaveis.senhaFtp)) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Converter imagem em byte
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(Variaveis.usuarioFtp, Variaveis.senhaFtp);
            byte[] imageToByte = ftpClient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
                
        }

        //Converter A imagem de byte para img
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR FONE";
            pnlTelefone.Visible = true;
            pnlTelefone.Location = new Point(this.Width / 2 - pnlTelefone.Width / 2, this.Height / 2 -
            pnlTelefone.Height / 2);
            pnlCadCliente.Enabled = false;
            mskdNumeroTelefone.Focus();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR FONE"; pnlTelefone.Visible = true;
            CarregarFoneCliente();
            pnlTelefone.Location = new Point(this.Width / 2 - pnlTelefone.Width / 2, this.Height / 2 -
            pnlTelefone.Height / 2);
            mskdNumeroTelefone.Enabled = false;
            mskdNumeroTelefone.Focus();
        }

            
                private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            Variaveis.atFotoCliente = "N";

            if (Variaveis.funcao == "ALTERAR")
            {
                CarregarDadosCliente();
                CarregarTelefones();
                lblCadCliente.Text = "ALTERAR CLIENTE";
            }

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
               
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mskdDataDeCadastro.Clear();
            pctFoto.Image = Properties.Resources.semimagem;
            txtNomeCliente.Focus();
            


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNomeCliente.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txtEmail.Focus();
            }

            else if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else
            {
                Variaveis.nomeCliente = txtNomeCliente.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.statusCliente = cmbStatus.Text;
                if (Variaveis.funcao == "CADASTRAR")
                {
                    mskdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    Variaveis.dataCadastroCliente = DateTime.Parse(mskdDataDeCadastro.Text);
                    InserirCliente();
                    CarregarUltimoCliente();
                }
                else if (Variaveis.atFotoCliente == "S")
                {
                    AlterarFotoCliente();
                }
            }


        }

        private void btmFecharTel_Click(object sender, EventArgs e)
        {
            pnlCadCliente.Enabled = true; CarregarTelefones(); pnlCadCliente.Visible = false; pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false; 
                ofdFoto.FileName = ""; 
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO"; 
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckFileExists = true; //verificar se o arquivo existe
                ofdFoto.CheckPathExists = true; //verificar se o caminho existe
                ofdFoto.RestoreDirectory = true; //restaura ao diretório inicial 
                DialogResult dr = ofdFoto.ShowDialog();
                pctFoto.Image = Image.FromFile(ofdFoto.FileName); 
                
                if (ofdFoto.FileName.Substring(ofdFoto.FileName.Length - 8) == "user.png")
                {
                    Variaveis.fotoCliente = "cliente/user.png";
                }
                else
                {
                    Variaveis.fotoCliente = "cliente/" + Regex.Replace(txtNomeCliente.Text, @"\s","").ToLower() + ".png"; //a variável recebe o nome da foto com o nome da pasta "cTiente/nome foto.png"
                }
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Variaveis.atFotoCliente = "S";
                        Variaveis.caminhoFotoCLiente = ofdFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança - Fale com o Admin. \n Mensagem: " + ex + "\nDetalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não tem permissão. \nDetalhe: " + ex);
                    }
                }
                    btnSalvar.Enabled = true;
                    btnSalvar.Focus();
             }
            catch (Exception)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();

            }
        }

        private void dgvFoneCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = -1;
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codFoneCliente = Convert.ToInt32(dgvFoneCliente[0,
                Variaveis.linhaSelecionada].Value);
                txtCodigo.Text = Variaveis.codFoneCliente.ToString();
            }
        }

        private void dgvFoneCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFoneCliente.Sort(dgvFoneCliente.Columns[1], ListSortDirection.Ascending); 
            dgvFoneCliente.ClearSelection();
        }

        private void btnLimparTel_Click(object sender, EventArgs e)
        {
            mskdNumeroTelefone.Text = String.Empty; cmbOperadora.Text = String.Empty; txtDescricao.Text = String.Empty; cmbOperadora.Enabled = false; txtDescricao.Enabled = false; btnSalvarTel.Enabled = false; mskdNumeroTelefone.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                if (Variaveis.linhaSelecionada >= 0)
                {
                    var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ExcluirFoneCliente();
                        CarregarTelefones();
                    }
                }
                else
                {
                    MessageBox.Show("Para excluir selecione uma linha.");
                }
            }
        }
    }
}
