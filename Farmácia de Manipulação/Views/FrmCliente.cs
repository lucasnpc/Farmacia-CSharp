using System;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Models;
using Farmácia_de_Manipulação.Controladores;

namespace Farmácia_de_Manipulação
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        public static string cpf;

        /* Status do Sistema de Cadastro*/
        private void statusInicial()
        {
            gbCli.Enabled = false;
            bNovoCli.Enabled = true;
            bCadastraCli.Enabled = false;
            bAlteraCli.Enabled = false;
            bExcluiCli.Enabled = false;
            bSairCli.Enabled = true;
            bConsultaCli.Enabled = true;
        }

        private void statusCadastra()
        {
            gbCli.Enabled = true;
            gbEndereco.Enabled = true; ;
            bNovoCli.Enabled = false;
            bCadastraCli.Enabled = true;
            bAlteraCli.Enabled = false;
            bExcluiCli.Enabled = false;
            bConsultaCli.Enabled = true;
            bSairCli.Enabled = true;
            tbNomeFuncAtende.Text = new CpfFuncionario().trasNomeFunc(CpfFuncionario.cpfFunc);
            tbNomeCli.Focus();
        }

        private void limpar()
        {
            tbNomeCli.Clear();
            tbMailCli.Clear();
            tbCidadeCli.Clear();
            tbBairroCli.Clear();
            tbNumeroCli.Clear();
            tbRuaCli.Clear();
            mbCpf.Clear();
            mbDataNasc.Clear();
            mbTel1.Clear();
            mbTel2.Clear();
            statusInicial();
            tbNomeFuncAtende.Clear();
        }

        private void statusAlter()
        {
            bNovoCli.Enabled = false;
            bCadastraCli.Enabled = false;
            bAlteraCli.Enabled = true;
            bExcluiCli.Enabled = true;
            bConsultaCli.Enabled = true;
            bSairCli.Enabled = true;
            gbCli.Enabled = true;
        }
        //Fim Status

        /* Cadastro no banco dos registros*/
        private void cadastraCli()
        {
            if (new ClienteDAO().Insere(new Cliente(mbCpf.Text.Trim(), tbNomeCli.Text.Trim(), Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                tbNumeroCli.Text.Trim(), tbRuaCli.Text.Trim(), tbBairroCli.Text.Trim(), tbCidadeCli.Text.Trim(), mbTel1.Text.Trim(), mbTel2.Text.Trim(),
                tbMailCli.Text.Trim(), CpfFuncionario.cpfFunc)))
                MessageBox.Show("Cliente registrado com sucesso.");
            limpar();
        }
        //Fim de cadastro

        /*Retornar dados dos clientes para os campos*/
        private void retornaFunc(string cpf)
        {
            Cliente cliente = new ClienteDAO().Retorna(cpf);

            if (cliente != null)
            {
                tbNomeCli.Text = cliente.nome;
                mbCpf.Text = cliente.cpf;
                mbDataNasc.Text = cliente.data_nascimento;
                mbTel1.Text = cliente.tel1;
                mbTel2.Text = cliente.tel2;
                tbNumeroCli.Text = cliente.numero_residencia;
                tbRuaCli.Text = cliente.rua;
                tbBairroCli.Text = cliente.bairro;
                tbCidadeCli.Text = cliente.cidade;
                tbMailCli.Text = cliente.email;
                tbNomeFuncAtende.Text = new CpfFuncionario().trasNomeFunc(cliente.cpffunc);
                statusAlter();
            }
        }
        //Fim retornos

        /*Inicio alteracoes*/
        private void alteraCli()
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (new ClienteDAO().Atualiza(new Cliente(mbCpf.Text.Trim(), tbNomeCli.Text.Trim(), Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                tbNumeroCli.Text.Trim(), tbRuaCli.Text.Trim(),
                tbBairroCli.Text.Trim(), tbCidadeCli.Text.Trim(),
                mbTel1.Text.Trim(), mbTel2.Text.Trim(), tbMailCli.Text.Trim(),
                tbNomeFuncAtende.Text.Trim())))
                MessageBox.Show("Dados atualizados com sucesso.");
            limpar();
        }

        private void deletaCli()
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (new ClienteDAO().Deleta(mbCpf.Text))
                MessageBox.Show("Dados excluidos com sucesso.");
            limpar();
        }
        // Fim alteracoes

        private void cliente_Load(object sender, EventArgs e)
        {
            statusInicial();
        }

        private void bNovoCli_Click(object sender, EventArgs e)
        {
            statusCadastra();
        }

        private void bCadastraCli_Click(object sender, EventArgs e)
        {
            if (tbNomeCli.Text != "" && mbCpf.Text != "   ,   ,   -" && mbDataNasc.Text != "    -  -")
            {
                mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mbCpf.Text;
                if (valida.validacpf(cpf) == true)
                    cadastraCli();
                else
                {
                    MessageBox.Show("CPF inválido, verifique novamente.");
                    mbCpf.Focus();
                }
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }

        private void bConsultaCli_Click(object sender, EventArgs e)
        {
            consultaCli consulta = new consultaCli();
            consulta.ShowDialog();
            if (cpf != null)
                retornaFunc(cpf);
        }

        private void bSairCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAlteraCli_Click(object sender, EventArgs e)
        {
            alteraCli();
        }

        private void bExcluiCli_Click(object sender, EventArgs e)
        {
            deletaCli();
        }
    }
}
