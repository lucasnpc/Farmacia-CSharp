using System;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    class CpfFuncionario
    {
        //Usar nome do funcionario nas telas de cadastro
        public static string cpfFunc;
        public string trasNomeFunc(string cpf)
        {
            string nomeFunc = "";
            try
            {
                conexao.fecharConexao();
                string sql = "select nome from funcionario where cpf = @cpf";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", cpf);
                conexao.leitor = conexao.comando.ExecuteReader();
                if (conexao.leitor.Read())
                    nomeFunc = conexao.leitor["nome"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return nomeFunc;
        }

        //Usar nome do fornecedor na tela de produtos
        public static void pegaNomeCnpjFornc(string nomeFornc)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT * FROM fornecedor WHERE nome = @nome";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@nome", nomeFornc);
                conexao.leitor = conexao.comando.ExecuteReader();
                while (conexao.leitor.Read())
                {
                    produtos.cnpjForn = conexao.leitor["cnpj"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
