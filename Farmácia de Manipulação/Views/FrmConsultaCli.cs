using System;
using System.Data;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class consultaCli : Form
    {
        public consultaCli()
        {
            InitializeComponent();
        }

        public static string cpf_cli;

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from cliente";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
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

                    dt.Rows.Add(dr);
                }
                gridConsultaCli.DataSource = dt;
                gridConsultaCli.Update();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim cadastro

        private void consultaCli_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf_cli = gridConsultaCli.CurrentRow.Cells[0].Value.ToString();
            cliente.cpf = cpf_cli;
            Close();
        }

        private void tbPesqCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqCli.Text != string.Empty)
                {
                    try
                    {
                        conexao.fecharConexao();
                        string sql = "select * from cliente where nome LIKE '" +
                            tbPesqCli.Text.ToUpper() + "%'";
                        conexao.abrirConexao();
                        conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                        conexao.comando.Parameters.AddWithValue("@nome", tbPesqCli.Text);
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

                            dt.Rows.Add(dr);
                        }
                        gridConsultaCli.DataSource = dt;
                        gridConsultaCli.Update();
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
