using System;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class addCpf : Form
    {
        public addCpf()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        conexao.fecharConexao();
                        string sql = "SELECT cpf,nome FROM cliente WHERE cpf = @cpf";
                        conexao.abrirConexao();
                        conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                        conexao.comando.Parameters.AddWithValue("@cpf", textBox1.Text);
                        conexao.leitor = conexao.comando.ExecuteReader();
                        if (conexao.leitor.Read())
                        {
                            pedido.cpfCli = conexao.leitor["cpf"].ToString();
                            pedido.nomeCli = conexao.leitor["nome"].ToString();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("CPF incorreto.");
                    }
                }
            }
        }
    }
}
