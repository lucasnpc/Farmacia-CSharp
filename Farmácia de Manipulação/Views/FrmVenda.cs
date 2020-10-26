using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
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
        List<Produto> produtos = new List<Produto>();
        List<Venda> vendas = new List<Venda>();

        private void limpar()
        {
            tbNomeCliente.Text = "";
            tbCodProduto.Text = "";
            tbQuantidade.Text = "";
            tbSubTotal.Text = "";
            gbReceitaFormProd.Enabled = false;
            valor = 0;
            valorTotal = 0;
        }
        private void calcularPreco(double valor,double qtd, int acesso)
        {
            try
            {
                if (acesso == 0)
                {
                    tbSubTotal.Text = Convert.ToString(string.Format("{0:n}", (valor * qtd)));
                }
                if (acesso == 1)
                {
                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void addProduto(string codProduto,string nomeProduto,double preco)
        {
            try
            {
                ListViewItem lt1 = new ListViewItem(codProduto);
                ListViewItem lt2 = new ListViewItem(nomeProduto);
                ListViewItem lt3 = new ListViewItem(string.Format("{0:n}", preco));
                lvProdutos.Items.AddRange(new ListViewItem[] { lt1,lt2,lt3 });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void carregaProduto()
        {
            produtos = new ProdutoDAO().GetProdutos();

            DataTable dt = new DataTable();
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Preço", typeof(string));

            foreach (Produto p in produtos)
            {
                DataRow dr = dt.NewRow();
                dr["Código"] = p.codigo;
                dr["Descrição"] = p.descricao;
                dr["Preço"] = p.valor_venda;

                dt.Rows.Add(dr);
            }

            gridProdutos.DataSource = dt;
            gridProdutos.Update();
        }
        private void gridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCodProduto.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
            lblProduto.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
            valor = int.Parse(gridProdutos.CurrentRow.Cells[2].Value.ToString());
        }
        private void tbPesqProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqProdutos.Text != string.Empty)
                {
                    IEnumerable<Produto> consultaProduto =
                        from produto in produtos
                        where produto.descricao.Contains(tbPesqProdutos.Text.ToUpper())
                        select produto;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Código", typeof(string));
                    dt.Columns.Add("Descrição", typeof(string));
                    dt.Columns.Add("Preço", typeof(string));

                    foreach (Produto p in consultaProduto)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Código"] = p.codigo;
                        dr["Descrição"] = p.descricao;
                        dr["Preço"] = p.valor_venda;

                        dt.Rows.Add(dr);
                    }

                    gridProdutos.DataSource = dt;
                    gridProdutos.Update();
                }
                else
                    carregaProduto();
            }
        }
        private void tbQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            maskCpfCliVenda.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(tbQuantidade.Text) > 0 && tbQuantidade.Text != "")
                {
                    calcularPreco(valor, int.Parse(tbQuantidade.Text), 0);
                    addProduto(tbCodProduto.Text, lblProduto.Text, valor);
                    vendas.Add(new Venda
                    {
                        cod_cliente = maskCpfCliVenda.Text,
                        cod_funcionario = CpfFuncionario.cpfFunc,
                        cod_produto = tbCodProduto.Text,
                        quantidade = int.Parse(tbQuantidade.Text),
                        valor_venda = double.Parse(tbSubTotal.Text)
                    });

                    lblProduto.Text = "";
                    tbCodProduto.Text = "";
                    tbQuantidade.Text = "";
                    tbQuantidade.Focus();

                    valorTotal += double.Parse(tbSubTotal.Text);

                    if (tbDesconto.Text != "")
                        valorTotal -= (valorTotal * 0.1);
                    tbTotal.Text = valorTotal.ToString();
                }
            }
        }
        private void bRealizaPedido_Click(object sender, EventArgs e)
        {
            foreach (Venda v in vendas)
            {
                if (new VendaDAO().Insere(new Venda
                {
                    cod_cliente = v.cod_cliente,
                    cod_funcionario = v.cod_funcionario,
                    cod_produto = v.cod_produto,
                    quantidade = v.quantidade,
                    valor_venda = v.valor_venda
                }))
                { }    
            }
            MessageBox.Show("Venda Realizada com sucesso");
            limpar();
        }
        private void maskCpfCliVenda_KeyDown(object sender, KeyEventArgs e)
        {
            maskCpfCliVenda.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (e.KeyCode == Keys.Enter)
            {
                tbNomeCliente.Text = new CpfFuncionario().getNomeCliente(maskCpfCliVenda.Text);
                if (tbNomeCliente.Text == "")
                {
                    MessageBox.Show("Nenhum Cliente encontrado.");
                }
                else
                    tbDesconto.Text = "10%";
            }
        }
        private void bSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void venda_Load(object sender, EventArgs e)
        {
            tbNomeFuncionario.Text = new CpfFuncionario().GetNomeFuncionario(CpfFuncionario.cpfFunc);
            carregaProduto();
            maskCpfCliVenda.Focus();
        }
    }
}
