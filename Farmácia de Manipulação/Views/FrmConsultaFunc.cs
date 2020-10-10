using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using Npgsql;

namespace Farmácia_de_Manipulação
{
    public partial class consultaFunc : Form
    {
        public consultaFunc()
        {
            InitializeComponent();
        }

        public static string cpf_func;
        private List<Funcionario> funcionarios = new List<Funcionario>();

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            funcionarios = new FuncionarioDAO().GetFuncionarios();

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
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Data de Admissão", typeof(string));

            foreach (Funcionario funcionario in funcionarios)
            {
                DataRow dr = dt.NewRow();
                dr["CPF"] = funcionario.cpf;
                dr["Nome"] = funcionario.nome;
                dr["Data de Nascimento"] = funcionario.data_nascimento;
                dr["Número"] = funcionario.numero_residencia;
                dr["Rua"] = funcionario.rua;
                dr["Bairro"] = funcionario.bairro;
                dr["Cidade"] = funcionario.cidade;
                dr["Telefone 1"] = funcionario.tel1;
                dr["Telefone 2"] = funcionario.tel2;
                dr["E-mail"] = funcionario.email;
                dr["Cargo"] = funcionario.cargo;
                dr["Data de Admissão"] = funcionario.data_admissao;

                dt.Rows.Add(dr);
            }
            gridConsultaFunc.DataSource = dt;
            gridConsultaFunc.Update();
        }
        // Fim cadastro

        private void consultaFunc_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaFunc_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridConsultaFunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf_func = gridConsultaFunc.CurrentRow.Cells[0].Value.ToString();
            funcionario.cpf = cpf_func;
            Close();
        }

        private void tbPesqFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqFunc.Text != string.Empty)
                {

                    IEnumerable<Funcionario> consultaFunc =
                        from funcionario in funcionarios
                        where funcionario.nome.Contains(tbPesqFunc.Text.ToUpper())
                        select funcionario;

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
                    dt.Columns.Add("Cargo", typeof(string));
                    dt.Columns.Add("Data de Admissão", typeof(string));

                    foreach (Funcionario f in consultaFunc)
                    {
                        DataRow dr = dt.NewRow();
                        dr["CPF"] = f.cpf;
                        dr["Nome"] = f.nome;
                        dr["Data de Nascimento"] = f.data_nascimento;
                        dr["Número"] = f.numero_residencia;
                        dr["Rua"] = f.rua;
                        dr["Bairro"] = f.bairro;
                        dr["Cidade"] = f.cidade;
                        dr["Telefone 1"] = f.tel1;
                        dr["Telefone 2"] = f.tel2;
                        dr["E-mail"] = f.email;
                        dr["Cargo"] = f.cargo;
                        dr["Data de Admissão"] = f.data_admissao;

                        dt.Rows.Add(dr);
                    }
                    gridConsultaFunc.DataSource = dt;
                    gridConsultaFunc.Update();
                }
            }
        }
    }
}