using Farmácia_de_Manipulação.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação.Controladores
{
    class VendaDAO
    {
        public List<Venda> GetVendas()
        {
            List<Venda> list = new List<Venda>();
            try
            {
                AcessoBD.fecharConexao();
                AcessoBD.abrirConexao();
                string sql = "select * from vendas";
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader dataReader = AcessoBD.comando.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Venda()
                    {
                        cod_venda = dataReader["cod_venda"].ToString(),
                        cod_produto = dataReader["fk_produto"].ToString(),
                        cod_cliente = dataReader["fk_cliente"].ToString(),
                        cod_funcionario = dataReader["fk_funcionario"].ToString(),
                        quantidade = int.Parse(dataReader["quantidade"].ToString()),
                        valor_venda = double.Parse(dataReader["valor_venda"].ToString())
                    }) ;
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        public bool Insere(Venda venda)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO vendas(fk_produto," +
                    "fk_cliente," +
                    "fk_funcionario," +
                    "quantidade," +
                    "valor_venda) values(@fk_produto," +
                    "@fk_cliente," +
                    "@fk_funcionario," +
                    "@quantidade," +
                    "@valor_venda)";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@fk_produto", venda.cod_produto);
                AcessoBD.comando.Parameters.AddWithValue("@fk_cliente", venda.cod_cliente) ;
                AcessoBD.comando.Parameters.AddWithValue("@fk_funcionario", venda.cod_funcionario);
                AcessoBD.comando.Parameters.AddWithValue("@quantidade", venda.quantidade);
                AcessoBD.comando.Parameters.AddWithValue("@valor_venda", venda.valor_venda);

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
    }
}
