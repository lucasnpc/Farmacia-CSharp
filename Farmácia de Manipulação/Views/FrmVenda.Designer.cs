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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDosagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.mbRetirada = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mbEncomenda = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCpfCli = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFormulas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReceita = new System.Windows.Forms.TextBox();
            this.tbPgtoAntecipado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bRealizaPedido = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gbReceitaFormProd.SuspendLayout();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReceitaFormProd
            // 
            this.gbReceitaFormProd.Controls.Add(this.label1);
            this.gbReceitaFormProd.Controls.Add(this.textBox1);
            this.gbReceitaFormProd.Controls.Add(this.lblProduto);
            this.gbReceitaFormProd.Controls.Add(this.label8);
            this.gbReceitaFormProd.Controls.Add(this.label7);
            this.gbReceitaFormProd.Controls.Add(this.tbDosagem);
            this.gbReceitaFormProd.Controls.Add(this.label6);
            this.gbReceitaFormProd.Controls.Add(this.tbCodProduto);
            this.gbReceitaFormProd.Controls.Add(this.tbSubTotal);
            this.gbReceitaFormProd.Controls.Add(this.tbInfo);
            this.gbReceitaFormProd.Controls.Add(this.label4);
            this.gbReceitaFormProd.Controls.Add(this.tbNomePaciente);
            this.gbReceitaFormProd.Controls.Add(this.label2);
            this.gbReceitaFormProd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReceitaFormProd.Location = new System.Drawing.Point(9, 6);
            this.gbReceitaFormProd.Name = "gbReceitaFormProd";
            this.gbReceitaFormProd.Size = new System.Drawing.Size(1087, 334);
            this.gbReceitaFormProd.TabIndex = 0;
            this.gbReceitaFormProd.TabStop = false;
            this.gbReceitaFormProd.Text = "Dados Receita e Fórmulas";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 25;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(385, 200);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(130, 17);
            this.lblProduto.TabIndex = 24;
            this.lblProduto.Text = "NOME PRODUTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "QUANTIDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "CÓDIGO PRODUTO";
            // 
            // tbDosagem
            // 
            this.tbDosagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDosagem.Location = new System.Drawing.Point(320, 42);
            this.tbDosagem.Name = "tbDosagem";
            this.tbDosagem.Size = new System.Drawing.Size(228, 24);
            this.tbDosagem.TabIndex = 18;
            this.tbDosagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDosagem_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "SUB-TOTAL";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodProduto.Location = new System.Drawing.Point(11, 42);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(228, 24);
            this.tbCodProduto.TabIndex = 19;
            this.tbCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodProduto_KeyDown);
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(388, 268);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(228, 24);
            this.tbSubTotal.TabIndex = 16;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(9, 200);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(329, 93);
            this.tbInfo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "INFORMAÇÕES";
            // 
            // tbNomePaciente
            // 
            this.tbNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePaciente.Location = new System.Drawing.Point(11, 149);
            this.tbNomePaciente.Name = "tbNomePaciente";
            this.tbNomePaciente.ReadOnly = true;
            this.tbNomePaciente.Size = new System.Drawing.Size(329, 24);
            this.tbNomePaciente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME DO CLIENTE";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.gridProdutos);
            this.gbPedido.Controls.Add(this.label14);
            this.gbPedido.Controls.Add(this.mbRetirada);
            this.gbPedido.Controls.Add(this.label13);
            this.gbPedido.Controls.Add(this.mbEncomenda);
            this.gbPedido.Controls.Add(this.label12);
            this.gbPedido.Controls.Add(this.tbNomeCli);
            this.gbPedido.Controls.Add(this.label11);
            this.gbPedido.Controls.Add(this.tbCpfCli);
            this.gbPedido.Controls.Add(this.label10);
            this.gbPedido.Controls.Add(this.cbFormulas);
            this.gbPedido.Controls.Add(this.label9);
            this.gbPedido.Controls.Add(this.tbReceita);
            this.gbPedido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.Location = new System.Drawing.Point(9, 346);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(1087, 141);
            this.gbPedido.TabIndex = 9;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Dados do Pedido";
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(602, 18);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.Size = new System.Drawing.Size(259, 116);
            this.gridProdutos.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "DATA DE RETIRADA";
            // 
            // mbRetirada
            // 
            this.mbRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbRetirada.Location = new System.Drawing.Point(218, 44);
            this.mbRetirada.Mask = "####-##-##";
            this.mbRetirada.Name = "mbRetirada";
            this.mbRetirada.Size = new System.Drawing.Size(138, 24);
            this.mbRetirada.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "DATA DE ENCOMENDA";
            // 
            // mbEncomenda
            // 
            this.mbEncomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbEncomenda.Location = new System.Drawing.Point(10, 44);
            this.mbEncomenda.Mask = "##-##-####";
            this.mbEncomenda.Name = "mbEncomenda";
            this.mbEncomenda.ReadOnly = true;
            this.mbEncomenda.Size = new System.Drawing.Size(138, 24);
            this.mbEncomenda.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(215, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "NOME DO CLIENTE";
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCli.Location = new System.Drawing.Point(218, 102);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.ReadOnly = true;
            this.tbNomeCli.Size = new System.Drawing.Size(138, 24);
            this.tbNomeCli.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "CPF DO CLIENTE";
            // 
            // tbCpfCli
            // 
            this.tbCpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCpfCli.Location = new System.Drawing.Point(10, 102);
            this.tbCpfCli.Name = "tbCpfCli";
            this.tbCpfCli.ReadOnly = true;
            this.tbCpfCli.Size = new System.Drawing.Size(138, 24);
            this.tbCpfCli.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "FÓRMULAS";
            // 
            // cbFormulas
            // 
            this.cbFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormulas.FormattingEnabled = true;
            this.cbFormulas.Location = new System.Drawing.Point(426, 103);
            this.cbFormulas.Name = "cbFormulas";
            this.cbFormulas.Size = new System.Drawing.Size(138, 26);
            this.cbFormulas.TabIndex = 2;
            this.cbFormulas.SelectedIndexChanged += new System.EventHandler(this.cbFormulas_SelectedIndexChanged);
            this.cbFormulas.Leave += new System.EventHandler(this.cbFormulas_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "NÚMERO DA REQUISIÇÃO";
            // 
            // tbReceita
            // 
            this.tbReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceita.Location = new System.Drawing.Point(426, 46);
            this.tbReceita.Name = "tbReceita";
            this.tbReceita.ReadOnly = true;
            this.tbReceita.Size = new System.Drawing.Size(138, 24);
            this.tbReceita.TabIndex = 0;
            // 
            // tbPgtoAntecipado
            // 
            this.tbPgtoAntecipado.Location = new System.Drawing.Point(329, 511);
            this.tbPgtoAntecipado.Name = "tbPgtoAntecipado";
            this.tbPgtoAntecipado.ReadOnly = true;
            this.tbPgtoAntecipado.Size = new System.Drawing.Size(141, 24);
            this.tbPgtoAntecipado.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(326, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "DESCONTO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(631, 493);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "PREÇO TOTAL";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(634, 512);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(141, 24);
            this.tbTotal.TabIndex = 27;
            // 
            // bRealizaPedido
            // 
            this.bRealizaPedido.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRealizaPedido.Location = new System.Drawing.Point(949, 496);
            this.bRealizaPedido.Name = "bRealizaPedido";
            this.bRealizaPedido.Size = new System.Drawing.Size(147, 40);
            this.bRealizaPedido.TabIndex = 28;
            this.bRealizaPedido.Text = "REALIZAR PEDIDO";
            this.bRealizaPedido.UseVisualStyleBackColor = true;
            this.bRealizaPedido.Click += new System.EventHandler(this.bRealizaPedido_Click);
            // 
            // bSair
            // 
            this.bSair.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSair.Location = new System.Drawing.Point(9, 493);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(147, 40);
            this.bSair.TabIndex = 29;
            this.bSair.Text = "SAIR";
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // venda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.bRealizaPedido);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbPgtoAntecipado);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.gbReceitaFormProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de pedidos";
            this.Load += new System.EventHandler(this.pedido_Load);
            this.gbReceitaFormProd.ResumeLayout(false);
            this.gbReceitaFormProd.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReceitaFormProd;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDosagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mbRetirada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mbEncomenda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCpfCli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFormulas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReceita;
        private System.Windows.Forms.TextBox tbPgtoAntecipado;
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
        private System.Windows.Forms.TextBox textBox1;
    }
}