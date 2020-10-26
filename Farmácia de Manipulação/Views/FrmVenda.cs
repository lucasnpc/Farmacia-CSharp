using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class venda : Form
    {
        public venda()
        {
            InitializeComponent();
        }

        double valor = 0, valorTotal;
        public static double valorFormula = 0;
        double qtd = 0;
        string idProduto = "";
        public static int idFormula = 0;
        int idPedido = 0;
        public static string cpfCli = "", nomeCli = "", nomeFormula = "";
        int I = 0;

        private void calcularPreco(double valor,double qtd, int acesso)
        {
            try
            {
                if (acesso == 0)
                {
                    tbSubTotal.Text = Convert.ToString(string.Format("{0:n}", (valor * qtd)));
                    valorFormula += Convert.ToDouble(tbSubTotal.Text);
                    valorTotal += valorFormula;
                }
                if (acesso == 1)
                {
                    valorTotal += valorFormula;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void addProduto(string codProduto,string nomeProduto,double preco)
        {
            try
            {
                ListViewItem lt = new ListViewItem(codProduto);
                lt.SubItems.Add(nomeProduto);
                lt.SubItems.Add(tbDosagem.Text);
                lt.SubItems.Add(Convert.ToString(string.Format("{0:n}", preco)));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void limpar()
        {
            tbNomePaciente.Text = "";
            tbCodProduto.Text = "";
            tbDosagem.Text = "";
            tbSubTotal.Text = "";
            gbReceitaFormProd.Enabled = false;
            valor = 0;
            valorFormula = 0;
            valorTotal = 0;
        }
        private void limparPedido()
        {
            try
            {
                tbPgtoAntecipado.Text = "";
                tbTotal.Text = "";
                gbReceitaFormProd.Enabled = true;
                gridProdutos.DataSource = null;
                idPedido = 0;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void carregaProduto(int ID)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "SELECT DISTINCT codigo, descricao, valor_venda FROM produto,receita_formula_produto " +
                "WHERE receita_formula_produto.cod_produto = produto.codigo AND " +
                "receita_formula_produto.id_formula = @id;";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@id", ID);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader leitor = AcessoBD.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Descrição", typeof(string));
                dt.Columns.Add("Preço", typeof(string));

                while (leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Código"] = leitor["codigo"].ToString();
                    dr["Descrição"] = leitor["descricao"].ToString();
                    dr["Preço"] = leitor["valor_venda"].ToString();

                    dt.Rows.Add(dr);
                }

                gridProdutos.DataSource = dt;
                gridProdutos.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //REGISTRA O PEDIDO
        private void registraPedido()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO pedido(fk_funcionario," +
                    "fk_cliente," +
                    "fk_receita," +
                    "data_encomenda," +
                    "data_retirada," +
                    "pgto_antecipado," +
                    "preco_total) VALUES(@fk_funcionario," +
                    "@fk_cliente," +
                    "@fk_receita," +
                    "@data_encomenda," +
                    "@data_retirada," +
                    "@pgto_antecipado," +
                    "@preco_total)";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@fk_funcionario", CpfFuncionario.cpfFunc);
                AcessoBD.comando.Parameters.AddWithValue("@pgto_antecipado", double.Parse(tbPgtoAntecipado.Text));
                AcessoBD.comando.Parameters.AddWithValue("@preco_total", double.Parse(tbTotal.Text));

                AcessoBD.comando.ExecuteNonQuery();

                MessageBox.Show("Pedido realizado com sucesso.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void trasIdPedido()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "SELECT MAX(id_pedido)AS id_pedido FROM pedido";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();
                if (AcessoBD.leitor.Read())
                    idPedido = int.Parse(AcessoBD.leitor["id_pedido"].ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void registraPedidoCliente(int id)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO pedido_cliente(fk_cliente,fk_pedido) values(@fk_cliente,@fk_pedido)";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@fk_pedido", id);
                AcessoBD.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //fim

        #region
            //baixa estoque
       /* private void baixaEstoque()
        {
            string cod;
            try
            {
                double estoqueAtual = 0;
                conexao.fecharConexao();
                string sql = "SELECT codigo,quantidade FROM produto,formula,receita_formula_produto " +
                    "WHERE formula.id = receita_formula_produto.id_formula AND " +
                    "receita_formula_produto.cod_produto = produto.codigo;";
                conexao.abrirConexao();
                conexao.comando = new MySqlCommand(sql, conexao.conecta);
                conexao.leitor = conexao.comando.ExecuteReader();
                while (conexao.leitor.Read())
                {
                    cod = conexao.leitor["codigo"].ToString();
                    estoqueAtual = int.Parse(conexao.leitor["quantidade"].ToString());
                    estoqueAtual = estoqueAtual - qtdParaEstoque[I];
                    conexao.fecharConexao();          
                    conexao.abrirConexao();
                    I++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/
        
#endregion;

        //Trazer informacoes do produto
        private void tbCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void venda_Load(object sender, EventArgs e)
        {
            tbNomeFuncionario.Text = new CpfFuncionario().GetNomeFuncionario(CpfFuncionario.cpfFunc);
        }

        private void bRealizaPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void cbFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPgtoAntecipado.Focus();
        }

        //Define o preço
        private void tbDosagem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (int.Parse(tbDosagem.Text) > 0 && tbDosagem.Text != "")
                {
                    qtd = double.Parse(tbDosagem.Text);
                    calcularPreco(valor, qtd, 0);
                    addProduto(tbCodProduto.Text, lblProduto.Text, valor);
                    I++;

                    lblProduto.Text = "";
                    tbCodProduto.Text = "";
                    tbDosagem.Text = "";
                    tbCodProduto.Focus();
                }
            }
        }
        //fim
    }
}
