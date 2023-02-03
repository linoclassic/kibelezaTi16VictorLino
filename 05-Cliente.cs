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
            Variaveis.nomeCliente = txtCliente.Text;

            if (Variaveis.nomeCliente == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarClienteNome();
            }
        }
    }
}
