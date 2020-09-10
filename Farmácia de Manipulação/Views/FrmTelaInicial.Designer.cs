namespace Farmácia_de_Manipulação
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bFim = new System.Windows.Forms.Button();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroDeReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroGeralDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gridEspecialidade = new System.Windows.Forms.DataGridView();
            this.tbMalaDireta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // bFim
            // 
            this.bFim.BackColor = System.Drawing.Color.PapayaWhip;
            this.bFim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bFim.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFim.Location = new System.Drawing.Point(1044, 636);
            this.bFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bFim.Name = "bFim";
            this.bFim.Size = new System.Drawing.Size(120, 47);
            this.bFim.TabIndex = 16;
            this.bFim.Text = "SAIR";
            this.bFim.UseVisualStyleBackColor = false;
            this.bFim.Click += new System.EventHandler(this.bFim_Click);
            // 
            // gridPedidos
            // 
            this.gridPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.GridColor = System.Drawing.SystemColors.Control;
            this.gridPedidos.Location = new System.Drawing.Point(635, 97);
            this.gridPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.RowHeadersWidth = 51;
            this.gridPedidos.Size = new System.Drawing.Size(412, 366);
            this.gridPedidos.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vendas de hoje";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(1068, 48);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 19);
            this.lblData.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1068, 76);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 19);
            this.lblHora.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.livroDeReceitasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click_1);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click_1);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click_1);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click_1);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.pedidosToolStripMenuItem.Text = "Venda";
            // 
            // registrarPedidoToolStripMenuItem
            // 
            this.registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            this.registrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarPedidoToolStripMenuItem.Text = "Registrar venda";
            this.registrarPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarPedidoToolStripMenuItem_Click_1);
            // 
            // livroDeReceitasToolStripMenuItem
            // 
            this.livroDeReceitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroGeralDeVendasToolStripMenuItem});
            this.livroDeReceitasToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livroDeReceitasToolStripMenuItem.Name = "livroDeReceitasToolStripMenuItem";
            this.livroDeReceitasToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.livroDeReceitasToolStripMenuItem.Text = "Registros";
            // 
            // livroGeralDeVendasToolStripMenuItem
            // 
            this.livroGeralDeVendasToolStripMenuItem.Name = "livroGeralDeVendasToolStripMenuItem";
            this.livroGeralDeVendasToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.livroGeralDeVendasToolStripMenuItem.Text = "Livro Geral de Vendas";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pesquisa por medicamentos";
            // 
            // gridEspecialidade
            // 
            this.gridEspecialidade.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridEspecialidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspecialidade.GridColor = System.Drawing.SystemColors.Control;
            this.gridEspecialidade.Location = new System.Drawing.Point(52, 97);
            this.gridEspecialidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridEspecialidade.Name = "gridEspecialidade";
            this.gridEspecialidade.RowHeadersWidth = 51;
            this.gridEspecialidade.Size = new System.Drawing.Size(412, 366);
            this.gridEspecialidade.TabIndex = 18;
            this.gridEspecialidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEspecialidade_CellDoubleClick_1);
            // 
            // tbMalaDireta
            // 
            this.tbMalaDireta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMalaDireta.Location = new System.Drawing.Point(297, 64);
            this.tbMalaDireta.Margin = new System.Windows.Forms.Padding(4);
            this.tbMalaDireta.Name = "tbMalaDireta";
            this.tbMalaDireta.Size = new System.Drawing.Size(177, 24);
            this.tbMalaDireta.TabIndex = 19;
            this.tbMalaDireta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMalaDireta_KeyDown_1);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.tbMalaDireta);
            this.Controls.Add(this.gridEspecialidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bFim);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menubom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecialidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bFim;
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPedidoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem livroDeReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroGeralDeVendasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridEspecialidade;
        private System.Windows.Forms.TextBox tbMalaDireta;
    }
}