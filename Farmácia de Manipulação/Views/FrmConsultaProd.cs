using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class consultaProduto : Form
    {
        public consultaProduto()
        {
            InitializeComponent();
        }

        public static string codProd;
        List<Produto> produtos = new List<Produto>();

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            produtos = new ProdutoDAO().GetProdutos();

            DataTable dt = new DataTable();
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Lote", typeof(string));
            dt.Columns.Add("Data de fabricação", typeof(string));
            dt.Columns.Add("Data de Validade", typeof(string));
            dt.Columns.Add("Recomendações", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Segmento", typeof(string));
            dt.Columns.Add("Valor custo", typeof(string));
            dt.Columns.Add("Valor venda", typeof(string));
            dt.Columns.Add("Estoque Mínimo", typeof(string));
            dt.Columns.Add("Estoque Máximo", typeof(string));

            foreach (Produto p in produtos)
            {
                DataRow dr = dt.NewRow();
                dr["Código"] = p.codigo;
                dr["Descrição"] = p.descricao;
                dr["Lote"] = p.lote;
                dr["Data de fabricação"] = Convert.ToDateTime(p.data_fabricacao).ToShortDateString();
                dr["Data de validade"] = Convert.ToDateTime(p.data_validade).ToShortDateString();
                dr["Recomendações"] = p.recomendacoes;
                dr["Quantidade"] = p.quantidade.ToString();
                dr["Segmento"] = p.segmento;
                dr["Valor custo"] = p.valor_custo.ToString();
                dr["Valor venda"] = p.valor_venda.ToString();
                dr["Estoque Mínimo"] = p.estoqueminimo.ToString();
                dr["Estoque Máximo"] = p.estoquemaximo.ToString();

                dt.Rows.Add(dr);
            }
            gridConsultaProd.DataSource = dt;
            gridConsultaProd.Update();
        }
        // Fim cadastro


        private void consultaProduto_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codProd = gridConsultaProd.CurrentRow.Cells[0].Value.ToString();
            produto.codProduto = codProd;
            Close();
        }

        private void tbPesqProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqProd.Text != string.Empty)
                {
                    IEnumerable<Produto> consultaProdutos =
                        from produto in produtos
                        where produto.descricao.StartsWith(tbPesqProd.Text.ToUpper())
                        select produto;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Código", typeof(string));
                    dt.Columns.Add("Descrição", typeof(string));
                    dt.Columns.Add("Lote", typeof(string));
                    dt.Columns.Add("Data de fabricação", typeof(string));
                    dt.Columns.Add("Data de Validade", typeof(string));
                    dt.Columns.Add("Recomendações", typeof(string));
                    dt.Columns.Add("Quantidade", typeof(string));
                    dt.Columns.Add("Segmento", typeof(string));
                    dt.Columns.Add("Valor custo", typeof(string));
                    dt.Columns.Add("Valor venda", typeof(string));
                    dt.Columns.Add("Estoque Mínimo", typeof(string));
                    dt.Columns.Add("Estoque Máximo", typeof(string));

                    foreach (Produto p in consultaProdutos)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Código"] = p.codigo;
                        dr["Descrição"] = p.descricao;
                        dr["Lote"] = p.lote;
                        dr["Data de fabricação"] = Convert.ToDateTime(p.data_fabricacao).ToShortDateString();
                        dr["Data de validade"] = Convert.ToDateTime(p.data_validade).ToShortDateString();
                        dr["Recomendações"] = p.recomendacoes;
                        dr["Quantidade"] = p.quantidade.ToString();
                        dr["Segmento"] = p.segmento;
                        dr["Valor custo"] = p.valor_custo.ToString();
                        dr["Valor venda"] = p.valor_venda.ToString();
                        dr["Estoque Mínimo"] = p.estoqueminimo.ToString();
                        dr["Estoque Máximo"] = p.estoquemaximo.ToString();

                        dt.Rows.Add(dr);
                    }
                    gridConsultaProd.DataSource = dt;
                    gridConsultaProd.Update();


                }
            }
        }
    }
}
