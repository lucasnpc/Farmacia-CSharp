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
    class ProdutoDAO
    {
        public bool Insere(Models.Produto produto)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO produto(descricao," +
                    "codigo," +
                    "lote," +
                    "data_fabricacao," +
                    "data_validade," +
                    "recomendacoes," +
                    "quantidade," +
                    "segmento," +
                    "valor_custo," +
                    "valor_venda," +
                    "estoquemin,estoquemax," +
                    "fk_fornecedor) " +
                    "values(@descricao," +
                    "@codigo," +
                    "@lote," +
                    "@data_fabricacao," +
                    "@data_validade," +
                    "@recomendacoes," +
                    "@quantidade," +
                    "@segmento," +
                    "@valor_custo,@valor_venda," +
                    "@estoquemin,@estoquemax," +
                    "@fk_fornecedor)";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@descricao", produto.descricao);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", produto.codigo);
                AcessoBD.comando.Parameters.AddWithValue("@lote", produto.lote);
                AcessoBD.comando.Parameters.AddWithValue("@data_fabricacao", Convert.ToDateTime(produto.data_fabricacao));
                AcessoBD.comando.Parameters.AddWithValue("@data_validade", Convert.ToDateTime(produto.data_validade));
                AcessoBD.comando.Parameters.AddWithValue("@recomendacoes", produto.recomendacoes);
                AcessoBD.comando.Parameters.AddWithValue("@quantidade", produto.quantidade);
                AcessoBD.comando.Parameters.AddWithValue("@segmento", produto.segmento);
                AcessoBD.comando.Parameters.AddWithValue("@valor_custo", produto.valor_custo);
                AcessoBD.comando.Parameters.AddWithValue("@valor_venda", produto.valor_venda);
                AcessoBD.comando.Parameters.AddWithValue("@estoquemin", produto.estoqueminimo);
                AcessoBD.comando.Parameters.AddWithValue("@estoquemax", produto.estoquemaximo);
                AcessoBD.comando.Parameters.AddWithValue("@fk_fornecedor", produto.cnpjfornecedor);

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

        public List<Models.Produto> GetProdutos()
        {
            List<Models.Produto> list = new List<Models.Produto>();

            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from produto";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Models.Produto
                    {
                        codigo = dataReader["codigo"].ToString(),
                        descricao = dataReader["descricao"].ToString(),
                        lote = dataReader["lote"].ToString(),
                        data_fabricacao = dataReader["data_fabricacao"].ToString(),
                        data_validade = dataReader["data_validade"].ToString(),
                        recomendacoes = dataReader["recomendacoes"].ToString(),
                        quantidade = int.Parse(dataReader["quantidade"].ToString()),
                        segmento = dataReader["segmento"].ToString(),
                        valor_custo = double.Parse(dataReader["valor_custo"].ToString()),
                        valor_venda = double.Parse(dataReader["valor_venda"].ToString()),
                        estoqueminimo = int.Parse(dataReader["estoquemin"].ToString()),
                        estoquemaximo = int.Parse(dataReader["estoquemax"].ToString()),
                        cnpjfornecedor = dataReader["fk_fornecedor"].ToString()
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

        public bool Atualiza(Models.Produto produto)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "UPDATE produto SET descricao = @descricao," +
                    "data_fabricacao = @data_fabricacao," +
                    "data_validade = @data_validade," +
                    "recomendacoes = @recomendacoes," +
                    "quantidade = @quantidade," +
                    "segmento = @segmento," +
                    "valor_custo = @valor_custo," +
                    "valor_venda = @valor_venda," +
                    "estoquemin = @estoquemin," +
                    "estoquemax = @estoquemax " +
                    "WHERE codigo = @codigo";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", produto.codigo);
                AcessoBD.comando.Parameters.AddWithValue("@descricao", produto.descricao);
                AcessoBD.comando.Parameters.AddWithValue("@data_fabricacao", Convert.ToDateTime(produto.data_fabricacao));
                AcessoBD.comando.Parameters.AddWithValue("@data_validade", Convert.ToDateTime(produto.data_validade));
                AcessoBD.comando.Parameters.AddWithValue("@recomendacoes", produto.recomendacoes);
                AcessoBD.comando.Parameters.AddWithValue("@quantidade", produto.quantidade);
                AcessoBD.comando.Parameters.AddWithValue("@segmento", produto.segmento);
                AcessoBD.comando.Parameters.AddWithValue("@estoquemin", produto.estoqueminimo);
                AcessoBD.comando.Parameters.AddWithValue("@estoquemax", produto.estoquemaximo);
                AcessoBD.comando.Parameters.AddWithValue("@valor_custo", produto.valor_custo);
                AcessoBD.comando.Parameters.AddWithValue("@valor_venda", produto.valor_venda);


                if (AcessoBD.comando.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Deleta(string codProduto)
        {
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "DELETE FROM produto WHERE codigo = @codigo";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", codProduto);
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
