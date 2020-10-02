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
            tbInfo.Text = "";
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
                tbCpfCli.Text = "";
                mbRetirada.Text = "";
                tbNomeCli.Text = "";
                tbReceita.Text = ""; ;
                tbPgtoAntecipado.Text = "";
                tbTotal.Text = "";
                gbReceitaFormProd.Enabled = true;
                cbFormulas.Text = "";
                gridProdutos.DataSource = null;
                idPedido = 0;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void carregaFormula()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT DISTINCT descricao FROM formula,receita_formula_produto,receita WHERE " +
                    "formula.id = receita_formula_produto.id_formula AND " +
                    "receita_formula_produto.num_receita = @numReceita";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@numReceita", tbReceita.Text);
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(conexao.leitor);

                DataRow linha = tabela.NewRow();

                linha["descricao"] = "";

                tabela.Rows.InsertAt(linha, 0);
                this.cbFormulas.DataSource = tabela;
                this.cbFormulas.DisplayMember = "descricao";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void carregaProduto(int ID)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT DISTINCT codigo, descricao, valor_venda FROM produto,receita_formula_produto " +
                "WHERE receita_formula_produto.cod_produto = produto.codigo AND " +
                "receita_formula_produto.id_formula = @id;";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@id", ID);
                conexao.comando.ExecuteNonQuery();
                NpgsqlDataReader leitor = conexao.comando.ExecuteReader();

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

        //Cadastro de receita
        private void cadastraReceita()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "INSERT INTO receita(numero_requisicao)"+
                    " values(@numero_requisicao)";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void atualizaReceita()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "UPDATE receita SET nome_paciente = @nome_paciente, nome_medico = @nome_medico," +
                    "informacoes = @informacoes, fk_cliente = @fk_cliente WHERE numero_requisicao = @numero_requisicao";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@nome_paciente", tbNomePaciente.Text);
                conexao.comando.Parameters.AddWithValue("@informacoes", tbInfo.Text);
                conexao.comando.Parameters.AddWithValue("@fk_cliente", cpfCli);
                conexao.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //fim

        //REGISTRA O PEDIDO
        private void registraPedido()
        {
            try
            {
                conexao.fecharConexao();
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
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@fk_funcionario", CpfFuncionario.cpfFunc);
                conexao.comando.Parameters.AddWithValue("@fk_cliente", tbCpfCli.Text);
                conexao.comando.Parameters.AddWithValue("@fk_receita", tbReceita.Text);
                conexao.comando.Parameters.AddWithValue("@data_encomenda", Convert.ToDateTime(mbEncomenda.Text));
                conexao.comando.Parameters.AddWithValue("@data_retirada", Convert.ToDateTime(mbRetirada.Text));
                conexao.comando.Parameters.AddWithValue("@pgto_antecipado", double.Parse(tbPgtoAntecipado.Text));
                conexao.comando.Parameters.AddWithValue("@preco_total", double.Parse(tbTotal.Text));

                conexao.comando.ExecuteNonQuery();

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
                conexao.fecharConexao();
                string sql = "SELECT MAX(id_pedido)AS id_pedido FROM pedido";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.leitor = conexao.comando.ExecuteReader();
                if (conexao.leitor.Read())
                    idPedido = int.Parse(conexao.leitor["id_pedido"].ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void registraPedidoCliente(int id)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "INSERT INTO pedido_cliente(fk_cliente,fk_pedido) values(@fk_cliente,@fk_pedido)";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@fk_cliente", tbCpfCli.Text);
                conexao.comando.Parameters.AddWithValue("@fk_pedido", id);
                conexao.comando.ExecuteNonQuery();
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

        private void pedido_Load(object sender, EventArgs e)
        {
            mbEncomenda.Text = DateTime.Now.Date.ToString();
        }

        //Trazer informacoes do produto
        private void tbCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRealizaPedido_Click(object sender, EventArgs e)
        {
            if (mbRetirada.Text != "    -  -" && tbTotal.Text != "")
            {
                registraPedido();
                trasIdPedido();
                registraPedidoCliente(idPedido);
                limparPedido();
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }

        private void cbFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPgtoAntecipado.Focus();
        }

        private void cbFormulas_Leave(object sender, EventArgs e)
        {
            if (cbFormulas.Text != "")
            {
                int id = 0;
                conexao.fecharConexao();
                string sql = "select id from formula where descricao = @descricao";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@descricao", cbFormulas.Text);
                conexao.leitor = conexao.comando.ExecuteReader();
                if (conexao.leitor.Read())
                {
                    id = int.Parse(conexao.leitor["id"].ToString());
                }
                carregaProduto(id);
            }
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
