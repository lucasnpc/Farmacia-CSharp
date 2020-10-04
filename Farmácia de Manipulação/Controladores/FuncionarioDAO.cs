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
                AcessoBD.fecharConexao();
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
                AcessoBD.abrirConexao();
                AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                AcessoBD.comando.Parameters.AddWithValue("@nome", funcionario.nome.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(funcionario.data_nascimento));
                AcessoBD.comando.Parameters.AddWithValue("@numero", funcionario.numero_residencia);
                AcessoBD.comando.Parameters.AddWithValue("@rua", funcionario.rua.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@bairro", funcionario.bairro.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@cidade", funcionario.cidade.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@telefone1", funcionario.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@telefone2", funcionario.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", funcionario.email);
                AcessoBD.comando.Parameters.AddWithValue("@usuario", funcionario.usuario);
                AcessoBD.comando.Parameters.AddWithValue("@senha", funcionario.senha);
                AcessoBD.comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                AcessoBD.comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(funcionario.data_admissao));

                if (AcessoBD.comando.ExecuteNonQuery() == 1)
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
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from funcionario where cpf = @cpf";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cpf);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
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
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
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
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@nome", funcionario.nome);
                AcessoBD.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(funcionario.data_nascimento));
                AcessoBD.comando.Parameters.AddWithValue("@numero", funcionario.numero_residencia);
                AcessoBD.comando.Parameters.AddWithValue("@rua", funcionario.rua);
                AcessoBD.comando.Parameters.AddWithValue("@bairro", funcionario.bairro);
                AcessoBD.comando.Parameters.AddWithValue("@cidade", funcionario.cidade);
                AcessoBD.comando.Parameters.AddWithValue("@telefone1", funcionario.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@telefone2", funcionario.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", funcionario.email);
                AcessoBD.comando.Parameters.AddWithValue("@usuario", funcionario.usuario);
                AcessoBD.comando.Parameters.AddWithValue("@senha", funcionario.senha);
                AcessoBD.comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                AcessoBD.comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(funcionario.data_admissao));
                AcessoBD.comando.Parameters.AddWithValue("@cpf", funcionario.cpf);

                if (AcessoBD.comando.ExecuteNonQuery() == 1)
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
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "DELETE FROM funcionario WHERE cpf = @cpf";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cpf);
                if (AcessoBD.comando.ExecuteNonQuery() == 1)
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
