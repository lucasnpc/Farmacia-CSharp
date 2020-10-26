using Farmácia_de_Manipulação.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação.Controladores
{
    class FornecedorDAO
    {
        public List<Fornecedor> GetFornecedores() {
            List<Fornecedor> list = new List<Fornecedor>();
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from fornecedores";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader reader = AcessoBD.comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Fornecedor
                    {
                        cnpj = reader["cnpj"].ToString(),
                        nome = reader["nome"].ToString(),
                        tel1 = reader["tel1"].ToString(),
                        tel2 = reader["tel2"].ToString(),
                        numero = reader["numero"].ToString(),
                        rua = reader["rua"].ToString(),
                        bairro = reader["bairro"].ToString(),
                        cidade = reader["cidade"].ToString(),
                        email = reader["email"].ToString(),
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        public bool Insere(Fornecedor fornecedor)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO fornecedores(cnpj," +
                    "nome," +
                    "rua," +
                    "numero," +
                    "bairro," +
                    "cidade," +
                    "tel1," +
                    "tel2," +
                    "email)" +
                    " values(@cnpj," +
                    "@nome," +
                    "@rua," +
                    "@numero," +
                    "@bairro," +
                    "@cidade," +
                    "@tel1," +
                    "@tel2," +
                    "@email)";
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                AcessoBD.comando.Parameters.AddWithValue("@nome", fornecedor.nome);
                AcessoBD.comando.Parameters.AddWithValue("@rua", fornecedor.rua);
                AcessoBD.comando.Parameters.AddWithValue("@numero", fornecedor.numero);
                AcessoBD.comando.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                AcessoBD.comando.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                AcessoBD.comando.Parameters.AddWithValue("@tel1", fornecedor.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@tel2", fornecedor.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", fornecedor.email);

                if (AcessoBD.comando.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Atualiza(Fornecedor fornecedor)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "UPDATE fornecedores SET nome = @nome," +
                    "numero = @numero," +
                    "rua = @rua," +
                    "bairro = @bairro," +
                    "cidade = @cidade," +
                    "tel1 = @tel1," +
                    "tel2 = @tel2," +
                    "email = @email " +
                    "WHERE cnpj = @cnpj";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@nome", fornecedor.nome);
                AcessoBD.comando.Parameters.AddWithValue("@numero", fornecedor.numero);
                AcessoBD.comando.Parameters.AddWithValue("@rua", fornecedor.rua);
                AcessoBD.comando.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                AcessoBD.comando.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                AcessoBD.comando.Parameters.AddWithValue("@tel1", fornecedor.tel1);
                AcessoBD.comando.Parameters.AddWithValue("@tel2", fornecedor.tel2);
                AcessoBD.comando.Parameters.AddWithValue("@email", fornecedor.email);
                AcessoBD.comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);

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
        public bool Deleta(string cnpj)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "DELETE FROM fornecedores WHERE cnpj = @cnpj";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@cnpj", cnpj);
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
