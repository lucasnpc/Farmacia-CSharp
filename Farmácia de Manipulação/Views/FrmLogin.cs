using System;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private string cpfFunc;

        private void retornaNomeFunc(string usuario)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select cpf from funcionario where usuario = @usuario";
                conexao.abrirConexao();
                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@usuario", usuario);
                conexao.leitor = conexao.comando.ExecuteReader();

                if (conexao.leitor.Read())
                {
                    cpfFunc = conexao.leitor["cpf"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool verificaUsuario()
        {
            int I = 0;
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT * FROM funcionario WHERE usuario = @usuario and senha = @senha";
                conexao.abrirConexao();

                conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@usuario", tbUser.Text);
                conexao.comando.Parameters.AddWithValue("@senha", tbPw.Text);

                conexao.leitor = conexao.comando.ExecuteReader();

                while (conexao.leitor.Read())
                {
                    I = I + 1;
                }
                if (I > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception) { throw; }
        }
        private void login_Load(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void bEncerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEntra_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaUsuario())
                {
                    menu menu = new menu();
                    menu.ShowDialog();
                }
                else
                    MessageBox.Show("Usuário ou senha inválidos.");

            }
            catch (Exception) { }
        }

        private void tbPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbPw.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        if (verificaUsuario())
                        {
                            retornaNomeFunc(tbUser.Text);
                            CpfFuncionario.cpfFunc = cpfFunc;
                            menu menu = new menu();
                            menu.ShowDialog();
                        }
                        else
                            MessageBox.Show("Usuário ou senha inválidos.");

                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
