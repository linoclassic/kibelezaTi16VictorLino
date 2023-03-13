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
    public partial class frmMenuPrincipal : Form
    {

        private void CarregarReserva()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `reservadata` WHERE `CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReserva.DataSource = dt;
                dgvReserva.Columns[0].Visible = false;
                dgvReserva.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a Reserva.\n\n" + erro.Message);

            }
        }

        private void CarregarReservaStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `reservadata` WHERE `STATUS` = @status AND `CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReserva.DataSource = dt;
                dgvReserva.Columns[0].Visible = false;
                dgvReserva.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a Reserva.\n\n" + erro.Message);
            }
        }


        private void AlterarStatus()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `reserva` SET `statusReserva`'=@status WHERE `idReserva`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReserva.DataSource = dt;
                dgvReserva.ClearSelection();

                MessageBox.Show("A reserva" + Variaveis.codReserva + " foi alterada para " + Variaveis.statusReserva);
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar o status da reserva.\n\n" + erro.Message);
            }
        }




        int hora = DateTime.Now.Hour;
        int clickReserva;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlMenuPrincipal.Location = new Point(this.Width / 2 - pnlMenuPrincipal.Width / 2, this.Height / 2 - pnlMenuPrincipal.Height / 2);

            cmbStatus.SelectedIndex = 0;
            Variaveis.linhaSelecionada = -1;
            CarregarReserva();

            timer1.Start();

            if (hora >= 6 && hora < 12)
            {
                lblMensagem.Text = "Bom dia " + Variaveis.usuario + "!";
            }
            else if (hora >= 12 && hora < 18)
            {
                lblMensagem.Text = "Boa tarde " + Variaveis.usuario + "!";
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
                pctEmpresa.Enabled = true;
            }



        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
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
            if (clickReserva == 0)
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

            Variaveis.statusReserva = "APROVADA";
            AlterarStatus();
            Variaveis.statusReserva = cmbStatus.Text;
            Variaveis.nomeCliente = txtCliente.Text;
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }

            else
            {
                CarregarReservaStatus();
            }

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

        private void pctEmpresa_Click_1(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void pctFuncionario_Click_1(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Variaveis.statusReserva = cmbStatus.Text; Variaveis.nomeCliente = txtCliente.Text;
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }

            else
            {
                CarregarReservaStatus();
            }

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variaveis.statusReserva = cmbStatus.Text;
            Variaveis.nomeCliente = txtCliente.Text; if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }

            else
            {
                CarregarReservaStatus();
            }
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codReserva = Convert.ToInt32(dgvReserva[0, Variaveis.linhaSelecionada].Value);
            }
             
        }

        private void dgvReserva_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvReserva.Sort(dgvReserva.Columns[1], ListSortDirection.Ascending);
            dgvReserva.ClearSelection();
        }
    }
}