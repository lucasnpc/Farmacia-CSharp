using System;
using System.Collections.Generic;
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
                string sql = "INSERT INTO funcionarios(cpf," +
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
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
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

        public List<Funcionario> GetFuncionarios() {
            List<Funcionario> list = new List<Funcionario>();

            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from funcionarios";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Funcionario
                    {
                        cpf = dataReader["cpf"].ToString(),
                        nome = dataReader["nome"].ToString(),
                        data_nascimento = dataReader["data_nasc"].ToString(),
                        numero_residencia = dataReader["numero"].ToString(),
                        rua = dataReader["rua"].ToString(),
                        bairro = dataReader["bairro"].ToString(),
                        cidade = dataReader["cidade"].ToString(),
                        tel1 = dataReader["telefone1"].ToString(),
                        tel2 = dataReader["telefone2"].ToString(),
                        email = dataReader["email"].ToString(),
                        usuario = dataReader["usuario"].ToString(),
                        senha = dataReader["senha"].ToString(),
                        cargo = dataReader["cargo"].ToString(),
                        data_admissao = dataReader["data_admissao"].ToString()
                    });
                }
                dataReader.Close();
            }
            catch(Exception)
            {
                throw;
            }
            return list;
        }

        public bool Atualiza(Funcionario funcionario)
        {
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "update funcionarios set nome = @nome," +
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
                string sql = "DELETE FROM funcionarios WHERE cpf = @cpf";
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
