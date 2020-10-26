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
