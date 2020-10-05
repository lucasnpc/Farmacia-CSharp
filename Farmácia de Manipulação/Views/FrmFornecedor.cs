using System;
using System.Collections.Generic;
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
        /*Fim Status*/

        private void fornecedor_Load(object sender, EventArgs e)
        {
            statusInicial();
        }
        private void bCadastraForn_Click(object sender, EventArgs e)
        {
            if (tbNomeFornc.Text != "" && mbCnpj.Text != "  ,   ,   -    -")
            {
                mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = mbCnpj.Text;
                if (valida.validaCnpj(cnpj) == true) 
                {
                    if (new FornecedorDAO().Insere(new Fornecedor
                    {
                        cnpj = mbCnpj.Text.Trim(),
                        nome = tbNomeFornc.Text.Trim(),
                        rua = tbRuaFornc.Text.Trim(),
                        numero = tbNumFornc.Text.Trim(),
                        bairro = tbBairroFornc.Text.Trim(),
                        cidade = tbCidadeFornc.Text.Trim(),
                        tel1 = mbTel1.Text,
                        tel2 = mbTel2.Text,
                        email = tbMailFornc.Text.Trim(),
                        cpf_funcionario = CpfFuncionario.cpfFunc
                    }))
                    {
                        MessageBox.Show("Fornecedor registrado com sucesso.");
                    }
                    limpar();
                }
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
            {
                List<Fornecedor> fornecedores = new FornecedorDAO().GetFornecedores();
                if (fornecedores != null)
                {
                    foreach (Fornecedor fornecedor in fornecedores)
                    {
                        if (fornecedor.cnpj.Equals(cnpj))
                        {

                            tbNomeFornc.Text = fornecedor.nome;
                            tbNumFornc.Text = fornecedor.numero;
                            tbRuaFornc.Text = fornecedor.rua;
                            tbBairroFornc.Text = fornecedor.bairro;
                            tbCidadeFornc.Text = fornecedor.cidade;
                            mbTel1.Text = fornecedor.tel1;
                            mbTel2.Text = fornecedor.tel2;
                            tbMailFornc.Text = fornecedor.email;
                            mbCnpj.Text = fornecedor.cnpj;
                            tbNomeFunc.Text = new CpfFuncionario().trasNomeFunc(fornecedor.cpf_funcionario);
                            statusAlter();
                        }
                    }
                }
            }
        }
        private void bAlteraForn_Click(object sender, EventArgs e)
        {
            mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (new FornecedorDAO().Atualiza(new Fornecedor
            {
                cnpj = mbCnpj.Text.Trim(),
                nome = tbNomeFornc.Text.Trim(),
                bairro = tbBairroFornc.Text.Trim(),
                cidade = tbCidadeFornc.Text.Trim(),
                email = tbMailFornc.Text.Trim(),
                numero = tbNumFornc.Text.Trim(),
                rua = tbRuaFornc.Text.Trim(),
                tel1 = mbTel1.Text.Trim(),
                tel2 = mbTel2.Text.Trim(),
                cpf_funcionario = CpfFuncionario.cpfFunc
            }))
                MessageBox.Show("Dados atualizados com sucesso.");
            limpar();
        }
        private void bExcluiForn_Click(object sender, EventArgs e)
        {
            mbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (new FornecedorDAO().Deleta(mbCnpj.Text))
                MessageBox.Show("Dados excluidos com sucesso.");
            limpar();
        }
        private void bSairForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
