namespace prjDESK_ONNA
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeslogar = new prjDESK_ONNA.ModeracaoBtn();
            this.panelEstilizado1 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.BtnMod = new prjDESK_ONNA.ModeracaoBtn();
            this.BtnArt = new prjDESK_ONNA.ModeracaoBtn();
            this.panelEstilizado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gerenciamento ONNA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDeslogar
            // 
            this.BtnDeslogar.BackColor = System.Drawing.Color.Crimson;
            this.BtnDeslogar.BackgroudColor = System.Drawing.Color.Crimson;
            this.BtnDeslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeslogar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnDeslogar.CurvaturaBorda = 33;
            this.BtnDeslogar.FlatAppearance.BorderSize = 0;
            this.BtnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeslogar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogar.ForeColor = System.Drawing.Color.White;
            this.BtnDeslogar.Location = new System.Drawing.Point(674, 484);
            this.BtnDeslogar.Name = "BtnDeslogar";
            this.BtnDeslogar.Size = new System.Drawing.Size(98, 39);
            this.BtnDeslogar.TabIndex = 5;
            this.BtnDeslogar.TamanhoBorda = 0;
            this.BtnDeslogar.Text = "Deslogar ";
            this.BtnDeslogar.TextColor = System.Drawing.Color.White;
            this.BtnDeslogar.UseVisualStyleBackColor = false;
            this.BtnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click);
            // 
            // panelEstilizado1
            // 
            this.panelEstilizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEstilizado1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEstilizado1.Controls.Add(this.BtnMod);
            this.panelEstilizado1.Controls.Add(this.BtnArt);
            this.panelEstilizado1.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado1.CurvaturaBorda = 40;
            this.panelEstilizado1.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado1.Location = new System.Drawing.Point(150, 187);
            this.panelEstilizado1.Name = "panelEstilizado1";
            this.panelEstilizado1.Size = new System.Drawing.Size(481, 242);
            this.panelEstilizado1.TabIndex = 4;
            this.panelEstilizado1.TamanhoBorda = 0;
            this.panelEstilizado1.TextColor = System.Drawing.Color.White;
            // 
            // BtnMod
            // 
            this.BtnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnMod.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnMod.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnMod.CurvaturaBorda = 40;
            this.BtnMod.FlatAppearance.BorderSize = 0;
            this.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMod.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMod.ForeColor = System.Drawing.Color.Black;
            this.BtnMod.Location = new System.Drawing.Point(63, 43);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(350, 57);
            this.BtnMod.TabIndex = 2;
            this.BtnMod.TamanhoBorda = 0;
            this.BtnMod.Text = "Moderação";
            this.BtnMod.TextColor = System.Drawing.Color.Black;
            this.BtnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnArt
            // 
            this.BtnArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnArt.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnArt.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnArt.CurvaturaBorda = 40;
            this.BtnArt.FlatAppearance.BorderSize = 0;
            this.BtnArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArt.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArt.ForeColor = System.Drawing.Color.Black;
            this.BtnArt.Location = new System.Drawing.Point(63, 131);
            this.BtnArt.Name = "BtnArt";
            this.BtnArt.Size = new System.Drawing.Size(350, 57);
            this.BtnArt.TabIndex = 3;
            this.BtnArt.TamanhoBorda = 0;
            this.BtnArt.Text = "Artigos";
            this.BtnArt.TextColor = System.Drawing.Color.Black;
            this.BtnArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnArt.UseVisualStyleBackColor = false;
            this.BtnArt.Click += new System.EventHandler(this.BtnArt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.BtnDeslogar);
            this.Controls.Add(this.panelEstilizado1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelEstilizado1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ModeracaoBtn BtnMod;
        private ModeracaoBtn BtnArt;
        private classes.PanelEstilizado panelEstilizado1;
        private ModeracaoBtn BtnDeslogar;
    }
}

