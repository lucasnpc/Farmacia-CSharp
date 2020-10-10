using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using Farmácia_de_Manipulação.Views;

namespace Farmácia_de_Manipulação
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnCad.Width, btnCad.Height);
            btnCad.Region = new Region(forma);
            btnVenda.Region = new Region(forma);
            btnRelatorio.Region = new Region(forma);
        }

        private void menubom_Load(object sender, EventArgs e)
        {
        }
        //Menus strips
        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new funcionario().ShowDialog();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            new cliente().ShowDialog();
        }


        private void fornecedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            fornecedor fornc = new fornecedor();
            fornc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            produto produto = new produto();
            produto.ShowDialog();
        }

        private void bFim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Atalhos a = new Atalhos();
            a.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            venda pedidos = new venda();
            pedidos.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorios relatorios = new FrmRelatorios();
            relatorios.ShowDialog();
        }
    }
}
