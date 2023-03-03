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
    public partial class frmReserva : Form
    {

        private void InserirReserva()
        {
            try
            {

                Banco.Conectar();
                string inserir = "INSERT INTO `reserva` (`idReserva` obsReserva `dataReserva` `horaReserva` `statusReserva`, `idFuncionario`, `idCliente`, `idServico`) VALUES (DEFAULT, @obs, @dataReserva, @horaReserva, @status, @codFuncionario, @codCliente, @codServico)";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico); cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva cadastrada com sucesso!", "CADASTRO DA RESERVA");
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar a Reserva!\n\n" + erro, "ERRO!");
            }
        }

        private void AlterarReserva()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `reserva` SET `obsReserva`= @obs, `dataReserva`=@dataReserva, `horaReserva`= @horaReserva, `statusReserva`= @status, `idFuncionario `= @codFuncionario, `idCliente`= @codCliente, `idServico `= @codServico WHERE `idReserva`= @codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);

                cmd.ExecuteNonQuery(); MessageBox.Show("Reserva alterada com sucesso!", "ALTERAÇÃO DA RESERVA");
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar a Reserva!\n\n" + erro, "ERRO!");

            }
        }

        private void CarregarDadosReserva()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `idReserva`, `obsReserva`, `dataReserva`, DATE_FORMAT(`horaReserva`, '%H:%i'), `statusReserva`, `nomeFuncionario`, `nomeCliente`, `nomeServico` FROM `reserva` INNER JOIN `funcionario` ON `reserva`.`idFuncionario` = `funcionario`.`idFuncionario` INNER JOIN `cliente` ON `reserva`.`idCliente` = `cliente`.`idCliente` INNER JOIN `servico` ON `reserva`.`idServico` = `servico`.`idServico` WHERE `idReserva` = @codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.obsReserva = reader.GetString(1);
                    Variaveis.dataReserva = reader.GetDateTime(2);
                    Variaveis.horarioReserva = DateTime.Parse(reader.GetString(3));
                    Variaveis.statusReserva = reader.GetString(4);
                    Variaveis.nomeFuncionario = reader.GetString(5);
                    Variaveis.nomeCliente = reader.GetString(5);
                    Variaveis.nomeServico = reader.GetString(7);
                    txtCodigo.Text = Variaveis.codReserva.ToString();
                    txtObservacao.Text = Variaveis.codReserva.ToString();
                    calReserva.SelectionStart = Variaveis.dataReserva;
                    cmbHorario.Text = Variaveis.horarioReserva.ToString("HH:mm");
                    cmbStatus.Text = Variaveis.statusReserva;
                    cmbFuncionario.Text = Variaveis.nomeFuncionario;
                    cmbCliente.Text = Variaveis.nomeCliente;
                    cmbServico.Text = Variaveis.nomeServico;

                }
                Banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados da reserva!\n\n" + erro, "ERRO");
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT idFuncionario, nomeFuncionario FROM funcionario ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeFuncionario";
                cmbFuncionario.ValueMember = "idFuncionario";
                cmbFuncionario.SelectedIndex = -1;
                Banco.Desconectar();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao carregar a lista de funcionários.\n\n" + ex.Message);
            }
        }


        private void CarregarClientes()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT idCliente, nomeCliente FROM cliente ORDER BY nomeCliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeCliente";
                cmbFuncionario.ValueMember = "idCliente";
                cmbFuncionario.SelectedIndex = -1;
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Clientes.\n\n" + ex.Message);
            }
        }
        private void CarregarServicos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT idServico, nomeServico FROM servicoeric ORDER BY nomeServico";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeServico";
                cmbFuncionario.ValueMember = "idServico";
                cmbFuncionario.SelectedIndex = -1;
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Serviços.\n\n" + ex.Message);
            }
        }

        private void CarregarHorarioDisponivel()
        {
            try
            {
                Banco.Conectar();
                var sql = "SELECT idHorarioReserva, DATE_FORMAT(horarioReserva, '%H:%i') FROM horariosreserva WHERE DATE_FORMAT(horarioReserva, '%H:%i') NOT IN (SELECT DATE_FORMAT(horaReserva, '%H:%i') FROM reserva WHERE idFuncionario = @codFuncionario AND dataReserva = @dataReserva AND NOT idReserva = @codReserva) ORDER BY horarioReserva";
                MySqlCommand cmd = new MySqlCommand(sql, Banco.conexao);
                cmd.Parameters.AddWithValue("@codReserva", Variaveis.codReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Convert.ToInt32
                (cmbFuncionario.SelectedValue));
                cmd.Parameters.AddWithValue("@dataReserva", Convert.ToDateTime(calReserva.SelectionStart.ToShortDateString()));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbHorario.DataSource = dt;
                cmbHorario.DisplayMember = "DATE_FORMAT(horarioReserva,'%H:%i')"; //campo que precisa mostrar
                cmbHorario.ValueMember = "idHorarioReserva"; //valor associado ao nome
                cmbHorario.SelectedIndex = -1;
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os horários disponíveis.\n\n" + erro, "ERRO");
            }
        }



        public frmReserva()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            pnlReserva.Location = new Point(this.Width / 2 - pnlReserva.Width / 2, this.Height / 2 - pnlReserva.Height / 2);

            calReserva.MinDate = DateTime.Now;
            calReserva.MaxDate = DateTime.Now.AddDays(31);

            CarregarFuncionarios();
            CarregarClientes();
            CarregarServicos();

            if (Variaveis.funcao == "EDITAR")
            {
                lblReserva.Text = "EDITAR RESERVA";
                CarregarDadosReserva();
                CarregarHorarioDisponivel();


            }
        }

        private void cmbFuncionario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarHorarioDisponivel();
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCliente.Enabled = true;
                CarregarHorarioDisponivel();
                cmbCliente.Focus();
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbServico.Enabled = true;
                CarregarHorarioDisponivel();
                cmbServico.Focus();
            }
        }
        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }
        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calReserva.Enabled = true;
                calReserva.Focus();
            }
        }
        private void calReserva_DateSelected(object sender, DateRangeEventArgs e)
        {
            Variaveis.dataReserva = calReserva.SelectionStart;
            cmbHorario.Enabled = true;
            cmbHorario.Focus();
            CarregarHorarioDisponivel();
        }

        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnSalvar.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtObservacao.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1; 
            txtObservacao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
                if (txtObservacao.Text == String.Empty)
                {
                    MessageBox.Show("Favor preencher a Observação da Reserva");
                    txtObservacao.Focus();
                }
                else if (cmbHorario.Text == String.Empty)
                {
                    MessageBox.Show("Favor escolher um Horário");
                    cmbHorario.Focus();
                }
                else if (cmbStatus.Text == String.Empty)
                {
                    MessageBox.Show("Favor selecionar o Status");
                    cmbStatus.Focus();
                }
                else if (cmbFuncionario.Text == String.Empty)
                {
                    MessageBox.Show("Favor selecionar o Funcionário");
                    cmbFuncionario.Focus();
                }
                else if (cmbCliente.Text == String.Empty)
                {
                    MessageBox.Show("Favor selecionar o Cliente");
                    cmbCliente.Focus();
                }
                else if (cmbServico.Text == String.Empty)
                {
                    MessageBox.Show("Favor selecionar o Serviço");
                    cmbServico.Focus();
                }
                else
                {
                    Variaveis.obsReserva = txtObservacao.Text;
                    Variaveis.dataReserva = calReserva.SelectionStart;
                    Variaveis.horarioReserva = DateTime.Parse(cmbHorario.Text);
                    Variaveis.statusReserva = cmbStatus.Text;
                    Variaveis.codFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
                    Variaveis.codCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    Variaveis.codServico = Convert.ToInt32(cmbServico.SelectedValue); if (Variaveis.funcao == "AGENDAR")
                    {
                        InserirReserva();
                    }
                    else if (Variaveis.funcao == "EDITAR")
                    {
                        AlterarReserva();
                    }
                    btnSalvar.Enabled = false;
                    btnLimpar.Enabled = false;
                }
            }
        }
    }
