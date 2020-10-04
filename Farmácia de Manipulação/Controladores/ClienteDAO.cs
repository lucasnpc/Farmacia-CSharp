using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação.Controladores
{
    class ClienteDAO
    {

        public List<Cliente> getClientes() {
            List<Cliente> list = new List<Cliente>();
            Cliente cliente;
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from cliente";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Cliente()
                    {
                        cpf = dataReader["cpf"].ToString(), nome = dataReader["nome"].ToString(),
                        data_nascimento = dataReader["data_nasc"].ToString(), 
                        numero_residencia = dataReader["numero"].ToString(),
                        rua = dataReader["rua"].ToString(), bairro = dataReader["bairro"].ToString(),
                        cidade = dataReader["cidade"].ToString(), tel1 = dataReader["telefone1"].ToString(),
                        tel2 = dataReader["telefone2"].ToString(), email = dataReader["email"].ToString(),
                        cpffunc = dataReader["fk_funcionario"].ToString() 
                    });
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public bool Insere(Cliente cliente)
        {
            try
            {
                AcessoBD.fecharConexao();
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
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                AcessoBD.comando.Parameters.AddWithValue("@nome", cliente.nome.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(cliente.data_nascimento));
                AcessoBD.comando.Parameters.AddWithValue("@numero", cliente.numero_residencia);
                AcessoBD.comando.Parameters.AddWithValue("@rua", cliente.rua.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@bairro", cliente.bairro.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@cidade", cliente.cidade.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@telefone1", cliente.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@telefone2", cliente.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", cliente.email);
                AcessoBD.comando.Parameters.AddWithValue("@fk_funcionario", cliente.cpffunc);

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

        /*public Cliente Retorna(string cpf)
        {
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from cliente where cpf = @cpf";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cpf);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Cliente(dataReader["cpf"].ToString(), dataReader["nome"].ToString(),
                    dataReader["data_nasc"].ToString(), dataReader["numero"].ToString(), 
                    dataReader["rua"].ToString(), dataReader["bairro"].ToString(), dataReader["cidade"].ToString(),
                    dataReader["telefone1"].ToString(), dataReader["telefone2"].ToString(), 
                    dataReader["email"].ToString(), dataReader["fk_funcionario"].ToString());
                }
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        public bool Atualiza(Cliente cliente)
        {
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
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
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@nome", cliente.nome.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(cliente.data_nascimento));
                AcessoBD.comando.Parameters.AddWithValue("@numero", cliente.numero_residencia);
                AcessoBD.comando.Parameters.AddWithValue("@rua", cliente.rua.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@bairro", cliente.bairro.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@cidade", cliente.cidade.ToUpper());
                AcessoBD.comando.Parameters.AddWithValue("@telefone1", cliente.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@telefone2", cliente.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", cliente.email);
                AcessoBD.comando.Parameters.AddWithValue("@cpf", cliente.cpf);

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
                string sql = "DELETE FROM cliente WHERE cpf = @cpf";
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
