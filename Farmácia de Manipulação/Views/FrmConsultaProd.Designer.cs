namespace Farmácia_de_Manipulação
{
    partial class consultaProduto
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
            this.gridConsultaProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesqProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsultaProd
            // 
            this.gridConsultaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultaProd.Location = new System.Drawing.Point(9, 49);
            this.gridConsultaProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridConsultaProd.Name = "gridConsultaProd";
            this.gridConsultaProd.RowHeadersWidth = 51;
            this.gridConsultaProd.Size = new System.Drawing.Size(897, 383);
            this.gridConsultaProd.TabIndex = 8;
            this.gridConsultaProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultaProd_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entre com o nome do produto desejado:";
            // 
            // tbPesqProd
            // 
            this.tbPesqProd.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPesqProd.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqProd.Location = new System.Drawing.Point(390, 7);
            this.tbPesqProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPesqProd.Name = "tbPesqProd";
            this.tbPesqProd.Size = new System.Drawing.Size(506, 27);
            this.tbPesqProd.TabIndex = 6;
            this.tbPesqProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqProd_KeyDown);
            // 
            // consultaProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.gridConsultaProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesqProd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultaProduto";
            this.Load += new System.EventHandler(this.consultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsultaProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesqProd;
    }
}