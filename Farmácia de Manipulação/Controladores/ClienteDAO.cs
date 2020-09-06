using System;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação.Controladores
{
    class ClienteDAO
    {
        public bool Insere(Cliente cliente)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "INSERT INTO cliente(cpf," +
                    "nome," +
                    "data_nasc," +
                    "numero," +
                    "rua," +
                    "bairro," +
                    "cidade," +
                    "telefone1," +
                    "telefone2," +
                    "email," +
                    "fk_funcionario) values(@cpf," +
                    "@nome," +
                    "@data_nasc," +
                    "@numero," +
                    "@rua," +
                    "@bairro," +
                    "@cidade," +
                    "@telefone1," +
                    "@telefone2," +
                    "@email," +
                    "@fk_funcionario)";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                conexao.comando.Parameters.AddWithValue("@nome", cliente.nome.ToUpper());
                conexao.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(cliente.data_nascimento));
                conexao.comando.Parameters.AddWithValue("@numero", cliente.numero_residencia);
                conexao.comando.Parameters.AddWithValue("@rua", cliente.rua.ToUpper());
                conexao.comando.Parameters.AddWithValue("@bairro", cliente.bairro.ToUpper());
                conexao.comando.Parameters.AddWithValue("@cidade", cliente.cidade.ToUpper());
                conexao.comando.Parameters.AddWithValue("@telefone1", cliente.tel1);
                conexao.comando.Parameters.AddWithValue("@telefone2", cliente.tel2);
                conexao.comando.Parameters.AddWithValue("@email", cliente.email);
                conexao.comando.Parameters.AddWithValue("@fk_funcionario", cliente.cpffunc);

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

        public Cliente Retorna(string cpf)
        {
            try
            {
                conexao.fecharConexao();
                conexao.abrirConexao();
                string sql = "select * from cliente where cpf = @cpf";
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cpf", cpf);
                conexao.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = conexao.comando.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Cliente(dataReader["cpf"].ToString(), dataReader["nome"].ToString(),
                    dataReader["data_nasc"].ToString(),
                    dataReader["numero"].ToString(), dataReader["rua"].ToString(), dataReader["bairro"].ToString(), dataReader["cidade"].ToString(),
                    dataReader["telefone1"].ToString(), dataReader["telefone2"].ToString(), dataReader["email"].ToString(), dataReader["fk_funcionario"].ToString());
                }
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Atualiza(Cliente cliente)
        {
            try
            {
                conexao.fecharConexao();
                conexao.abrirConexao();
                string sql = "update cliente set nome = @nome," +
                    "data_nasc = @data_nasc," +
                    "numero = @numero," +
                    "rua = @rua," +
                    "bairro = @bairro," +
                    "cidade = @cidade," +
                    "telefone1 = @telefone1," +
                    "telefone2 = @telefone2," +
                    "email = @email " +
                    "where cpf = @cpf";
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@nome", cliente.nome.ToUpper());
                conexao.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(cliente.data_nascimento));
                conexao.comando.Parameters.AddWithValue("@numero", cliente.numero_residencia);
                conexao.comando.Parameters.AddWithValue("@rua", cliente.rua.ToUpper());
                conexao.comando.Parameters.AddWithValue("@bairro", cliente.bairro.ToUpper());
                conexao.comando.Parameters.AddWithValue("@cidade", cliente.cidade.ToUpper());
                conexao.comando.Parameters.AddWithValue("@telefone1", cliente.tel1);
                conexao.comando.Parameters.AddWithValue("@telefone2", cliente.tel2);
                conexao.comando.Parameters.AddWithValue("@email", cliente.email);
                conexao.comando.Parameters.AddWithValue("@cpf", cliente.cpf);

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
                string sql = "DELETE FROM cliente WHERE cpf = @cpf";
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
