namespace prjDESK_ONNA.paginas
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelEstilizado1 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.BtnLogar = new prjDESK_ONNA.ModeracaoBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.panelEstilizado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstilizado1
            // 
            this.panelEstilizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEstilizado1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEstilizado1.Controls.Add(this.BtnLogar);
            this.panelEstilizado1.Controls.Add(this.label3);
            this.panelEstilizado1.Controls.Add(this.TxtSenha);
            this.panelEstilizado1.Controls.Add(this.label1);
            this.panelEstilizado1.Controls.Add(this.TxtUsuario);
            this.panelEstilizado1.Controls.Add(this.label2);
            this.panelEstilizado1.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado1.CurvaturaBorda = 40;
            this.panelEstilizado1.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado1.Location = new System.Drawing.Point(158, 81);
            this.panelEstilizado1.Name = "panelEstilizado1";
            this.panelEstilizado1.Size = new System.Drawing.Size(435, 402);
            this.panelEstilizado1.TabIndex = 4;
            this.panelEstilizado1.TamanhoBorda = 0;
            this.panelEstilizado1.TextColor = System.Drawing.Color.White;
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.White;
            this.BtnLogar.BackgroudColor = System.Drawing.Color.White;
            this.BtnLogar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnLogar.CurvaturaBorda = 40;
            this.BtnLogar.FlatAppearance.BorderSize = 0;
            this.BtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnLogar.ForeColor = System.Drawing.Color.Black;
            this.BtnLogar.Location = new System.Drawing.Point(144, 303);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(150, 40);
            this.BtnLogar.TabIndex = 7;
            this.BtnLogar.TamanhoBorda = 0;
            this.BtnLogar.Text = "Logar";
            this.BtnLogar.TextColor = System.Drawing.Color.Black;
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(57, 239);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(332, 38);
            this.TxtSenha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome de usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(57, 124);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(332, 38);
            this.TxtUsuario.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.panelEstilizado1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelEstilizado1.ResumeLayout(false);
            this.panelEstilizado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private classes.PanelEstilizado panelEstilizado1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private ModeracaoBtn BtnLogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSenha;
    }
}