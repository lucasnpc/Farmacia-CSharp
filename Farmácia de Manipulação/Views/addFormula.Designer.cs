namespace Farmácia_de_Manipulação
{
    partial class addFormula
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
            this.gridFormula = new System.Windows.Forms.DataGridView();
            this.tbPesqFormula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFormula
            // 
            this.gridFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormula.Location = new System.Drawing.Point(6, 52);
            this.gridFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridFormula.Name = "gridFormula";
            this.gridFormula.Size = new System.Drawing.Size(409, 423);
            this.gridFormula.TabIndex = 0;
            this.gridFormula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFormula_CellDoubleClick);
            // 
            // tbPesqFormula
            // 
            this.tbPesqFormula.Location = new System.Drawing.Point(108, 15);
            this.tbPesqFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPesqFormula.Name = "tbPesqFormula";
            this.tbPesqFormula.Size = new System.Drawing.Size(303, 21);
            this.tbPesqFormula.TabIndex = 1;
            this.tbPesqFormula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesqFormula_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da fórmula:";
            // 
            // addFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesqFormula);
            this.Controls.Add(this.gridFormula);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Fórmula";
            this.Load += new System.EventHandler(this.addFormula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFormula;
        private System.Windows.Forms.TextBox tbPesqFormula;
        private System.Windows.Forms.Label label1;
    }
}