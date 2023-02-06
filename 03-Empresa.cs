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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }


        private void CarregarEmpresa()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Erro ao selecionar a lista de empresa!!! \n \n" + ex.Message); 
                
            }
        }

        private void CarregarEmpresaAtiva()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM empresaativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de empresa!!! \n \n" + ex.Message);

            }
        }

        private void CarregarEmpresaInativa() { 
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM empresainativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de empresa!!! \n \n" + ex.Message);

            }
        }

        private void CarregarEmpresaNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta WHERE `NOME` LIKE '%" + Variaveis.nomeEmpresa + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar empresa pelo nome!!! \n \n" + ex.Message);

            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);

            Variaveis.linhaSelecionada = -1;

            CarregarEmpresa();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
           Close();
        }

        private void pnlEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadEmpresa().Show();
            Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVA")
            {
                CarregarEmpresaAtiva();
            }
            else if(cmbStatus.Text == "INATIVA")
            {
                CarregarEmpresaInativa();
            }
            else
            {
                CarregarEmpresa();
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            Variaveis.nomeEmpresa = txtEmpresa.Text;

            if (Variaveis.nomeEmpresa == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarEmpresaNome();
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codEmpresa = Convert.ToInt32(dgvEmpresa[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmpresa.Sort(dgvEmpresa.Columns[1], ListSortDirection.Ascending);
            dgvEmpresa.ClearSelection();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0 )
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadEmpresa().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
           
        }
    }
}
