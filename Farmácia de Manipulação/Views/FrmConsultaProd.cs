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
                AcessoBD.fecharConexao();
                string sql = "select * from produto";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

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

                while (AcessoBD.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Código"] = AcessoBD.leitor["codigo"].ToString();
                    dr["Descrição"] = AcessoBD.leitor["descricao"].ToString();
                    dr["Lote"] = AcessoBD.leitor["lote"].ToString();
                    dr["Data de fabricação"] = Convert.ToDateTime(AcessoBD.leitor["data_fabricacao"]).ToShortDateString();
                    dr["Data de validade"] = Convert.ToDateTime(AcessoBD.leitor["data_validade"]).ToShortDateString();
                    dr["Recomendações"] = AcessoBD.leitor["recomendacoes"].ToString();
                    dr["Medida"] = AcessoBD.leitor["medida"].ToString();
                    dr["Quantidade"] = AcessoBD.leitor["quantidade"].ToString();
                    dr["Segmento"] = AcessoBD.leitor["segmento"].ToString();
                    dr["Valor custo"] = AcessoBD.leitor["valor_custo"].ToString();
                    dr["Valor venda"] = AcessoBD.leitor["valor_venda"].ToString();
                    dr["Estoque Mínimo"] = AcessoBD.leitor["estoqueMin"].ToString();
                    dr["Estoque Máximo"] = AcessoBD.leitor["estoqueMax"].ToString();

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
                        AcessoBD.fecharConexao();
                        string sql = "select * from produto where descricao LIKE '"+
                            tbPesqProd.Text+"%'";
                        AcessoBD.abrirConexao();
                        AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                        AcessoBD.comando.Parameters.AddWithValue("@descricao", tbPesqProd.Text);
                        AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

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

                        while (AcessoBD.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["Código"] = AcessoBD.leitor["codigo"].ToString();
                            dr["Descrição"] = AcessoBD.leitor["descricao"].ToString();
                            dr["Lote"] = AcessoBD.leitor["lote"].ToString();
                            dr["Data de fabricação"] = Convert.ToDateTime(AcessoBD.leitor["data_fabricacao"]).ToShortDateString();
                            dr["Data de validade"] = Convert.ToDateTime(AcessoBD.leitor["data_validade"]).ToShortDateString();
                            dr["Recomendações"] = AcessoBD.leitor["recomendacoes"].ToString();
                            dr["Medida"] = AcessoBD.leitor["medida"].ToString();
                            dr["Quantidade"] = AcessoBD.leitor["quantidade"].ToString();
                            dr["Segmento"] = AcessoBD.leitor["segmento"].ToString();
                            dr["Valor custo"] = AcessoBD.leitor["valor_custo"].ToString();
                            dr["Valor venda"] = AcessoBD.leitor["valor_venda"].ToString();
                            dr["Estoque Mínimo"] = AcessoBD.leitor["estoqueMin"].ToString();
                            dr["Estoque Máximo"] = AcessoBD.leitor["estoqueMax"].ToString();

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
