using System;
using System.Data;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class consultaFornc : Form
    {
        public consultaFornc()
        {
            InitializeComponent();
        }

        public static string cnpj_fornc;

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from fornecedor";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("CNPJ", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Número", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Bairro", typeof(string));
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Telefone 1", typeof(string));
                dt.Columns.Add("Telefone 2", typeof(string));
                dt.Columns.Add("E-mail", typeof(string));

                while (conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["CNPJ"] = conexao.leitor["cnpj"].ToString();
                    dr["Nome"] = conexao.leitor["nome"].ToString();
                    dr["Número"] = conexao.leitor["numero"].ToString();
                    dr["Rua"] = conexao.leitor["rua"].ToString();
                    dr["Bairro"] = conexao.leitor["bairro"].ToString();
                    dr["Cidade"] = conexao.leitor["cidade"].ToString();
                    dr["Telefone 1"] = conexao.leitor["tel1"].ToString();
                    dr["Telefone 2"] = conexao.leitor["tel2"].ToString();
                    dr["E-mail"] = conexao.leitor["email"].ToString();

                    dt.Rows.Add(dr);
                }
                gridConsultaFornc.DataSource = dt;
                gridConsultaFornc.Update();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim cadastro


        private void consultaFornc_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaFornc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cnpj_fornc = gridConsultaFornc.CurrentRow.Cells[0].Value.ToString();
            fornecedor.cnpj = cnpj_fornc;
            Close();
        }

        private void tbPesqFornc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqFornc.Text != "")
                {

                    try
                    {
                        conexao.fecharConexao();
                        string sql = "select * from fornecedor where nome LIKE '"+
                            tbPesqFornc.Text + "%'";
                        conexao.abrirConexao();
                        conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                        conexao.leitor = conexao.comando.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("CNPJ", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Número", typeof(string));
                        dt.Columns.Add("Rua", typeof(string));
                        dt.Columns.Add("Bairro", typeof(string));
                        dt.Columns.Add("Cidade", typeof(string));
                        dt.Columns.Add("Telefone 1", typeof(string));
                        dt.Columns.Add("Telefone 2", typeof(string));
                        dt.Columns.Add("E-mail", typeof(string));

                        while (conexao.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["CNPJ"] = conexao.leitor["cnpj"].ToString();
                            dr["Nome"] = conexao.leitor["nome"].ToString();
                            dr["Número"] = conexao.leitor["numero"].ToString();
                            dr["Rua"] = conexao.leitor["rua"].ToString();
                            dr["Bairro"] = conexao.leitor["bairro"].ToString();
                            dr["Cidade"] = conexao.leitor["cidade"].ToString();
                            dr["Telefone 1"] = conexao.leitor["tel1"].ToString();
                            dr["Telefone 2"] = conexao.leitor["tel2"].ToString();
                            dr["E-mail"] = conexao.leitor["email"].ToString();

                            dt.Rows.Add(dr);
                        }
                        gridConsultaFornc.DataSource = dt;
                        gridConsultaFornc.Update();
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
