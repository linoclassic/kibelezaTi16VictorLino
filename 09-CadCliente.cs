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
                    pctFoto.Image = ByteToImage(GetImgTobyte(Variaveis.enderecoServicoFtp + "cliente/" + Variaveis.fotoCliente));
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados da empresa. \n \n" + ex);
            }
        }

        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            if (txtCodigo.Text != "")
            {
                pnlTelefone02.Enabled = true;
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

        }
    }
}
