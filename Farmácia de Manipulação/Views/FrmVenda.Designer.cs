namespace Farmácia_de_Manipulação
{
    partial class venda
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
            this.gbReceitaFormProd = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPesqProdutos = new System.Windows.Forms.TextBox();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.maskCpfCliVenda = new System.Windows.Forms.MaskedTextBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bRealizaPedido = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbReceitaFormProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReceitaFormProd
            // 
            this.gbReceitaFormProd.Controls.Add(this.label4);
            this.gbReceitaFormProd.Controls.Add(this.tbPesqProdutos);
            this.gbReceitaFormProd.Controls.Add(this.lvProdutos);
            this.gbReceitaFormProd.Controls.Add(this.maskCpfCliVenda);
            this.gbReceitaFormProd.Controls.Add(this.gridProdutos);
            this.gbReceitaFormProd.Controls.Add(this.label1);
            this.gbReceitaFormProd.Controls.Add(this.lblProduto);
            this.gbReceitaFormProd.Controls.Add(this.label8);
            this.gbReceitaFormProd.Controls.Add(this.label7);
            this.gbReceitaFormProd.Controls.Add(this.tbQuantidade);
            this.gbReceitaFormProd.Controls.Add(this.label6);
            this.gbReceitaFormProd.Controls.Add(this.tbCodProduto);
            this.gbReceitaFormProd.Controls.Add(this.tbSubTotal);
            this.gbReceitaFormProd.Controls.Add(this.tbNomeCliente);
            this.gbReceitaFormProd.Controls.Add(this.label2);
            this.gbReceitaFormProd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReceitaFormProd.Location = new System.Drawing.Point(9, 91);
            this.gbReceitaFormProd.Name = "gbReceitaFormProd";
            this.gbReceitaFormProd.Size = new System.Drawing.Size(1087, 441);
            this.gbReceitaFormProd.TabIndex = 0;
            this.gbReceitaFormProd.TabStop = false;
            this.gbReceitaFormProd.Text = "Dados da Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "PESQUISAR PRODUTOS";
            // 
            // tbPesqProdutos
            // 
            this.tbPesqProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqProdutos.Location = new System.Drawing.Point(717, 45);
            this.tbPesqProdutos.Name = "tbPesqProdutos";
            this.tbPesqProdutos.Size = new System.Drawing.Size(352, 24);
            this.tbPesqProdutos.TabIndex = 29;
            this.tbPesqProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqProdutos_KeyDown);
            // 
            // lvProdutos
            // 
            this.lvProdutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProdutos.HideSelection = false;
            this.lvProdutos.Location = new System.Drawing.Point(11, 202);
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(169, 206);
            this.lvProdutos.TabIndex = 28;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // maskCpfCliVenda
            // 
            this.maskCpfCliVenda.Font = new System.Drawing.Font("Arial", 10F);
            this.maskCpfCliVenda.Location = new System.Drawing.Point(11, 99);
            this.maskCpfCliVenda.Mask = "000.000.000-00";
            this.maskCpfCliVenda.Name = "maskCpfCliVenda";
            this.maskCpfCliVenda.Size = new System.Drawing.Size(228, 27);
            this.maskCpfCliVenda.TabIndex = 27;
            this.maskCpfCliVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskCpfCliVenda_KeyDown);
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(717, 75);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.Size = new System.Drawing.Size(352, 250);
            this.gridProdutos.TabIndex = 13;
            this.gridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF CLIENTE";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(273, 311);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(173, 23);
            this.lblProduto.TabIndex = 24;
            this.lblProduto.Text = "NOME PRODUTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "QUANTIDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "CÓDIGO PRODUTO";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidade.Location = new System.Drawing.Point(388, 42);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(228, 24);
            this.tbQuantidade.TabIndex = 18;
            this.tbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantidade_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "SUB-TOTAL";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Enabled = false;
            this.tbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodProduto.Location = new System.Drawing.Point(11, 45);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(228, 24);
            this.tbCodProduto.TabIndex = 19;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(277, 384);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(228, 24);
            this.tbSubTotal.TabIndex = 16;
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCliente.Location = new System.Drawing.Point(11, 155);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(329, 24);
            this.tbNomeCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME DO CLIENTE";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(329, 573);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.ReadOnly = true;
            this.tbDesconto.Size = new System.Drawing.Size(141, 24);
            this.tbDesconto.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(326, 555);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "DESCONTO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(631, 555);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "PREÇO TOTAL";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(634, 574);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(141, 24);
            this.tbTotal.TabIndex = 27;
            // 
            // bRealizaPedido
            // 
            this.bRealizaPedido.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRealizaPedido.Location = new System.Drawing.Point(949, 558);
            this.bRealizaPedido.Name = "bRealizaPedido";
            this.bRealizaPedido.Size = new System.Drawing.Size(147, 40);
            this.bRealizaPedido.TabIndex = 28;
            this.bRealizaPedido.Text = "REALIZAR VENDA";
            this.bRealizaPedido.UseVisualStyleBackColor = true;
            this.bRealizaPedido.Click += new System.EventHandler(this.bRealizaPedido_Click);
            // 
            // bSair
            // 
            this.bSair.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSair.Location = new System.Drawing.Point(9, 555);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(147, 40);
            this.bSair.TabIndex = 29;
            this.bSair.Text = "SAIR";
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNomeFuncionario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Funcionário";
            // 
            // tbNomeFuncionario
            // 
            this.tbNomeFuncionario.Enabled = false;
            this.tbNomeFuncionario.Font = new System.Drawing.Font("Arial", 10F);
            this.tbNomeFuncionario.Location = new System.Drawing.Point(202, 26);
            this.tbNomeFuncionario.Name = "tbNomeFuncionario";
            this.tbNomeFuncionario.Size = new System.Drawing.Size(416, 27);
            this.tbNomeFuncionario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOME DO FUNCIONÁRIO";
            // 
            // venda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.bRealizaPedido);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.gbReceitaFormProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vendas";
            this.Load += new System.EventHandler(this.venda_Load);
            this.gbReceitaFormProd.ResumeLayout(false);
            this.gbReceitaFormProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReceitaFormProd;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button bRealizaPedido;
        private System.Windows.Forms.Button bSair;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskCpfCliVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNomeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPesqProdutos;
    }
}