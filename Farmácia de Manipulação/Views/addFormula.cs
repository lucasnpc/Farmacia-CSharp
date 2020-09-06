using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class addFormula : Form
    {
        public addFormula()
        {
            InitializeComponent();
        }

        public static int id;
        public static string nomeFormula;
        public static double valor = 0;

        private void tbPesqFormula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesqFormula.Text != "")
                {
                    try
                    {
                        conexao.fecharConexao();
                        string sql = "SELECT * FROM formula WHERE descricao LIKE '" +
                            tbPesqFormula.Text + "%'";
                        conexao.abrirConexao();
                        conexao.comando = new Npgsql.NpgsqlCommand(sql, conexao.conecta);
                        conexao.comando.Parameters.AddWithValue("@descricao", tbPesqFormula.Text.Trim());
                        conexao.leitor = conexao.comando.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Código", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Preço", typeof(string));

                        while (conexao.leitor.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr["Código"] = conexao.leitor["id"].ToString();
                            dr["Descrição"] = conexao.leitor["descricao"].ToString();
                            dr["Preço"] = conexao.leitor["preco"].ToString();

                            dt.Rows.Add(dr);
                        }

                        gridFormula.DataSource = dt;
                        gridFormula.Update();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message) ;
                    }
                }
            }
        }
        
        private void gridFormula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = 0;
            nomeFormula = "";
            valor = 0;
            id = int.Parse(gridFormula.CurrentRow.Cells[0].Value.ToString());
            pedido.idFormula = id;
            nomeFormula = gridFormula.CurrentRow.Cells[1].Value.ToString();
            pedido.nomeFormula = nomeFormula;
            valor = double.Parse(gridFormula.CurrentRow.Cells[2].Value.ToString());
            pedido.valorFormula = valor;
            Close();
        }

        private void addFormula_Load(object sender, EventArgs e)
        {
            tbPesqFormula.Focus();
        }
    }
}
