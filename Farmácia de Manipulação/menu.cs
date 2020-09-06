using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                string sql = "select * from medico_afiliado where especialidade LIKE '"+
                    tbMalaDireta.Text +"%'";
                conexao.abrirConexao();
                conexao.comando = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao.conecta);
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
                string sql = "SELECT cpf,nome,telefone1,data_encomenda,data_retirada,preco_total"+
                    " FROM cliente,pedido,pedido_cliente " +
                    "WHERE pedido_cliente.fk_pedido = id_pedido AND pedido_cliente.fk_cliente = cliente.cpf AND "+
                    "pedido.data_retirada = @data";
                conexao.abrirConexao();
                conexao.comando = new MySqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@data", lblData.Text);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void menu_Load(object sender, EventArgs e)
        {
            lblData.Text = (DateTime.Now.Date.ToString("yyyy/MM/dd"));
            carregaPedido();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionario funcionario = new funcionario();
            funcionario.ShowDialog();
        }

        private void bEncerra(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente();
            cliente.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medico medico = new medico();
            medico.ShowDialog();
        }
        
        private void tbMalaDireta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMalaDireta.Text != "")
                {
                    carregaGird();
                }
            }
        }
        // Trazer na tela informações do médico para divulgação
       private void gridEspecialidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            crm = gridEspecialidade.CurrentRow.Cells[0].Value.ToString();
            malaDireta.crm_malaDireta = crm;
            malaDireta divulgação = new malaDireta();
            divulgação.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedor fornc = new fornecedor();
            fornc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtos produto = new produtos();
            produto.ShowDialog();
        }

        private void registrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedido pedidos = new pedido();
            pedidos.ShowDialog();
            carregaPedido();
        }
    }
}
