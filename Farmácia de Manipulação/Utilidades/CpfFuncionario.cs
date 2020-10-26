using System;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    class CpfFuncionario
    {
        public static string cpfFunc;
        public static bool administrador = false;

        //Usar nome do funcionario nas telas de cadastro
        public string GetNomeFuncionario(string cpf)
        {
            string nomeFunc = "";
            try
            {
                AcessoBD.fecharConexao();
                string sql = "select nome from funcionarios where cpf = @cpf";
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
        public string GetCnpjFornecedor(string nomeFornc)
        {
            string cnpj;
            try
            {
                AcessoBD.fecharConexao();
                string sql = "SELECT * FROM fornecedores WHERE nome = @nome";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@nome", nomeFornc);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();
                if (AcessoBD.leitor.Read())
                {
                    cnpj = AcessoBD.leitor["cnpj"].ToString();
                    return cnpj;
                }
                else
                    return "";
            }
            catch (Exception) { throw; }
        }

        //Trazer CPF do funcionario
        public void GetCpfFunc(string usuario)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "select cpf from funcionarios where usuario = @usuario";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@usuario", usuario);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

                if (AcessoBD.leitor.Read())
                {
                    cpfFunc = AcessoBD.leitor["cpf"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
