namespace Farmácia_de_Manipulação
{
    partial class consultaCli
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
            this.gridConsultaCli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesqCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsultaCli
            // 
            this.gridConsultaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultaCli.Location = new System.Drawing.Point(9, 50);
            this.gridConsultaCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridConsultaCli.Name = "gridConsultaCli";
            this.gridConsultaCli.RowHeadersWidth = 51;
            this.gridConsultaCli.Size = new System.Drawing.Size(897, 383);
            this.gridConsultaCli.TabIndex = 5;
            this.gridConsultaCli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultaCli_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entre com o nome do cliente desejado:";
            // 
            // tbPesqCli
            // 
            this.tbPesqCli.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPesqCli.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqCli.Location = new System.Drawing.Point(390, 9);
            this.tbPesqCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPesqCli.Name = "tbPesqCli";
            this.tbPesqCli.Size = new System.Drawing.Size(506, 27);
            this.tbPesqCli.TabIndex = 3;
            this.tbPesqCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqCli_KeyDown);
            // 
            // consultaCli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.gridConsultaCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesqCli);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.consultaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsultaCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesqCli;
    }
}