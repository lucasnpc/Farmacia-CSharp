namespace Farmácia_de_Manipulação
{
    partial class Atalhos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bFuncionario = new System.Windows.Forms.Button();
            this.bProduto = new System.Windows.Forms.Button();
            this.bCliente = new System.Windows.Forms.Button();
            this.bFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecione qual Cadastro deseja fazer:";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bFuncionario
            // 
            this.bFuncionario.BackColor = System.Drawing.Color.DodgerBlue;
            this.bFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bFuncionario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bFuncionario.Location = new System.Drawing.Point(65, 66);
            this.bFuncionario.Name = "bFuncionario";
            this.bFuncionario.Size = new System.Drawing.Size(286, 60);
            this.bFuncionario.TabIndex = 2;
            this.bFuncionario.Text = "FUNCIONÁRIO";
            this.bFuncionario.UseVisualStyleBackColor = false;
            this.bFuncionario.Click += new System.EventHandler(this.bFuncionario_Click);
            // 
            // bProduto
            // 
            this.bProduto.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bProduto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bProduto.Location = new System.Drawing.Point(65, 225);
            this.bProduto.Name = "bProduto";
            this.bProduto.Size = new System.Drawing.Size(286, 60);
            this.bProduto.TabIndex = 3;
            this.bProduto.Text = "PRODUTO";
            this.bProduto.UseVisualStyleBackColor = false;
            this.bProduto.Click += new System.EventHandler(this.bProduto_Click);
            // 
            // bCliente
            // 
            this.bCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.bCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCliente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCliente.Location = new System.Drawing.Point(65, 143);
            this.bCliente.Name = "bCliente";
            this.bCliente.Size = new System.Drawing.Size(286, 60);
            this.bCliente.TabIndex = 5;
            this.bCliente.Text = "CLIENTE";
            this.bCliente.UseVisualStyleBackColor = false;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // bFornecedor
            // 
            this.bFornecedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.bFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bFornecedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFornecedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bFornecedor.Location = new System.Drawing.Point(65, 302);
            this.bFornecedor.Name = "bFornecedor";
            this.bFornecedor.Size = new System.Drawing.Size(286, 60);
            this.bFornecedor.TabIndex = 6;
            this.bFornecedor.Text = "FORNECEDOR";
            this.bFornecedor.UseVisualStyleBackColor = false;
            this.bFornecedor.Click += new System.EventHandler(this.bFornecedor_Click);
            // 
            // Atalhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 485);
            this.Controls.Add(this.bFornecedor);
            this.Controls.Add(this.bCliente);
            this.Controls.Add(this.bProduto);
            this.Controls.Add(this.bFuncionario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Atalhos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTROS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bFuncionario;
        private System.Windows.Forms.Button bProduto;
        private System.Windows.Forms.Button bCliente;
        private System.Windows.Forms.Button bFornecedor;
    }
}