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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarFuncionario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM funcionariocompleto";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios!!! \n \n" + ex.Message);

            }
        }

        private void CarregarFuncionarioAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM funcionarioativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios!!! \n \n" + ex.Message);

            }
        }

        private void CarregarFuncionarioInativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM funcionarioinativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios!!! \n \n" + ex.Message);

            }
        }

        private void CarregarFuncionarioNome()

        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM funcionariocompleto WHERE `NOME FUNCIONÁRIO` LIKE '%" + Variaveis.nomeFuncionario + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar funcionário pelo nome!!! \n \n" + ex.Message);

            }
        }

        private void pnlFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);

            CarregarFuncionario();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmCadFuncionario().Show();
            Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarFuncionarioAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarFuncionarioInativo();
            }
            else
            {
                CarregarFuncionario();
            }
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            Variaveis.nomeFuncionario = txtFuncionario.Text;

            if (Variaveis.nomeFuncionario == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarFuncionarioNome();
            }
        }
    }
    }
