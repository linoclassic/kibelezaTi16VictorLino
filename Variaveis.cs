using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace kibelezaTi16VictorLino
{
    public static class Variaveis
    {
        // Geral
        public static string funcao;
        public static int linhaSelecionada;


        // Login
        public static string usuario, senha, nivel;

        //Empresa
        public static int codEmpresa;

        public static string nomeEmpresa, cnpjCpfEmpresa, razaoSocialEmpresa, emailEmpresa, statusEmpresa;

        public static DateTime dataCadastroEmpresa, horarioAtendimentoEmpresa;

        //Cliente
        public static int codCliente;

        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente, caminhoFotoCLiente;

        public static DateTime dataCadastroCliente;

        //Funcionario
        public static int codFuncionario;

        public static string nomeFuncionario, emailFuncionario, statusFuncionario;

        public static DateTime dataCadastroFuncionario;

        //Fone Empresa
        public static int codFoneEmpresa;
        public static string numeroFoneEmpresa, operadoraEmpresa, descricaoEmpresa;

        //Fone Cliente
        public static int codFoneCliente;
        public static string numeroFoneCliente, operadoraCliente, descricaoCliente;

        //FoneCliente
        public static string enderecoServicoFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp = "ti16";
        public static string senhaFtp = "1234";

        //servico
        public static int codServico;
        public static string nomeServico;


        //reserva 
        public static int codReserva;
        public static string obsReserva, statusReserva;
        public static DateTime dataReserva, horarioReserva;

        //relatorio
        public static string relatorio;

    }




}
