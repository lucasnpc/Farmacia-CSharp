using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;

namespace Farmácia_de_Manipulação
{
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }

        public static string cpf;
        /* Status do Sistema de Cadastro*/
        private void statusInicial()
        {
            gbFunc.Enabled = false;
            bNovoFunc.Enabled = true;
            bCadastraFunc.Enabled = false;
            bAlteraFunc.Enabled = false;
            bExcluiFunc.Enabled = false;
            bSairFunc.Enabled = true;
            bConsultaFunc.Enabled = true;
        }
        private void statusCadastra()
        {
            gbFunc.Enabled = true;
            gbEndereco.Enabled = true;
            gbAcesso.Enabled = false;
            bNovoFunc.Enabled = false;
            bCadastraFunc.Enabled = true;
            bAlteraFunc.Enabled = false;
            bExcluiFunc.Enabled = false;
            bConsultaFunc.Enabled = true;
            bSairFunc.Enabled = true;
            mbDataAdmiss.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            tbNomeFunc.Focus();
        }
        private void limpar()
        {
            tbNomeFunc.Clear();
            tbMailFunc.Clear();
            tbCidadeFunc.Clear();
            tbBairroFunc.Clear();
            tbNumeroFunc.Clear();
            tbRuaFunc.Clear();
            tbSenhaFunc.Clear();
            tbUserFunc.Clear();
            mbCpf.Clear();
            mbDataAdmiss.Clear();
            mbDataNasc.Clear();
            mbTel1.Clear();
            mbTel2.Clear();
            statusInicial();
            cbCargoFunc.Text = "";
        }
        private void statusAlter()
        {
            bNovoFunc.Enabled = false;
            bCadastraFunc.Enabled = false;
            bAlteraFunc.Enabled = true;
            bExcluiFunc.Enabled = true;
            bConsultaFunc.Enabled = true;
            bSairFunc.Enabled = true;
            gbFunc.Enabled = true;
        }
        /* Fim Status */

        private void funcionario_Load(object sender, EventArgs e)
        {
            statusInicial();
        }
        private void bNovoFunc_Click(object sender, EventArgs e)
        {
            statusCadastra();
        }
        private void cbCargoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargoFunc.Text == "Balconista" || cbCargoFunc.Text == "Farmacêutico")
            {
                gbAcesso.Enabled = true;
            }
            else
                gbAcesso.Enabled = false;
        }
        private void bCadastraFunc_Click(object sender, EventArgs e)
        {
            if (tbNomeFunc.Text != "" && mbCpf.Text != "   ,   ,   -" && mbDataNasc.Text != "    -  -")
            {
                mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mbCpf.Text;
                if (valida.validacpf(cpf) == true)
                {
                    if (new FuncionarioDAO().Insere(new Funcionario
                    {
                        cpf = mbCpf.Text.Trim(),
                        nome = tbNomeFunc.Text.Trim(),
                        data_nascimento = Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                        numero_residencia = tbNumeroFunc.Text.Trim(),
                        rua = tbRuaFunc.Text.Trim(),
                        bairro = tbBairroFunc.Text.Trim(),
                        cidade = tbCidadeFunc.Text.Trim(),
                        tel1 = mbTel1.Text.Trim(),
                        tel2 = mbTel2.Text.Trim(),
                        email = tbMailFunc.Text.Trim(),
                        usuario = tbUserFunc.Text.Trim(),
                        senha = tbSenhaFunc.Text.Trim(),
                        cargo = cbCargoFunc.Text.Trim(),
                        data_admissao = Convert.ToDateTime(mbDataAdmiss.Text).ToShortDateString()
                    }))
                        MessageBox.Show("Funcionário registrado com sucesso.");
                    limpar();
                }
                else
                    MessageBox.Show("CPF inválido, verifique novamente.");
                mbCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            else
                MessageBox.Show("Preencha os campos antes de cadastrar.");
        }
        private void bSairFunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bConsultaFunc_Click(object sender, EventArgs e)
        {
            consultaFunc consultaFuncionario = new consultaFunc();
            consultaFuncionario.ShowDialog();
            if (cpf != null)
            {
                List<Funcionario> funcionarios = new FuncionarioDAO().GetFuncionarios();

                if (funcionarios != null)
                {
                    foreach (Funcionario funcionario in funcionarios)
                    {
                        if (funcionario.cpf.Equals(cpf))
                        {
                            tbNomeFunc.Text = funcionario.nome;
                            mbCpf.Text = funcionario.cpf;
                            mbDataNasc.Text = funcionario.data_nascimento;
                            mbTel1.Text = funcionario.tel1;
                            mbTel2.Text = funcionario.tel2;
                            mbDataAdmiss.Text = funcionario.data_admissao;
                            tbNumeroFunc.Text = funcionario.numero_residencia;
                            tbRuaFunc.Text = funcionario.rua;
                            tbBairroFunc.Text = funcionario.bairro;
                            tbCidadeFunc.Text = funcionario.cidade;
                            tbMailFunc.Text = funcionario.email;
                            cbCargoFunc.Text = funcionario.cargo;
                            tbUserFunc.Text = funcionario.usuario;
                            tbSenhaFunc.Text = funcionario.senha;
                            statusAlter();
                        }
                    }
                }
            }
        }
        private void bAlteraFunc_Click(object sender, EventArgs e)
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (new FuncionarioDAO().Atualiza(new Funcionario
            {
                cpf = mbCpf.Text.Trim(),
                nome = tbNomeFunc.Text.Trim(),
                data_nascimento = Convert.ToDateTime(mbDataNasc.Text).ToShortDateString(),
                numero_residencia = tbNumeroFunc.Text.Trim(),
                rua = tbRuaFunc.Text.Trim(),
                bairro = tbBairroFunc.Text.Trim(),
                cidade = tbCidadeFunc.Text.Trim(),
                tel1 = mbTel1.Text.Trim(),
                tel2 = mbTel2.Text.Trim(),
                email = tbMailFunc.Text.Trim(),
                usuario = tbUserFunc.Text.Trim(),
                senha = tbSenhaFunc.Text.Trim(),
                cargo = cbCargoFunc.Text.Trim(),
                data_admissao = Convert.ToDateTime(mbDataAdmiss.Text).ToShortDateString()
            }))
                MessageBox.Show("Dados atualizados com sucesso.");
            limpar();
        }
        private void bExcluiFunc_Click(object sender, EventArgs e)
        {
            mbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (new FuncionarioDAO().Deleta(mbCpf.Text))
                MessageBox.Show("Dados excluidos com sucesso.");
            limpar();
        }
    }
}
