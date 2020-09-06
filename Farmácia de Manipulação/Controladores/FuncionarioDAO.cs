using System;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação.Controladores
{
    class FuncionarioDAO
    {
        public bool Insere(Funcionario funcionario)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "INSERT INTO funcionario(cpf," +
                       "nome," +
                       "data_nasc," +
                       "numero," +
                       "rua," +
                       "bairro," +
                       "cidade," +
                       "telefone1," +
                       "telefone2," +
                       "email," +
                       "usuario," +
                       "senha," +
                       "cargo," +
                       "data_admissao) values(@cpf," +
                       "@nome," +
                       "@data_nasc," +
                       "@numero," +
                       "@rua," +
                       "@bairro," +
                       "@cidade," +
                       "@telefone1," +
                       "@telefone2," +
                       "@email," +
                       "@usuario," +
                       "@senha," +
                       "@cargo," +
                       "@data_admissao)";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                conexao.comando.Parameters.AddWithValue("@nome", funcionario.nome.ToUpper());
                conexao.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(funcionario.data_nascimento));
                conexao.comando.Parameters.AddWithValue("@numero", funcionario.numero_residencia);
                conexao.comando.Parameters.AddWithValue("@rua", funcionario.rua.ToUpper());
                conexao.comando.Parameters.AddWithValue("@bairro", funcionario.bairro.ToUpper());
                conexao.comando.Parameters.AddWithValue("@cidade", funcionario.cidade.ToUpper());
                conexao.comando.Parameters.AddWithValue("@telefone1", funcionario.tel1);
                conexao.comando.Parameters.AddWithValue("@telefone2", funcionario.tel2);
                conexao.comando.Parameters.AddWithValue("@email", funcionario.email);
                conexao.comando.Parameters.AddWithValue("@usuario", funcionario.usuario);
                conexao.comando.Parameters.AddWithValue("@senha", funcionario.senha);
                conexao.comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                conexao.comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(funcionario.data_admissao));

                if (conexao.comando.ExecuteNonQuery() == 1)
                { return true; }
                else
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public Funcionario Retorna(string cpf) {
            try
            {
                conexao.fecharConexao();
                conexao.abrirConexao();
                string sql = "select * from funcionario where cpf = @cpf";
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", cpf);
                conexao.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = conexao.comando.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Funcionario(dataReader["cpf"].ToString(), dataReader["nome"].ToString(),
                    dataReader["data_nasc"].ToString(),
                    dataReader["numero"].ToString(), dataReader["rua"].ToString(), dataReader["bairro"].ToString(), dataReader["cidade"].ToString(),
                    dataReader["telefone1"].ToString(), dataReader["telefone2"].ToString(), dataReader["email"].ToString(), dataReader["usuario"].ToString(),
                    dataReader["senha"].ToString(), dataReader["cargo"].ToString(), dataReader["data_admissao"].ToString());
                }
                else
                    return null;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Atualiza(Funcionario funcionario)
        {
            try
            {
                conexao.fecharConexao();
                conexao.abrirConexao();
                string sql = "update funcionario set nome = @nome," +
                       "data_nasc = @data_nasc," +
                       "numero = @numero," +
                       "rua = @rua," +
                       "bairro = @bairro," +
                       "cidade = @cidade," +
                       "telefone1 = @telefone1," +
                       "telefone2 = @telefone2," +
                       "email = @email," +
                       "usuario = @usuario," +
                       "senha = @senha," +
                       "cargo = @cargo," +
                       "data_admissao = @data_admissao " +
                       "where cpf = @cpf";
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@nome", funcionario.nome);
                conexao.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(funcionario.data_nascimento));
                conexao.comando.Parameters.AddWithValue("@numero", funcionario.numero_residencia);
                conexao.comando.Parameters.AddWithValue("@rua", funcionario.rua);
                conexao.comando.Parameters.AddWithValue("@bairro", funcionario.bairro);
                conexao.comando.Parameters.AddWithValue("@cidade", funcionario.cidade);
                conexao.comando.Parameters.AddWithValue("@telefone1", funcionario.tel1);
                conexao.comando.Parameters.AddWithValue("@telefone2", funcionario.tel2);
                conexao.comando.Parameters.AddWithValue("@email", funcionario.email);
                conexao.comando.Parameters.AddWithValue("@usuario", funcionario.usuario);
                conexao.comando.Parameters.AddWithValue("@senha", funcionario.senha);
                conexao.comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                conexao.comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(funcionario.data_admissao));
                conexao.comando.Parameters.AddWithValue("@cpf", funcionario.cpf);

                if (conexao.comando.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Deleta(string cpf)
        {
            try
            {
                conexao.fecharConexao();
                conexao.abrirConexao();
                string sql = "DELETE FROM funcionario WHERE cpf = @cpf";
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", cpf);
                if (conexao.comando.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
