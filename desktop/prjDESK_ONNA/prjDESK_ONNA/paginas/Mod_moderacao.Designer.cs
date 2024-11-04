namespace prjDESK_ONNA.paginas
{
    partial class Mod_moderacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblObservacao = new System.Windows.Forms.RichTextBox();
            this.LblComentario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdoSpam = new System.Windows.Forms.RadioButton();
            this.RdoPost = new System.Windows.Forms.RadioButton();
            this.RdoNome = new System.Windows.Forms.RadioButton();
            this.RdoDiscurso = new System.Windows.Forms.RadioButton();
            this.RdoAbuso = new System.Windows.Forms.RadioButton();
            this.LblDenunciada = new System.Windows.Forms.Label();
            this.LblDenunciou = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEstilizado1 = new prjDESK_ONNA.classes.PanelEstilizado();
            this.BtnVoltar = new prjDESK_ONNA.ModeracaoBtn();
            this.BtnIgnorar = new prjDESK_ONNA.ModeracaoBtn();
            this.BtnApagar = new prjDESK_ONNA.ModeracaoBtn();
            this.BtnBanir = new prjDESK_ONNA.ModeracaoBtn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblObservacao);
            this.panel1.Controls.Add(this.LblComentario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LblDenunciada);
            this.panel1.Controls.Add(this.LblDenunciou);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 414);
            this.panel1.TabIndex = 11;
            // 
            // LblObservacao
            // 
            this.LblObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblObservacao.Location = new System.Drawing.Point(14, 283);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.ReadOnly = true;
            this.LblObservacao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LblObservacao.Size = new System.Drawing.Size(459, 115);
            this.LblObservacao.TabIndex = 21;
            this.LblObservacao.Text = "";
            // 
            // LblComentario
            // 
            this.LblComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblComentario.Location = new System.Drawing.Point(197, 65);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(275, 212);
            this.LblComentario.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.RdoSpam);
            this.panel2.Controls.Add(this.RdoPost);
            this.panel2.Controls.Add(this.RdoNome);
            this.panel2.Controls.Add(this.RdoDiscurso);
            this.panel2.Controls.Add(this.RdoAbuso);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(14, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 212);
            this.panel2.TabIndex = 2;
            // 
            // RdoSpam
            // 
            this.RdoSpam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoSpam.Location = new System.Drawing.Point(13, 175);
            this.RdoSpam.Name = "RdoSpam";
            this.RdoSpam.Size = new System.Drawing.Size(161, 30);
            this.RdoSpam.TabIndex = 4;
            this.RdoSpam.TabStop = true;
            this.RdoSpam.Text = "Spam de mensagens";
            this.RdoSpam.UseVisualStyleBackColor = true;
            // 
            // RdoPost
            // 
            this.RdoPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoPost.Location = new System.Drawing.Point(13, 133);
            this.RdoPost.Name = "RdoPost";
            this.RdoPost.Size = new System.Drawing.Size(161, 36);
            this.RdoPost.TabIndex = 3;
            this.RdoPost.TabStop = true;
            this.RdoPost.Text = "Postagem inadequada";
            this.RdoPost.UseVisualStyleBackColor = true;
            // 
            // RdoNome
            // 
            this.RdoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoNome.Location = new System.Drawing.Point(13, 90);
            this.RdoNome.Name = "RdoNome";
            this.RdoNome.Size = new System.Drawing.Size(161, 37);
            this.RdoNome.TabIndex = 2;
            this.RdoNome.TabStop = true;
            this.RdoNome.Text = "Nome ofensivo ou inadequado";
            this.RdoNome.UseVisualStyleBackColor = true;
            // 
            // RdoDiscurso
            // 
            this.RdoDiscurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoDiscurso.Location = new System.Drawing.Point(13, 46);
            this.RdoDiscurso.Name = "RdoDiscurso";
            this.RdoDiscurso.Size = new System.Drawing.Size(130, 30);
            this.RdoDiscurso.TabIndex = 1;
            this.RdoDiscurso.TabStop = true;
            this.RdoDiscurso.Text = "Discurso de ódio";
            this.RdoDiscurso.UseVisualStyleBackColor = true;
            // 
            // RdoAbuso
            // 
            this.RdoAbuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoAbuso.Location = new System.Drawing.Point(13, 3);
            this.RdoAbuso.Name = "RdoAbuso";
            this.RdoAbuso.Size = new System.Drawing.Size(112, 37);
            this.RdoAbuso.TabIndex = 0;
            this.RdoAbuso.TabStop = true;
            this.RdoAbuso.Text = "Abuso Verbal";
            this.RdoAbuso.UseVisualStyleBackColor = true;
            // 
            // LblDenunciada
            // 
            this.LblDenunciada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblDenunciada.Location = new System.Drawing.Point(290, 16);
            this.LblDenunciada.Name = "LblDenunciada";
            this.LblDenunciada.Size = new System.Drawing.Size(180, 36);
            this.LblDenunciada.TabIndex = 1;
            this.LblDenunciada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDenunciou
            // 
            this.LblDenunciou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LblDenunciou.Location = new System.Drawing.Point(11, 16);
            this.LblDenunciou.Name = "LblDenunciou";
            this.LblDenunciou.Size = new System.Drawing.Size(180, 36);
            this.LblDenunciou.TabIndex = 0;
            this.LblDenunciou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 56);
            this.label2.TabIndex = 17;
            this.label2.Text = "Moderação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(515, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 563);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panelEstilizado1
            // 
            this.panelEstilizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelEstilizado1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelEstilizado1.BackgroundImage = global::prjDESK_ONNA.Properties.Resources.balanca1;
            this.panelEstilizado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEstilizado1.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado1.CurvaturaBorda = 39;
            this.panelEstilizado1.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado1.Location = new System.Drawing.Point(12, 12);
            this.panelEstilizado1.Name = "panelEstilizado1";
            this.panelEstilizado1.Size = new System.Drawing.Size(46, 41);
            this.panelEstilizado1.TabIndex = 16;
            this.panelEstilizado1.TamanhoBorda = 0;
            this.panelEstilizado1.TextColor = System.Drawing.Color.White;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnVoltar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnVoltar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnVoltar.CurvaturaBorda = 20;
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 535);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 40);
            this.BtnVoltar.TabIndex = 15;
            this.BtnVoltar.TamanhoBorda = 0;
            this.BtnVoltar.Text = "voltar";
            this.BtnVoltar.TextColor = System.Drawing.Color.Black;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnIgnorar
            // 
            this.BtnIgnorar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnIgnorar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnIgnorar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnIgnorar.CurvaturaBorda = 20;
            this.BtnIgnorar.FlatAppearance.BorderSize = 0;
            this.BtnIgnorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIgnorar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnIgnorar.ForeColor = System.Drawing.Color.Black;
            this.BtnIgnorar.Location = new System.Drawing.Point(361, 488);
            this.BtnIgnorar.Name = "BtnIgnorar";
            this.BtnIgnorar.Size = new System.Drawing.Size(148, 40);
            this.BtnIgnorar.TabIndex = 14;
            this.BtnIgnorar.TamanhoBorda = 0;
            this.BtnIgnorar.Text = "ignorar";
            this.BtnIgnorar.TextColor = System.Drawing.Color.Black;
            this.BtnIgnorar.UseVisualStyleBackColor = false;
            this.BtnIgnorar.Click += new System.EventHandler(this.BtnIgnorar_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnApagar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnApagar.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnApagar.CurvaturaBorda = 20;
            this.BtnApagar.FlatAppearance.BorderSize = 0;
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApagar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.ForeColor = System.Drawing.Color.Black;
            this.BtnApagar.Location = new System.Drawing.Point(189, 489);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(148, 40);
            this.BtnApagar.TabIndex = 13;
            this.BtnApagar.TamanhoBorda = 0;
            this.BtnApagar.Text = "apagar ";
            this.BtnApagar.TextColor = System.Drawing.Color.Black;
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnBanir
            // 
            this.BtnBanir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnBanir.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnBanir.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.BtnBanir.CurvaturaBorda = 20;
            this.BtnBanir.FlatAppearance.BorderSize = 0;
            this.BtnBanir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBanir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.BtnBanir.ForeColor = System.Drawing.Color.Black;
            this.BtnBanir.Location = new System.Drawing.Point(12, 489);
            this.BtnBanir.Name = "BtnBanir";
            this.BtnBanir.Size = new System.Drawing.Size(148, 40);
            this.BtnBanir.TabIndex = 12;
            this.BtnBanir.TamanhoBorda = 0;
            this.BtnBanir.Text = "banir";
            this.BtnBanir.TextColor = System.Drawing.Color.Black;
            this.BtnBanir.UseVisualStyleBackColor = false;
            this.BtnBanir.Click += new System.EventHandler(this.BtnBanir_Click);
            // 
            // Mod_moderacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(957, 587);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelEstilizado1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnIgnorar);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnBanir);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Mod_moderacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod_moderacao";
            this.Load += new System.EventHandler(this.Mod_moderacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ModeracaoBtn BtnBanir;
        private ModeracaoBtn BtnApagar;
        private ModeracaoBtn BtnIgnorar;
        private ModeracaoBtn BtnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblDenunciada;
        private System.Windows.Forms.Label LblDenunciou;
        private System.Windows.Forms.Label LblComentario;
        private classes.PanelEstilizado panelEstilizado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox LblObservacao;
        private System.Windows.Forms.RadioButton RdoSpam;
        private System.Windows.Forms.RadioButton RdoPost;
        private System.Windows.Forms.RadioButton RdoNome;
        private System.Windows.Forms.RadioButton RdoDiscurso;
        private System.Windows.Forms.RadioButton RdoAbuso;
    }
}