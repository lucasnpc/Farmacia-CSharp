using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        public static string cnpjForn;
        public static string codProduto;

        /* Status do Sistema de Cadastro*/
        private void statusInicial()
        {
            gbProdutos.Enabled = false;
            bNovoProduto.Enabled = true;
            bCadastraProduto.Enabled = false;
            bAlteraProduto.Enabled = false;
            bExcluiProduto.Enabled = false;
            bSairProduto.Enabled = true;
            bConsultaProduto.Enabled = true;
        }

        private void statusCadastra()
        {
            gbProdutos.Enabled = true;
            bNovoProduto.Enabled = false;
            bCadastraProduto.Enabled = true;
            bAlteraProduto.Enabled = false;
            bExcluiProduto.Enabled = false;
            bConsultaProduto.Enabled = true;
            bSairProduto.Enabled = true;
        }

        private void limpar()
        {
            tbDesc.Clear();
            tbCod.Clear();
            tbLote.Clear();
            tbRecomendacoes.Clear();
            mbDataFabri.Clear();
            mbDataValidade.Clear();
            tbEstoqueMax.Clear();
            tbEstoqueMin.Clear();
            mbMargem.Clear();
            tbEstoque.Clear();
            cbFornecedor.Text = "";
            cbSeguimento.Text = "";
            statusInicial();
        }

        private void statusAlter()
        {
            bNovoProduto.Enabled = false;
            bCadastraProduto.Enabled = false;
            bAlteraProduto.Enabled = true;
            bExcluiProduto.Enabled = true;
            bConsultaProduto.Enabled = true;
            bSairProduto.Enabled = true;
            gbProdutos.Enabled = true;
        }
        //Fim Status

        /* Cadastro no banco dos registros*/
        private void cadastraProduto()
        {
            try
            {
                double valor = 0;
                AcessoBD.fecharConexao();
                string sql = "INSERT INTO produto(descricao," +
                    "codigo," +
                    "lote," +
                    "data_fabricacao," +
                    "data_validade," +
                    "recomendacoes," +
                    "medida," +
                    "quantidade," +
                    "segmento," +
                   "valor_custo," +
                   "valor_venda," +
                   "estoqueMin,estoqueMax," +
                   "fk_funcionario, fk_fornecedor) " +
                   "VALUES(@descricao," +
                    "@codigo," +
                    "@lote," +
                    "@data_fabricacao," +
                    "@data_validade," +
                    "@recomendacoes," +
                    "@medida," +
                    "@quantidade," +
                    "@segmento," +
                    "@valor_custo,@valor_venda," +
                    "@estoqueMin,@estoqueMax," +
                    "@fk_funcionario,@fk_fornecedor)";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@descricao", tbDesc.Text.Trim());
                AcessoBD.comando.Parameters.AddWithValue("@codigo", tbCod.Text.Trim());
                AcessoBD.comando.Parameters.AddWithValue("@lote", tbLote.Text.Trim());
                AcessoBD.comando.Parameters.AddWithValue("@data_fabricacao", DateTime.Parse(mbDataFabri.Text).Date);
                AcessoBD.comando.Parameters.AddWithValue("@data_validade", DateTime.Parse(mbDataValidade.Text).Date);
                AcessoBD.comando.Parameters.AddWithValue("@recomendacoes", tbRecomendacoes.Text.Trim());
                AcessoBD.comando.Parameters.AddWithValue("@medida", valor);
                AcessoBD.comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(tbEstoque.Text));
                AcessoBD.comando.Parameters.AddWithValue("@segmento", cbSeguimento.Text.Trim());
                AcessoBD.comando.Parameters.AddWithValue("@estoqueMin", int.Parse(tbEstoqueMin.Text));
                AcessoBD.comando.Parameters.AddWithValue("@estoqueMax", int.Parse(tbEstoqueMax.Text));
                AcessoBD.comando.Parameters.AddWithValue("@fk_funcionario", CpfFuncionario.cpfFunc);

                AcessoBD.comando.ExecuteNonQuery();
                MessageBox.Show("Produto registrado com sucesso.");
                limpar();
            }
            catch (Exception) { }
        }
        //Fim de cadastro

        /*Retornar dados dos clientes para os campos*/
        private string retornaProduto(string codProduto)
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "select * from produto where codigo = @codigo";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", codProduto);
                AcessoBD.comando.ExecuteNonQuery();
                NpgsqlDataReader leitor = AcessoBD.comando.ExecuteReader();

                if (leitor.Read())
                {
                    tbDesc.Text = leitor["descricao"].ToString();
                    tbCod.Text = leitor["codigo"].ToString();
                    tbLote.Text = leitor["lote"].ToString();
                    cbSeguimento.Text = leitor["segmento"].ToString();
                    tbEstoqueMax.Text = leitor["estoqueMax"].ToString();
                    tbEstoqueMin.Text = leitor["estoqueMin"].ToString();
                    tbEstoque.Text = leitor["quantidade"].ToString();
                    tbRecomendacoes.Text = leitor["recomendacoes"].ToString();
                    mbDataFabri.Text = leitor["data_fabricacao"].ToString();
                    mbDataValidade.Text = leitor["data_validade"].ToString();
                    statusAlter();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    limpar();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return codProduto;
        }
        //Fim retornos

        /*Inicio alteracoes*/
        private void alteraProduto()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "UPDATE produto SET descricao = @descricao," +
                    "data_fabricacao = @data_fabricacao," +
                    "data_validade = @data_validade," +
                    "recomendacoes = @recomendacoes," +
                    "nome_fornecedor = @nome_fornecedor," +
                    "medida = @medida," +
                    "quantidade = @quantidade," +
                    "segmento = @segmento," +
                    "valor_custo = @valor_custo," +
                    "valor_venda = @valor_venda," +
                    "estoqueMin = @estoqueMin," +
                    "estoqueMax = @estoqueMax " +
                    "WHERE codigo = @codigo";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", tbCod.Text);
                AcessoBD.comando.Parameters.AddWithValue("@descricao", tbDesc.Text);
                AcessoBD.comando.Parameters.AddWithValue("@data_fabricacao", Convert.ToDateTime(mbDataFabri.Text).Date);
                AcessoBD.comando.Parameters.AddWithValue("@data_validade", Convert.ToDateTime(mbDataValidade.Text).Date);
                AcessoBD.comando.Parameters.AddWithValue("@recomendacoes", tbRecomendacoes.Text);
                AcessoBD.comando.Parameters.AddWithValue("@nome_fornecedor", cbFornecedor.Text);
                AcessoBD.comando.Parameters.AddWithValue("@quantidade", int.Parse(tbEstoque.Text));
                AcessoBD.comando.Parameters.AddWithValue("@segmento", cbSeguimento.Text);
                AcessoBD.comando.Parameters.AddWithValue("@estoqueMin", int.Parse(tbEstoqueMin.Text));
                AcessoBD.comando.Parameters.AddWithValue("@estoqueMax", int.Parse(tbEstoqueMax.Text));

                AcessoBD.comando.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso.");
                limpar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void deletaProduto()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "DELETE FROM produto WHERE codigo = @codigo";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@codigo", tbCod.Text);
                AcessoBD.comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso.");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Fim alteracoes

        private void carregaFornc()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "select nome,cnpj from fornecedor " +
                    "order by nome";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new NpgsqlCommand(sql, AcessoBD.conecta);
                NpgsqlDataReader leitor = AcessoBD.comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(leitor);

                DataRow linha = tabela.NewRow();

                linha["nome"] = "";
                linha["cnpj"] = "";

                tabela.Rows.InsertAt(linha, 0);

                this.cbFornecedor.DataSource = tabela;
                this.cbFornecedor.ValueMember = "cnpj";
                this.cbFornecedor.DisplayMember = "nome";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void produtos_Load(object sender, EventArgs e)
        {
            statusInicial();
            carregaFornc();
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDesc.Focus();
        }

        private void cbFornecedor_Leave(object sender, EventArgs e)
        {

            string nomedoFornecedor = cbFornecedor.Text;
            CpfFuncionario.pegaNomeCnpjFornc(nomedoFornecedor);
        }

        private void bNovoCli_Click(object sender, EventArgs e)
        {
            statusCadastra();
        }

        private void bCadastraProduto_Click(object sender, EventArgs e)
        {
            if (tbDesc.Text != "" && tbCod.Text != "" && mbDataFabri.Text != "    -  -" && mbDataValidade.Text != "    -  -")
            {
                cadastraProduto();
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }

        private void bConsultaProduto_Click(object sender, EventArgs e)
        {
            consultaProduto consulta = new consultaProduto();
            consulta.ShowDialog();
            if (codProduto != null)
                retornaProduto(codProduto);
        }

        private void bSairProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAlteraProduto_Click(object sender, EventArgs e)
        {
            alteraProduto();
        }

        private void bExcluiProduto_Click(object sender, EventArgs e)
        {
            deletaProduto();
        }


    }
}
