using System;
using System.Windows.Forms;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    class conexao
    {

        // DEFINE UMA STRING DE CONEXAO COM O SQL SERVER
        public static NpgsqlConnection conecta = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0211a;Database=farmacia;");
        // DEFINE DUAS VARIVES PARA EXECUTAR COMANDOS SQL
        public static NpgsqlCommand comando;
        public static NpgsqlDataReader leitor;

        // METODO QUE FAZ A ABERTURA DE CONEXAO COM O BANCO DE DADOS DEFINI LOGO ACIMA
        public static void abrirConexao()
        {
            try
            {
                conecta.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // METODO QUE FECHA A CONEXAO COM O BANCO DE DADOS
        public static void fecharConexao()
        {
            conecta.Close();

        }

    }
}
