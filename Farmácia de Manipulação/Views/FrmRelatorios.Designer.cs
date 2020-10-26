namespace Farmácia_de_Manipulação.Views
{
    partial class FrmRelatorios
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
            this.dataGridRelatorios = new System.Windows.Forms.DataGridView();
            this.bRelatorioVenda = new System.Windows.Forms.Button();
            this.exportarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRelatorios
            // 
            this.dataGridRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatorios.Location = new System.Drawing.Point(12, 76);
            this.dataGridRelatorios.Name = "dataGridRelatorios";
            this.dataGridRelatorios.RowHeadersWidth = 51;
            this.dataGridRelatorios.RowTemplate.Height = 24;
            this.dataGridRelatorios.Size = new System.Drawing.Size(1084, 547);
            this.dataGridRelatorios.TabIndex = 0;
            // 
            // bRelatorioVenda
            // 
            this.bRelatorioVenda.BackColor = System.Drawing.Color.DodgerBlue;
            this.bRelatorioVenda.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorioVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bRelatorioVenda.Location = new System.Drawing.Point(31, 12);
            this.bRelatorioVenda.Name = "bRelatorioVenda";
            this.bRelatorioVenda.Size = new System.Drawing.Size(197, 58);
            this.bRelatorioVenda.TabIndex = 1;
            this.bRelatorioVenda.Text = "GERAR RELATÓRIO DE VENDAS";
            this.bRelatorioVenda.UseVisualStyleBackColor = false;
            this.bRelatorioVenda.Click += new System.EventHandler(this.bRelatorioVenda_Click);
            // 
            // exportarPdf
            // 
            this.exportarPdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.exportarPdf.Enabled = false;
            this.exportarPdf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarPdf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportarPdf.Location = new System.Drawing.Point(923, 12);
            this.exportarPdf.Name = "exportarPdf";
            this.exportarPdf.Size = new System.Drawing.Size(154, 58);
            this.exportarPdf.TabIndex = 2;
            this.exportarPdf.Text = "EXPORTAR PDF";
            this.exportarPdf.UseVisualStyleBackColor = false;
            this.exportarPdf.Click += new System.EventHandler(this.exportarPdf_Click);
            // 
            // FrmRelatorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.exportarPdf);
            this.Controls.Add(this.bRelatorioVenda);
            this.Controls.Add(this.dataGridRelatorios);
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRelatorios;
        private System.Windows.Forms.Button bRelatorioVenda;
        private System.Windows.Forms.Button exportarPdf;
    }
}