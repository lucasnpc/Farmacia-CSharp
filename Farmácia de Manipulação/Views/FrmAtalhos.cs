using System;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    public partial class Atalhos : Form
    {

        public Atalhos() 
        {
            InitializeComponent();
        }

        private void bFuncionario_Click(object sender, EventArgs e)
        {
            funcionario funcionario = new funcionario();
            funcionario.ShowDialog();
        }

        private void bCliente_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            c.ShowDialog();
        }

        private void bProduto_Click(object sender, EventArgs e)
        {
            produtos p = new produtos();
            p.ShowDialog();
        }

        private void bFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor f = new fornecedor();
            f.ShowDialog();
        }
    }
}
