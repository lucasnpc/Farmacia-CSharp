using System;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class fornecedor : Form
    {
        public fornecedor()
        {
            InitializeComponent();
        }

        public static string cnpj;

        /* Status do Sistema de Cadastro*/
        private void statusInicial()
        {
            gbFornecedor.Enabled = false;
            bNovoForn.Enabled = true;
            bCadastraForn.Enabled = false;
            bAlteraForn.Enabled = false;
            bExcluiForn.Enabled = false;
            bSairForn.Enabled = true;
            bConsultaForn.Enabled = true;
        }

        private void statusCadastra()
        {
            gbFornecedor.Enabled = true;
            gbEndereco.Enabled = true; ;
            bNovoForn.Enabled = false;
            bCadastraForn.Enabled = true;
            bAlteraForn.Enabled = false;
            bExcluiForn.Enabled = false;
            bConsultaForn.Enabled = true;
            bSairForn.Enabled = true;
            tbNomeFunc.Text = new CpfFuncionario().trasNomeFunc(CpfFuncionario.cpfFunc);
            tbNomeFornc.Focus();
        }

        private void limpar()
        {
            tbNomeFornc.Clear();
            tbMailFornc.Clear();
            tbCidadeFornc.Clear();
            tbBairroFornc.Clear();
            tbNumFornc.Clear();
            tbRuaFornc.Clear();
            mbCnpj.Clear();
            mbTel1.Clear();
            mbTel2.Clear();
            statusInicial();
            tbNomeFunc.Clear();
        }

        private void statusAlter()
        {
            bNovoForn.Enabled = false;
            bCadastraForn.Enabled = false;
            bAlteraForn.Enabled = true;
            bExcluiForn.Enabled = true;
            bConsultaForn.Enabled = true;
            bSairForn.Enabled = true;
            gbFornecedor.Enabled = true;
        }
        //Fim Status

        private void fornecedor_Load(object sender, EventArgs e)
        {
            statusInicial();
        }

        /* Cadastro no banco dos registros*/
        private void cadastraFornc()
        {
            if (new FornecedorDAO().Insere(new Fornecedor(mbCnpj.Text.Trim(), tbNomeFornc.Text.Trim(), tbRuaFornc.Text.Trim(),
                tbNumFornc.Text.Trim(), tbBairroFornc.Text.Trim(), tbCidadeFornc.Text.Trim(), mbTel1.Text, mbTel2.Text, 
                tbMailFornc.Text.Trim(), 
                CpfFuncionario.cpfFunc)))
            {
                MessageBox.Show("Fornecedor registrado com sucesso.");
            }
            limpar();
        }
        //Fim de cadastro


        /*Retornar dados dos clientes para os campos*/
        private string retornaFornc(string cnpj)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "select * from fornecedor where cnpj = @cnpj";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cnpj", cnpj);
                conexao.comando.ExecuteNonQuery();
                NpgsqlDataReader leitor = conexao.comando.ExecuteReader();

                if (leitor.Read())
                {
                    tbNomeFornc.Text = leitor["nome"].ToString();
                    mbCnpj.Text = leitor["cnpj"].ToString();
                    mbTel1.Text = leitor["tel1"].ToString();
                    mbTel2.Text = leitor["tel2"].ToString();
                    tbNumFornc.Text = leitor["numero"].ToString();
                    tbRuaFornc.Text = leitor["rua"].ToString();
                    tbBairroFornc.Text = leitor["bairro"].ToString();
                    tbCidadeFornc.Text = leitor["cidade"].ToString();
                    tbMailFornc.Text = leitor["email"].ToString();
                    statusAlter();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.");
                    limpar();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cnpj;
        }
        //Fim retornos


        /*Inicio alteracoes*/
        private void alteraFornc()
        {
            try
            {
                mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                conexao.fecharConexao();
                string sql = "UPDATE fornecedor SET nome = @nome," +
                    "numero = @numero," +
                    "rua = @rua," +
                    "bairro = @bairro," +
                    "cidade = @cidade," +
                    "tel1 = @tel1," +
                    "tel2 = @tel2," +
                    "email = @email " +
                    "WHERE cnpj = @cnpj";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@nome", tbNomeFornc.Text);
                conexao.comando.Parameters.AddWithValue("@numero", tbNumFornc.Text);
                conexao.comando.Parameters.AddWithValue("@rua", tbRuaFornc.Text);
                conexao.comando.Parameters.AddWithValue("@bairro", tbBairroFornc.Text);
                conexao.comando.Parameters.AddWithValue("@cidade", tbCidadeFornc.Text);
                conexao.comando.Parameters.AddWithValue("@tel1", mbTel1.Text);
                conexao.comando.Parameters.AddWithValue("@tel2", mbTel2.Text);
                conexao.comando.Parameters.AddWithValue("@email", tbMailFornc.Text);
                conexao.comando.Parameters.AddWithValue("@cnpj", mbCnpj.Text);

                conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso.");
                limpar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletaFornc()
        {
            try
            {
                mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                conexao.fecharConexao();
                string sql = "DELETE FROM fornecedor WHERE cnpj = @cnpj";
                conexao.abrirConexao();
                conexao.comando = new NpgsqlCommand(sql, conexao.conecta);
                conexao.comando.Parameters.AddWithValue("@cnpj", mbCnpj.Text);
                conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso.");
                limpar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Fim alteracoes

        private void bCadastraForn_Click(object sender, EventArgs e)
        {
            if (tbNomeFornc.Text != "" && mbCnpj.Text != "  ,   ,   -    -")
            {
                mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = mbCnpj.Text;
                if (valida.validaCnpj(cnpj) == true)
                    cadastraFornc();
                else
                {
                    MessageBox.Show("CNPJ inválido, verifique novamente.");
                    mbCnpj.Focus();
                }
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }

        private void bNovoForn_Click(object sender, EventArgs e)
        {
            statusCadastra();
        }

        private void bConsultaForn_Click(object sender, EventArgs e)
        {
            consultaFornc consulta = new consultaFornc();
            consulta.ShowDialog();
            if (cnpj != null)
                retornaFornc(cnpj);
        }

        private void bAlteraForn_Click(object sender, EventArgs e)
        {
            alteraFornc();
        }

        private void bExcluiForn_Click(object sender, EventArgs e)
        {
            deletaFornc();
        }

        private void bSairForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
