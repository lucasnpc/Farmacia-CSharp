namespace Farmácia_de_Manipulação
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEntra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(76, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIO";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.AliceBlue;
            this.tbUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.Black;
            this.tbUser.Location = new System.Drawing.Point(79, 95);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(263, 28);
            this.tbUser.TabIndex = 1;
            // 
            // tbPw
            // 
            this.tbPw.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPw.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPw.ForeColor = System.Drawing.Color.Black;
            this.tbPw.Location = new System.Drawing.Point(79, 190);
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.Size = new System.Drawing.Size(263, 28);
            this.tbPw.TabIndex = 3;
            this.tbPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPw_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(76, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // bEntra
            // 
            this.bEntra.BackColor = System.Drawing.Color.DodgerBlue;
            this.bEntra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bEntra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEntra.FlatAppearance.BorderSize = 0;
            this.bEntra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEntra.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bEntra.Location = new System.Drawing.Point(144, 234);
            this.bEntra.Name = "bEntra";
            this.bEntra.Size = new System.Drawing.Size(138, 42);
            this.bEntra.TabIndex = 4;
            this.bEntra.Text = "ENTRAR";
            this.bEntra.UseVisualStyleBackColor = false;
            this.bEntra.Click += new System.EventHandler(this.bEntra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(167, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(423, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEntra);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEntra;
        private System.Windows.Forms.Label label3;
    }
}

