using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class consultaFunc : Form
    {
        public consultaFunc()
        {
            InitializeComponent();
        }

        public static string cpf_func;

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from funcionario";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("CPF", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Data de Nascimento", typeof(string));
                dt.Columns.Add("Número", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Bairro", typeof(string));
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Telefone 1", typeof(string));
                dt.Columns.Add("Telefone 2", typeof(string));
                dt.Columns.Add("E-mail", typeof(string));
                dt.Columns.Add("Cargo", typeof(string));
                dt.Columns.Add("Data de Admissão", typeof(string));

                while (conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["CPF"] = conexao.leitor["cpf"].ToString();
                    dr["Nome"] = conexao.leitor["nome"].ToString();
                    dr["Data de Nascimento"] = Convert.ToDateTime(conexao.leitor["data_nasc"]).ToShortDateString();
                    dr["Número"] = conexao.leitor["numero"].ToString();
                    dr["Rua"] = conexao.leitor["rua"].ToString();
                    dr["Bairro"] = conexao.leitor["bairro"].ToString();
                    dr["Cidade"] = conexao.leitor["cidade"].ToString();
                    dr["Telefone 1"] = conexao.leitor["telefone1"].ToString();
                    dr["Telefone 2"] = conexao.leitor["telefone2"].ToString();
                    dr["E-mail"] = conexao.leitor["email"].ToString();
                    dr["Cargo"] = conexao.leitor["cargo"].ToString();
                    dr["Data de Admissão"] = Convert.ToDateTime(conexao.leitor["data_admissao"]).ToShortDateString();

                    dt.Rows.Add(dr);
                }
                gridConsultaFunc.DataSource = dt;
                gridConsultaFunc.Update();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim cadastro

        private void consultaFunc_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaFunc_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridConsultaFunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf_func = gridConsultaFunc.CurrentRow.Cells[0].Value.ToString();
            funcionario.cpf = cpf_func;
            Close();
        }

        private void tbPesqFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqFunc.Text != string.Empty)
                {
                    try
                    {
                        conexao.fecharConexao();
                        string sql = "select * from funcionario where nome LIKE '" +
                            tbPesqFunc.Text + "%'";
                        conexao.abrirConexao();
                        conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                        conexao.comando.Parameters.AddWithValue("@nome", tbPesqFunc.Text);
                        conexao.leitor = conexao.comando.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Data de Nascimento", typeof(string));
                        dt.Columns.Add("Número", typeof(string));
                        dt.Columns.Add("Rua", typeof(string));
                        dt.Columns.Add("Bairro", typeof(string));
                        dt.Columns.Add("Cidade", typeof(string));
                        dt.Columns.Add("Telefone 1", typeof(string));
                        dt.Columns.Add("Telefone 2", typeof(string));
                        dt.Columns.Add("E-mail", typeof(string));
                        dt.Columns.Add("Cargo", typeof(string));
                        dt.Columns.Add("Data de Admissão", typeof(string));

                        while (conexao.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["CPF"] = conexao.leitor["cpf"].ToString();
                            dr["Nome"] = conexao.leitor["nome"].ToString();
                            dr["Data de Nascimento"] = Convert.ToDateTime(conexao.leitor["data_nasc"]).ToShortDateString();
                            dr["Número"] = conexao.leitor["numero"].ToString();
                            dr["Rua"] = conexao.leitor["rua"].ToString();
                            dr["Bairro"] = conexao.leitor["bairro"].ToString();
                            dr["Cidade"] = conexao.leitor["cidade"].ToString();
                            dr["Telefone 1"] = conexao.leitor["telefone1"].ToString();
                            dr["Telefone 2"] = conexao.leitor["telefone2"].ToString();
                            dr["E-mail"] = conexao.leitor["email"].ToString();
                            dr["Cargo"] = conexao.leitor["cargo"].ToString();
                            dr["Data de Admissão"] = Convert.ToDateTime(conexao.leitor["data_admissao"]).ToShortDateString();

                            dt.Rows.Add(dr);
                        }
                        gridConsultaFunc.DataSource = dt;
                        gridConsultaFunc.Update();
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