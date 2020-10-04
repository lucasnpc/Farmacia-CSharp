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
                AcessoBD.fecharConexao();
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
                AcessoBD.comando.Parameters.AddWithValue("@fk_funcionario", fornecedor.cpf_funcionario);

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
    }
}
