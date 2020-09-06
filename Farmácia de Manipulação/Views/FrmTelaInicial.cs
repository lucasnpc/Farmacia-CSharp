using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace Farmácia_de_Manipulação
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        //Para passar o id para a tela de divulgação
        public static string crm;

        // Funcao que tras os dados do banco para divulgação
        private void carregaGird()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from medico_afiliado where especialidade LIKE '" +
                    tbMalaDireta.Text + "%'";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@especialidade", tbMalaDireta.Text);
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("CRM", typeof(string));
                dt.Columns.Add("Nome Médico", typeof(string));
                dt.Columns.Add("Nome Hospital", typeof(string));
                dt.Columns.Add("Especialidade", typeof(string));
                while (conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["CRM"] = conexao.leitor["crm"].ToString();
                    dr["Nome Médico"] = conexao.leitor["nome_medico"].ToString();
                    dr["Nome Hospital"] = conexao.leitor["nome_hopt"].ToString();
                    dr["Especialidade"] = conexao.leitor["especialidade"].ToString();

                    dt.Rows.Add(dr);
                }
                gridEspecialidade.DataSource = dt;
                gridEspecialidade.Update();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim consulta

        //Funcao que tras os pedidos na tela
        private void carregaPedido()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT cpf,nome,telefone1,data_encomenda,data_retirada,preco_total" +
                    " FROM cliente,pedido,pedido_cliente " +
                    "WHERE pedido_cliente.fk_pedido = id_pedido AND pedido_cliente.fk_cliente = cliente.cpf AND " +
                    "pedido.data_retirada = @data";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@data", Convert.ToDateTime(lblData.Text));
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("CPF Cliente", typeof(string));
                dt.Columns.Add("Nome Cliente", typeof(string));
                dt.Columns.Add("Telefone", typeof(string));
                dt.Columns.Add("Data de encomenda", typeof(string));
                dt.Columns.Add("Data para retirar", typeof(string));
                dt.Columns.Add("Preço Total", typeof(string));
                {
                    while (conexao.leitor.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["CPF Cliente"] = conexao.leitor["cpf"].ToString();
                        dr["Nome Cliente"] = conexao.leitor["nome"].ToString();
                        dr["Telefone"] = conexao.leitor["telefone1"].ToString();
                        dr["Data de encomenda"] = conexao.leitor["data_encomenda"].ToString();
                        dr["Data para retirar"] = conexao.leitor["data_retirada"].ToString();
                        dr["Preço Total"] = conexao.leitor["preco_total"].ToString();

                        dt.Rows.Add(dr);
                    }


                    gridPedidos.DataSource = dt;
                    gridPedidos.Update();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool procuraProdutoVencido()
        {
            bool achou = false;
            try
            {
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return achou;
        }
        private void verificacoes()
        {
            if (procuraProdutoVencido() == true)
            {
                alerta.Visible = true;
            }
        }

        private void menubom_Load(object sender, EventArgs e)
        {
            try
            {
                lblData.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
                carregaPedido();
                procuraProdutoVencido();
                verificacoes();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Menus strips
        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new funcionario().ShowDialog();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            new cliente().ShowDialog();
        }


        private void fornecedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            fornecedor fornc = new fornecedor();
            fornc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            produtos produto = new produtos();
            produto.ShowDialog();
            procuraProdutoVencido();
            verificacoes();
        }

        private void registrarPedidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            pedido pedidos = new pedido();
            pedidos.ShowDialog();
            carregaPedido();
        }
        //Fim

        private void bFim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void gridEspecialidade_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            crm = gridEspecialidade.CurrentRow.Cells[0].Value.ToString();
        }

        private void tbMalaDireta_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMalaDireta.Text != "")
                {
                    carregaGird();
                }
            }
        }
    }
}
