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
                AcessoBD.fecharConexao();
                string sql = "select nome from funcionario where cpf = @cpf";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cpf);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();
                if (AcessoBD.leitor.Read())
                    nomeFunc = AcessoBD.leitor["nome"].ToString();
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
                AcessoBD.fecharConexao();
                string sql = "SELECT * FROM fornecedor WHERE nome = @nome";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@nome", nomeFornc);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();
                while (AcessoBD.leitor.Read())
                {
                    produtos.cnpjForn = AcessoBD.leitor["cnpj"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
