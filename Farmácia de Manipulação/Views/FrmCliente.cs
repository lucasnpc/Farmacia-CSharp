using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using Farmácia_de_Manipulação.Utilidades;
using Microsoft.EntityFrameworkCore;

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
        /* Fim dos Status */
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
                {

                    if (new ClienteDAO().Insere(new Cliente
                    {
                        cpf = mbCpf.Text.Trim(),
                        nome = tbNomeCli.Text.Trim(),
                        data_nascimento = Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                        numero_residencia = tbNumeroCli.Text.Trim(),
                        rua = tbRuaCli.Text.Trim(),
                        bairro = tbBairroCli.Text.Trim(),
                        cidade = tbCidadeCli.Text.Trim(),
                        tel1 = mbTel1.Text.Trim(),
                        tel2 = mbTel2.Text.Trim(),
                        email = tbMailCli.Text.Trim(),
                        cpffunc = CpfFuncionario.cpfFunc
                    }))
                        MessageBox.Show("Cliente registrado com sucesso.");
                    limpar();
                }
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
            {
                List<Cliente> clientes = new ClienteDAO().GetClientes();

                if (clientes != null)
                {
                    foreach (Cliente cliente in clientes)
                    {
                        if (cliente.cpf.Equals(cpf))
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
                }
            }
        }
        private void bSairCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bAlteraCli_Click(object sender, EventArgs e)
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (new ClienteDAO().Atualiza(new Cliente
            {
                cpf = mbCpf.Text.Trim(),
                nome = tbNomeCli.Text.Trim(),
                data_nascimento = Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                numero_residencia = tbNumeroCli.Text.Trim(),
                rua = tbRuaCli.Text.Trim(),
                bairro = tbBairroCli.Text.Trim(),
                cidade = tbCidadeCli.Text.Trim(),
                tel1 = mbTel1.Text.Trim(),
                tel2 = mbTel2.Text.Trim(),
                email = tbMailCli.Text.Trim(),
                cpffunc = CpfFuncionario.cpfFunc
            }))
                MessageBox.Show("Dados atualizados com sucesso.");
            limpar();
        }
        private void bExcluiCli_Click(object sender, EventArgs e)
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (new ClienteDAO().Deleta(mbCpf.Text))
                MessageBox.Show("Dados excluidos com sucesso.");
            limpar();
        }
    }
}
