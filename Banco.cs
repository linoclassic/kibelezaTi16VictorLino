 using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16VictorLino
{
    public static class Banco
    {
        // string conexão com banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=kibelezaViktor"; //local

        // public static string db = "SERVER=ipServidor;USER=nomeUsuario;PASSWORD=senha;DATABASE=nomeBanco;SSLMODE=none"; //Banco de dados remoto

        //reconhecer a biblioteca MySql
        public static MySqlConnection conexao;

        //metodo para abrir conexão
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao iniciar conexão com banco de dados","ERRO AO CONECTAR");
              
            }
            
        }

        //metodo para fechar conexão

        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
                
            }
            catch
            {

                MessageBox.Show("Erro ao desconectar a conexão com o banco de dados", "ERRO AO DESCONCTAR");
            }
            
        }
    }
}
