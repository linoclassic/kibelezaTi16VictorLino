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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes!!! \n \n" + ex.Message);

            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM clienteativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes!!! \n \n" + ex.Message);

            }
        }

        private void CarregarClienteinativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM clienteinativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes!!! \n \n" + ex.Message);

            }
        }

        private void CarregarClienteNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto WHERE `NOME CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar cliente pelo nome!!! \n \n" + ex.Message);

            }
        }


        private void ExcluirCliente()
        {
            try
            {
                Banco.Conectar();
                string excluir = "DELETE FROM `cliente` WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao excluir a empresa. \n \n" + erro.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
             pnlCliente.Location = new Point(this.Width / 2 - pnlCliente.Width / 2, this.Height / 2 - pnlCliente.Height / 2);
            CarregarCliente();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new FrmCadCliente().Show();
            Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarClienteAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarClienteinativo();
            }
            else
            {
                CarregarCliente();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

            if (txtCliente.Text == "")
            {
                cmbStatus.Enabled = true;
                CarregarCliente();
            }
            else
            {
                cmbStatus.Text = "TODOS";
                cmbStatus.Enabled = false;
                Variaveis.nomeCliente = txtCliente.Text;
                CarregarClienteNome();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new FrmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirCliente();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione a linha.");
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codCliente = Convert.ToInt32(dgvCliente[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending); 
            dgvCliente.ClearSelection();
        }
    }
}
