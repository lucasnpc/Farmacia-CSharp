namespace Farmácia_de_Manipulação
{
    partial class consultaFornc
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
            this.gridConsultaFornc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesqFornc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaFornc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsultaFornc
            // 
            this.gridConsultaFornc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultaFornc.Location = new System.Drawing.Point(9, 49);
            this.gridConsultaFornc.Margin = new System.Windows.Forms.Padding(4);
            this.gridConsultaFornc.Name = "gridConsultaFornc";
            this.gridConsultaFornc.RowHeadersWidth = 51;
            this.gridConsultaFornc.Size = new System.Drawing.Size(897, 383);
            this.gridConsultaFornc.TabIndex = 8;
            this.gridConsultaFornc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultaFornc_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entre com o nome do fornecedor desejado:";
            // 
            // tbPesqFornc
            // 
            this.tbPesqFornc.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqFornc.Location = new System.Drawing.Point(416, 8);
            this.tbPesqFornc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPesqFornc.Name = "tbPesqFornc";
            this.tbPesqFornc.Size = new System.Drawing.Size(487, 27);
            this.tbPesqFornc.TabIndex = 6;
            this.tbPesqFornc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqFornc_KeyDown);
            // 
            // consultaFornc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.gridConsultaFornc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesqFornc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "consultaFornc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Fornecedores";
            this.Load += new System.EventHandler(this.consultaFornc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaFornc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsultaFornc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesqFornc;
    }
}