using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class consultaCli : Form
    {
        public consultaCli()
        {
            InitializeComponent();
        }

        public static string cpf_cli;
        private List<Cliente> clientes = new List<Cliente>();

        // Funcao que tras os dados do banco para a tela de consulta
        private void carregaGird()
        {
            clientes = new ClienteDAO().GetClientes();

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

            foreach (Cliente c in clientes)
            {
                DataRow dr = dt.NewRow();
                dr["CPF"] = c.cpf;
                dr["Nome"] = c.nome;
                dr["Data de Nascimento"] = c.data_nascimento;
                dr["Número"] = c.numero_residencia;
                dr["Rua"] = c.rua;
                dr["Bairro"] = c.bairro;
                dr["Cidade"] = c.cidade;
                dr["Telefone 1"] = c.tel1;
                dr["Telefone 2"] = c.tel2;
                dr["E-mail"] = c.email;

                dt.Rows.Add(dr);
            }
            gridConsultaCli.DataSource = dt;
            gridConsultaCli.Update();
        }
        // Fim cadastro

        private void consultaCli_Load(object sender, EventArgs e)
        {
            carregaGird();
        }

        private void gridConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf_cli = gridConsultaCli.CurrentRow.Cells[0].Value.ToString();
            cliente.cpf = cpf_cli;
            Close();
        }

        private void tbPesqCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqCli.Text != string.Empty)
                {
                    IEnumerable<Cliente> consultaCli =
                        from cliente in clientes
                        where cliente.nome.Contains(tbPesqCli.Text.ToUpper())
                        select cliente;

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

                    foreach (Cliente c in consultaCli)
                    {
                        DataRow dr = dt.NewRow();
                        dr["CPF"] = c.cpf;
                        dr["Nome"] = c.nome;
                        dr["Data de Nascimento"] = c.data_nascimento;
                        dr["Número"] = c.numero_residencia;
                        dr["Rua"] = c.rua;
                        dr["Bairro"] = c.bairro;
                        dr["Cidade"] = c.cidade;
                        dr["Telefone 1"] = c.tel1;
                        dr["Telefone 2"] = c.tel2;
                        dr["E-mail"] = c.email;

                        dt.Rows.Add(dr);
                    }
                    gridConsultaCli.DataSource = dt;
                    gridConsultaCli.Update();
                }
            }
        }
    }
}
