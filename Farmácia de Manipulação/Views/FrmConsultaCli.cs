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
                AcessoBD.fecharConexao();
                string sql = "select * from cliente";
                AcessoBD.abrirConexao();
                AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

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

                while (AcessoBD.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["CPF"] = AcessoBD.leitor["cpf"].ToString();
                    dr["Nome"] = AcessoBD.leitor["nome"].ToString();
                    dr["Data de Nascimento"] = Convert.ToDateTime(AcessoBD.leitor["data_nasc"]).ToShortDateString();
                    dr["Número"] = AcessoBD.leitor["numero"].ToString();
                    dr["Rua"] = AcessoBD.leitor["rua"].ToString();
                    dr["Bairro"] = AcessoBD.leitor["bairro"].ToString();
                    dr["Cidade"] = AcessoBD.leitor["cidade"].ToString();
                    dr["Telefone 1"] = AcessoBD.leitor["telefone1"].ToString();
                    dr["Telefone 2"] = AcessoBD.leitor["telefone2"].ToString();
                    dr["E-mail"] = AcessoBD.leitor["email"].ToString();

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
                        AcessoBD.fecharConexao();
                        string sql = "select * from cliente where nome LIKE '" +
                            tbPesqCli.Text.ToUpper() + "%'";
                        AcessoBD.abrirConexao();
                        AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                        AcessoBD.comando.Parameters.AddWithValue("@nome", tbPesqCli.Text);
                        AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

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

                        while (AcessoBD.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["CPF"] = AcessoBD.leitor["cpf"].ToString();
                            dr["Nome"] = AcessoBD.leitor["nome"].ToString();
                            dr["Data de Nascimento"] = Convert.ToDateTime(AcessoBD.leitor["data_nasc"]).ToShortDateString();
                            dr["Número"] = AcessoBD.leitor["numero"].ToString();
                            dr["Rua"] = AcessoBD.leitor["rua"].ToString();
                            dr["Bairro"] = AcessoBD.leitor["bairro"].ToString();
                            dr["Cidade"] = AcessoBD.leitor["cidade"].ToString();
                            dr["Telefone 1"] = AcessoBD.leitor["telefone1"].ToString();
                            dr["Telefone 2"] = AcessoBD.leitor["telefone2"].ToString();
                            dr["E-mail"] = AcessoBD.leitor["email"].ToString();

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
