using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class produto : Form
    {
        public produto()
        {
            InitializeComponent();
        }

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
            tbQuantidade.Clear();
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

        // Fim alteracoes

        private void carregaFornc()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "select nome,cnpj from fornecedores " +
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

                cbFornecedor.DataSource = tabela;
                cbFornecedor.ValueMember = "cnpj";
                cbFornecedor.DisplayMember = "nome";

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
            new CpfFuncionario().GetCnpjFornecedor(nomedoFornecedor);
        }

        private void bNovoCli_Click(object sender, EventArgs e)
        {
            statusCadastra();
        }

        private void bCadastraProduto_Click(object sender, EventArgs e)
        {
            if (tbDesc.Text != "" && tbCod.Text != "" && mbDataFabri.Text != "    -  -" && mbDataValidade.Text != "    -  -")
            {
                if (new ProdutoDAO().Insere(new Produto
                {
                    descricao = tbDesc.Text.Trim().ToUpper(),
                    codigo = tbCod.Text.Trim(),
                    lote = tbLote.Text.Trim(),
                    data_fabricacao = Convert.ToDateTime(mbDataFabri.Text).ToShortDateString(),
                    data_validade = Convert.ToDateTime(mbDataValidade.Text).ToShortDateString(),
                    recomendacoes = tbRecomendacoes.Text.Trim(),
                    quantidade = int.Parse(tbQuantidade.Text),
                    segmento = cbSeguimento.Text.Trim(),
                    estoqueminimo = int.Parse(tbEstoqueMin.Text),
                    estoquemaximo = int.Parse(tbEstoqueMax.Text),
                    valor_custo = double.Parse(tbVlrCusto.Text),
                    valor_venda = double.Parse(tbVlrVenda.Text),
                    cnpjfornecedor = new CpfFuncionario().GetCnpjFornecedor(cbFornecedor.Text)
                }))
                    MessageBox.Show("Produto registrado com sucesso.");
                limpar();
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }

        private void bConsultaProduto_Click(object sender, EventArgs e)
        {
            consultaProduto consulta = new consultaProduto();
            consulta.ShowDialog();
            if (codProduto != null)
            {
                List<Produto> produtos = new ProdutoDAO().GetProdutos();

                if (produtos != null)
                {
                    foreach (Produto produto in produtos)
                    {
                        if (produto.codigo.Equals(codProduto))
                        {
                            tbDesc.Text = produto.descricao;
                            tbCod.Text = produto.codigo;
                            tbLote.Text = produto.lote;
                            cbSeguimento.Text = produto.segmento;
                            tbEstoqueMax.Text = produto.estoquemaximo.ToString();
                            tbEstoqueMin.Text = produto.estoqueminimo.ToString();
                            tbQuantidade.Text = produto.quantidade.ToString();
                            tbRecomendacoes.Text = produto.recomendacoes;
                            tbVlrCusto.Text = produto.valor_custo.ToString();
                            tbVlrVenda.Text = produto.valor_venda.ToString();
                            mbDataFabri.Text = produto.data_fabricacao;
                            mbDataValidade.Text = produto.data_validade;
                            statusAlter();
                        }
                    }
                }
            }
        }

        private void bSairProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAlteraProduto_Click(object sender, EventArgs e)
        {
            if (new ProdutoDAO().Atualiza(new Produto
            {
                descricao = tbDesc.Text.Trim().ToUpper(),
                codigo = tbCod.Text.Trim(),
                lote = tbLote.Text.Trim(),
                data_fabricacao = Convert.ToDateTime(mbDataFabri.Text).ToShortDateString(),
                data_validade = Convert.ToDateTime(mbDataValidade.Text).ToShortDateString(),
                recomendacoes = tbRecomendacoes.Text.Trim(),
                quantidade = int.Parse(tbQuantidade.Text.Trim()),
                segmento = cbSeguimento.Text.Trim(),
                estoqueminimo = int.Parse(tbEstoqueMin.Text),
                estoquemaximo = int.Parse(tbEstoqueMax.Text),
                valor_custo = double.Parse(tbVlrCusto.Text),
                valor_venda = double.Parse(tbVlrVenda.Text),
                cnpjfornecedor = new CpfFuncionario().GetCnpjFornecedor(cbFornecedor.Text)

            }))
                MessageBox.Show("Produto atualizado com sucesso.");
            limpar();
        }

        private void bExcluiProduto_Click(object sender, EventArgs e)
        {
            if (new ProdutoDAO().Deleta(codProduto))
                MessageBox.Show("Dados excluidos com sucesso.");
            limpar();
        }


    }
}
