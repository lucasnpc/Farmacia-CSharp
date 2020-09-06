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
        public bool Insere(Fornecedor fornecedor)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "INSERT INTO fornecedor(cnpj," +
                    "nome," +
                    "rua," +
                    "numero," +
                    "bairro," +
                    "cidade," +
                    "tel1," +
                    "tel2," +
                    "email," +
                    "fk_funcionario) values(@cnpj," +
                    "@nome," +
                    "@rua," +
                    "@numero," +
                    "@bairro," +
                    "@cidade," +
                    "@tel1," +
                    "@tel2," +
                    "@email," +
                    "@fk_funcionario)";
                conexao.fecharConexao();
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                conexao.comando.Parameters.AddWithValue("@nome", fornecedor.nome);
                conexao.comando.Parameters.AddWithValue("@rua", fornecedor.rua);
                conexao.comando.Parameters.AddWithValue("@numero", fornecedor.numero);
                conexao.comando.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                conexao.comando.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                conexao.comando.Parameters.AddWithValue("@tel1", fornecedor.tel1);
                conexao.comando.Parameters.AddWithValue("@tel2", fornecedor.tel2);
                conexao.comando.Parameters.AddWithValue("@email", fornecedor.email);
                conexao.comando.Parameters.AddWithValue("@fk_funcionario", fornecedor.cpf_funcionario);

                if (conexao.comando.ExecuteNonQuery() == 1)
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
    }
}
