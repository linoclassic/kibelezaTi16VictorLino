using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace kibelezaTi16VictorLino
{
    public partial class frmRelatorio : Form
    {
        private void CarregarClienteTelefone()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente.\n\n" + erro.Message);
            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente.\n\n" + erro.Message);
            }
        }

        private void CarregarClienteInativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `clienteteinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente.\n\n" + erro.Message);
            }
        }


        private void CarregarEmpresaTelefone()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `empresatelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a empresa.\n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaAtiva()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a empresa.\n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaInativa()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `empresainativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a empresa.\n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioTelefone()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariotelefone";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar  telefone do funcionario.\n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioAtivo()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar funcionario.\n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioInativo()
        {

            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioinativo`" +
                    "";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar funcionario.\n\n" + erro.Message);
            }
        }

        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            pnlRelatorio.Location = new Point(this.Width / 2 - pnlRelatorio.Width / 2, this.Height / 2 - pnlRelatorio.Height / 2);
        }

        private void pnlTelefone02_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked == true && radAtivo.Checked == true)
            {
                CarregarClienteAtivo();
                Variaveis.relatorio = "Cliente Ativo";
            }
            else if (radCliente.Checked == true && radInativo.Checked == true)
            {
                CarregarClienteInativo();
                Variaveis.relatorio = "Cliente Inativo";
            }
            else if (radCliente.Checked == true && radTelefone.Checked == true)
            {
                CarregarClienteTelefone();
                Variaveis.relatorio = "Cliente Telefone";
            }
            else if (radEmpresa.Checked == true && radAtivo.Checked == true)
            {
                CarregarEmpresaAtiva();
                Variaveis.relatorio = "Empresa Ativa";
            }
            else if (radEmpresa.Checked == true && radInativo.Checked == true)
            {
                CarregarEmpresaInativa();
                Variaveis.relatorio = "Empresa Inativa";
            }
            else if (radEmpresa.Checked == true && radTelefone.Checked == true)
            {
                CarregarEmpresaTelefone();
                Variaveis.relatorio = "Empresa Telefone";
            }
            else if (radFuncionario.Checked == true && radAtivo.Checked == true)
            {
                CarregarFuncionarioAtivo();
                Variaveis.relatorio = "Funcionário Ativo";
            }
            else if (radFuncionario.Checked == true && radInativo.Checked == true)
            {
                CarregarFuncionarioInativo();
                Variaveis.relatorio = "Funcionário Ativo";
            }
            else if (radFuncionario.Checked == true && radTelefone.Checked == true)
            {
                CarregarFuncionarioInativo();
                Variaveis.relatorio = "Funcionário Ativo";
            }
            else
            {
                MessageBox.Show("Selecione uma tabela e um filtro antes de atualizar");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog(); //caixa de salvamento
                salvar.Filter = "PDF (*.pdf)|*.pdf"; //filtro em pdf
                salvar.InitialDirectory = @"C:\xampp\htdocs\kibelezaTi16\admin";
                salvar.FileName = Variaveis.relatorio + ".pdf";//nome do arquivo
                bool fileError = false; //erro de arquivo inicia em falso
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName); //deleta o arquivo existente
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possível gravar os dados no disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvRelatorio.Columns.Count); //gerar tabela em pdf
                            pdfTable.DefaultCell.Padding = 3; //margin interna na célula de 3px
                            pdfTable.WidthPercentage = 100; //largura de 100%
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; //alinhamento a esquerda              
                                                                               
                            foreach (DataGridViewColumn column in dgvRelatorio.Columns) //gerar os títulos
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dgvRelatorio.Rows) //inserir os valores
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            using (FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);//estrutura
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph titulo = new Paragraph();
                                titulo.Add("RELATÓRIO " + Variaveis.relatorio + "\n\n");
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Dados exportados com Sucesso !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Exportação não salva !!!", "Info");
            }
        }
        
    }
}