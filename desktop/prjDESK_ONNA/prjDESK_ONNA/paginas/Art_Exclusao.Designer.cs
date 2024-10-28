namespace prjDESK_ONNA.paginas
{
    partial class Art_Exclusao
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
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEstilizado2 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.LblResumo = new System.Windows.Forms.RichTextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnExcluir = new prjDESK_ONNA.ModeracaoBtn();
            this.LblLink = new System.Windows.Forms.Label();
            this.panelEstilizado1 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.BtnVoltar = new prjDESK_ONNA.ModeracaoBtn();
            this.panelEstilizado3 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelEstilizado2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic);
            this.TxtPesquisa.Location = new System.Drawing.Point(119, 19);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(354, 33);
            this.TxtPesquisa.TabIndex = 1;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(479, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 513);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panelEstilizado2
            // 
            this.panelEstilizado2.BackColor = System.Drawing.Color.White;
            this.panelEstilizado2.BackgroudColor = System.Drawing.Color.White;
            this.panelEstilizado2.Controls.Add(this.LblResumo);
            this.panelEstilizado2.Controls.Add(this.LblTitulo);
            this.panelEstilizado2.Controls.Add(this.BtnExcluir);
            this.panelEstilizado2.Controls.Add(this.LblLink);
            this.panelEstilizado2.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado2.CurvaturaBorda = 40;
            this.panelEstilizado2.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado2.Location = new System.Drawing.Point(12, 58);
            this.panelEstilizado2.Name = "panelEstilizado2";
            this.panelEstilizado2.Size = new System.Drawing.Size(461, 419);
            this.panelEstilizado2.TabIndex = 18;
            this.panelEstilizado2.TamanhoBorda = 0;
            this.panelEstilizado2.TextColor = System.Drawing.Color.White;
            // 
            // LblResumo
            // 
            this.LblResumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResumo.ForeColor = System.Drawing.Color.Black;
            this.LblResumo.Location = new System.Drawing.Point(26, 61);
            this.LblResumo.Name = "LblResumo";
            this.LblResumo.ReadOnly = true;
            this.LblResumo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LblResumo.Size = new System.Drawing.Size(411, 254);
            this.LblResumo.TabIndex = 15;
            this.LblResumo.Text = "";
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(26, 14);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(411, 44);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnExcluir.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnExcluir.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnExcluir.CurvaturaBorda = 20;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.Location = new System.Drawing.Point(166, 366);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(115, 40);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.TamanhoBorda = 0;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextColor = System.Drawing.Color.Black;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblLink
            // 
            this.LblLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.ForeColor = System.Drawing.Color.Black;
            this.LblLink.Location = new System.Drawing.Point(26, 319);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(411, 35);
            this.LblLink.TabIndex = 14;
            this.LblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEstilizado1
            // 
            this.panelEstilizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.panelEstilizado1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.panelEstilizado1.BackgroundImage = global::prjDESK_ONNA.Properties.Resources.VERDADEIROARTIGO;
            this.panelEstilizado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEstilizado1.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado1.CurvaturaBorda = 39;
            this.panelEstilizado1.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado1.Location = new System.Drawing.Point(12, 10);
            this.panelEstilizado1.Name = "panelEstilizado1";
            this.panelEstilizado1.Size = new System.Drawing.Size(51, 42);
            this.panelEstilizado1.TabIndex = 17;
            this.panelEstilizado1.TamanhoBorda = 0;
            this.panelEstilizado1.TextColor = System.Drawing.Color.White;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnVoltar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.BtnVoltar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnVoltar.CurvaturaBorda = 20;
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(28, 483);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 40);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.TamanhoBorda = 0;
            this.BtnVoltar.Text = "voltar";
            this.BtnVoltar.TextColor = System.Drawing.Color.Black;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // panelEstilizado3
            // 
            this.panelEstilizado3.BackColor = System.Drawing.Color.White;
            this.panelEstilizado3.BackgroudColor = System.Drawing.Color.White;
            this.panelEstilizado3.BackgroundImage = global::prjDESK_ONNA.Properties.Resources.lupa;
            this.panelEstilizado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelEstilizado3.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado3.CurvaturaBorda = 32;
            this.panelEstilizado3.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado3.Location = new System.Drawing.Point(74, 17);
            this.panelEstilizado3.Name = "panelEstilizado3";
            this.panelEstilizado3.Size = new System.Drawing.Size(39, 35);
            this.panelEstilizado3.TabIndex = 20;
            this.panelEstilizado3.TamanhoBorda = 0;
            this.panelEstilizado3.TextColor = System.Drawing.Color.White;
            // 
            // Art_Exclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.panelEstilizado3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelEstilizado2);
            this.Controls.Add(this.panelEstilizado1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.TxtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Art_Exclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de Artigos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Art_Exclusao_Closed);
            this.Load += new System.EventHandler(this.Art_Exclusao_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelEstilizado2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPesquisa;
        private ModeracaoBtn BtnExcluir;
        private ModeracaoBtn BtnVoltar;
        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.Label LblTitulo;
        private classes.PanelEstilizado panelEstilizado1;
        private classes.PanelEstilizado panelEstilizado2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox LblResumo;
        private classes.PanelEstilizado panelEstilizado3;
    }
}