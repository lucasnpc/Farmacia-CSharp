using System;
using System.Data;
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

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from produto";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Descrição", typeof(string));
                dt.Columns.Add("Lote", typeof(string));
                dt.Columns.Add("Data de fabricação", typeof(string));
                dt.Columns.Add("Data de Validade", typeof(string));
                dt.Columns.Add("Recomendações", typeof(string));
                dt.Columns.Add("Medida", typeof(string));
                dt.Columns.Add("Quantidade", typeof(string));
                dt.Columns.Add("Segmento", typeof(string));
                dt.Columns.Add("Valor custo", typeof(string));
                dt.Columns.Add("Valor venda", typeof(string));
                dt.Columns.Add("Estoque Mínimo", typeof(string));
                dt.Columns.Add("Estoque Máximo", typeof(string));

                while (conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Código"] = conexao.leitor["codigo"].ToString();
                    dr["Descrição"] = conexao.leitor["descricao"].ToString();
                    dr["Lote"] = conexao.leitor["lote"].ToString();
                    dr["Data de fabricação"] = Convert.ToDateTime(conexao.leitor["data_fabricacao"]).ToShortDateString();
                    dr["Data de validade"] = Convert.ToDateTime(conexao.leitor["data_validade"]).ToShortDateString();
                    dr["Recomendações"] = conexao.leitor["recomendacoes"].ToString();
                    dr["Medida"] = conexao.leitor["medida"].ToString();
                    dr["Quantidade"] = conexao.leitor["quantidade"].ToString();
                    dr["Segmento"] = conexao.leitor["segmento"].ToString();
                    dr["Valor custo"] = conexao.leitor["valor_custo"].ToString();
                    dr["Valor venda"] = conexao.leitor["valor_venda"].ToString();
                    dr["Estoque Mínimo"] = conexao.leitor["estoqueMin"].ToString();
                    dr["Estoque Máximo"] = conexao.leitor["estoqueMax"].ToString();

                    dt.Rows.Add(dr);
                }
                gridConsultaProd.DataSource = dt;
                gridConsultaProd.Update();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim cadastro


        private void consultaProduto_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codProd = gridConsultaProd.CurrentRow.Cells[0].Value.ToString();
            produtos.codProduto = codProd;
            Close();
        }

        private void tbPesqProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqProd.Text != "")
                {
                    try
                    {
                        conexao.fecharConexao();
                        string sql = "select * from produto where descricao LIKE '"+
                            tbPesqProd.Text+"%'";
                        conexao.abrirConexao();
                        conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                        conexao.comando.Parameters.AddWithValue("@descricao", tbPesqProd.Text);
                        conexao.leitor = conexao.comando.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Código", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Lote", typeof(string));
                        dt.Columns.Add("Data de fabricação", typeof(string));
                        dt.Columns.Add("Data de Validade", typeof(string));
                        dt.Columns.Add("Recomendações", typeof(string));
                        dt.Columns.Add("Medida", typeof(string));
                        dt.Columns.Add("Quantidade", typeof(string));
                        dt.Columns.Add("Segmento", typeof(string));
                        dt.Columns.Add("Valor custo", typeof(string));
                        dt.Columns.Add("Valor venda", typeof(string));
                        dt.Columns.Add("Estoque Mínimo", typeof(string));
                        dt.Columns.Add("Estoque Máximo", typeof(string));

                        while (conexao.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["Código"] = conexao.leitor["codigo"].ToString();
                            dr["Descrição"] = conexao.leitor["descricao"].ToString();
                            dr["Lote"] = conexao.leitor["lote"].ToString();
                            dr["Data de fabricação"] = Convert.ToDateTime(conexao.leitor["data_fabricacao"]).ToShortDateString();
                            dr["Data de validade"] = Convert.ToDateTime(conexao.leitor["data_validade"]).ToShortDateString();
                            dr["Recomendações"] = conexao.leitor["recomendacoes"].ToString();
                            dr["Medida"] = conexao.leitor["medida"].ToString();
                            dr["Quantidade"] = conexao.leitor["quantidade"].ToString();
                            dr["Segmento"] = conexao.leitor["segmento"].ToString();
                            dr["Valor custo"] = conexao.leitor["valor_custo"].ToString();
                            dr["Valor venda"] = conexao.leitor["valor_venda"].ToString();
                            dr["Estoque Mínimo"] = conexao.leitor["estoqueMin"].ToString();
                            dr["Estoque Máximo"] = conexao.leitor["estoqueMax"].ToString();

                            dt.Rows.Add(dr);
                        }
                        gridConsultaProd.DataSource = dt;
                        gridConsultaProd.Update();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
