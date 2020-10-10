using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class consultaFornc : Form
    {
        public consultaFornc()
        {
            InitializeComponent();
        }

        public static string cnpj_fornc;
        private List<Fornecedor> fornecedores = new List<Fornecedor>();

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            fornecedores = new FornecedorDAO().GetFornecedores();

            DataTable dt = new DataTable();
            dt.Columns.Add("CNPJ", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Número", typeof(string));
            dt.Columns.Add("Rua", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Telefone 1", typeof(string));
            dt.Columns.Add("Telefone 2", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));

            foreach (Fornecedor f in fornecedores)
            {
                DataRow dr = dt.NewRow();
                dr["CNPJ"] = f.cnpj;
                dr["Nome"] = f.nome;
                dr["Número"] = f.numero;
                dr["Rua"] = f.rua;
                dr["Bairro"] = f.bairro;
                dr["Cidade"] = f.cidade;
                dr["Telefone 1"] = f.tel1;
                dr["Telefone 2"] = f.tel2;
                dr["E-mail"] = f.email;

                dt.Rows.Add(dr);
            }
            gridConsultaFornc.DataSource = dt;
            gridConsultaFornc.Update();
        }
        // Fim cadastro


        private void consultaFornc_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaFornc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cnpj_fornc = gridConsultaFornc.CurrentRow.Cells[0].Value.ToString();
            fornecedor.cnpj = cnpj_fornc;
            Close();
        }

        private void tbPesqFornc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqFornc.Text != "")
                {
                    IEnumerable<Fornecedor> consultaFornecedor =
                        from fornecedor in fornecedores
                        where fornecedor.nome.Contains(tbPesqFornc.Text.ToUpper())
                        select fornecedor;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CNPJ", typeof(string));
                    dt.Columns.Add("Nome", typeof(string));
                    dt.Columns.Add("Número", typeof(string));
                    dt.Columns.Add("Rua", typeof(string));
                    dt.Columns.Add("Bairro", typeof(string));
                    dt.Columns.Add("Cidade", typeof(string));
                    dt.Columns.Add("Telefone 1", typeof(string));
                    dt.Columns.Add("Telefone 2", typeof(string));
                    dt.Columns.Add("E-mail", typeof(string));

                    foreach (Fornecedor f in consultaFornecedor)
                    {
                        DataRow dr = dt.NewRow();
                        dr["CNPJ"] = f.cnpj;
                        dr["Nome"] = f.nome;
                        dr["Número"] = f.numero;
                        dr["Rua"] = f.rua;
                        dr["Bairro"] = f.bairro;
                        dr["Cidade"] = f.cidade;
                        dr["Telefone 1"] = f.tel1;
                        dr["Telefone 2"] = f.tel2;
                        dr["E-mail"] = f.email;

                        dt.Rows.Add(dr);
                    }
                    gridConsultaFornc.DataSource = dt;
                    gridConsultaFornc.Update();

                }
            }

        }
    }
}
