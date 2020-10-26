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

        private bool verificaAdmin() {
            AcessoBD.fecharConexao();
            string sql = "SELECT * FROM administrador WHERE usuario = @usuario and senha = @senha";
            AcessoBD.abrirConexao();

            AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
            AcessoBD.comando.Parameters.AddWithValue("@usuario", tbUser.Text);
            AcessoBD.comando.Parameters.AddWithValue("@senha", tbPw.Text);

            AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

            if (AcessoBD.leitor.Read())
            {
                CpfFuncionario.administrador = true;
                return true;
            }
            else
                return false;
        }
        private bool verificaUsuario()
        {
            try
            {
                AcessoBD.fecharConexao();
                string sql = "SELECT * FROM funcionarios WHERE usuario = @usuario and senha = @senha";
                AcessoBD.abrirConexao();

                AcessoBD.comando = new Npgsql.NpgsqlCommand(sql, AcessoBD.conecta);
                AcessoBD.comando.Parameters.AddWithValue("@usuario", tbUser.Text);
                AcessoBD.comando.Parameters.AddWithValue("@senha", tbPw.Text);

                AcessoBD.leitor = AcessoBD.comando.ExecuteReader();

                if (AcessoBD.leitor.Read())
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
                        if (verificaAdmin())
                        {
                            menu menu = new menu();
                            menu.ShowDialog();
                        }
                        else if (verificaUsuario()) 
                        {
                            new CpfFuncionario().GetCpfFunc(tbUser.Text);
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
