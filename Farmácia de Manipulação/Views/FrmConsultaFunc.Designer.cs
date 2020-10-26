namespace Farmácia_de_Manipulação
{
    partial class consultaFunc
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
            this.tbPesqFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridConsultaFunc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesqFunc
            // 
            this.tbPesqFunc.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPesqFunc.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqFunc.Location = new System.Drawing.Point(427, 10);
            this.tbPesqFunc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPesqFunc.Name = "tbPesqFunc";
            this.tbPesqFunc.Size = new System.Drawing.Size(429, 27);
            this.tbPesqFunc.TabIndex = 0;
            this.tbPesqFunc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqFunc_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entre com o nome do funcionário desejado:";
            // 
            // gridConsultaFunc
            // 
            this.gridConsultaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultaFunc.Location = new System.Drawing.Point(8, 51);
            this.gridConsultaFunc.Name = "gridConsultaFunc";
            this.gridConsultaFunc.RowHeadersWidth = 51;
            this.gridConsultaFunc.Size = new System.Drawing.Size(897, 383);
            this.gridConsultaFunc.TabIndex = 2;
            this.gridConsultaFunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultaFunc_CellDoubleClick);
            this.gridConsultaFunc.DoubleClick += new System.EventHandler(this.gridConsultaFunc_DoubleClick);
            // 
            // consultaFunc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.gridConsultaFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesqFunc);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "consultaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.consultaFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesqFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridConsultaFunc;
    }
}