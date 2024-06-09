namespace prjDESK_ONNA.paginas
{
    partial class Art_Consulta
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
            this.TxtPesquisaCons = new System.Windows.Forms.TextBox();
            this.DtaConsulta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVoltar = new prjDESK_ONNA.ModeracaoBtn();
            this.moderacaoBtn5 = new prjDESK_ONNA.ModeracaoBtn();
            ((System.ComponentModel.ISupportInitialize)(this.DtaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPesquisaCons
            // 
            this.TxtPesquisaCons.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic);
            this.TxtPesquisaCons.Location = new System.Drawing.Point(148, 19);
            this.TxtPesquisaCons.Name = "TxtPesquisaCons";
            this.TxtPesquisaCons.Size = new System.Drawing.Size(485, 33);
            this.TxtPesquisaCons.TabIndex = 2;
            // 
            // DtaConsulta
            // 
            this.DtaConsulta.AllowUserToOrderColumns = true;
            this.DtaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.DtaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.resumo,
            this.link,
            this.genero});
            this.DtaConsulta.Location = new System.Drawing.Point(39, 78);
            this.DtaConsulta.Name = "DtaConsulta";
            this.DtaConsulta.Size = new System.Drawing.Size(710, 399);
            this.DtaConsulta.TabIndex = 3;
            this.DtaConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // resumo
            // 
            this.resumo.HeaderText = "resumo";
            this.resumo.Name = "resumo";
            this.resumo.ReadOnly = true;
            // 
            // link
            // 
            this.link.HeaderText = "link";
            this.link.Name = "link";
            this.link.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.HeaderText = "genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
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
            this.BtnVoltar.Location = new System.Drawing.Point(39, 483);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(115, 40);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.TamanhoBorda = 0;
            this.BtnVoltar.Text = "voltar";
            this.BtnVoltar.TextColor = System.Drawing.Color.Black;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // moderacaoBtn5
            // 
            this.moderacaoBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.moderacaoBtn5.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.moderacaoBtn5.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.moderacaoBtn5.CurvaturaBorda = 40;
            this.moderacaoBtn5.Enabled = false;
            this.moderacaoBtn5.FlatAppearance.BorderSize = 0;
            this.moderacaoBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moderacaoBtn5.ForeColor = System.Drawing.Color.White;
            this.moderacaoBtn5.Location = new System.Drawing.Point(12, 12);
            this.moderacaoBtn5.Name = "moderacaoBtn5";
            this.moderacaoBtn5.Size = new System.Drawing.Size(50, 50);
            this.moderacaoBtn5.TabIndex = 10;
            this.moderacaoBtn5.TamanhoBorda = 0;
            this.moderacaoBtn5.TextColor = System.Drawing.Color.White;
            this.moderacaoBtn5.UseVisualStyleBackColor = false;
            // 
            // Art_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.moderacaoBtn5);
            this.Controls.Add(this.DtaConsulta);
            this.Controls.Add(this.TxtPesquisaCons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Art_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art_Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.DtaConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPesquisaCons;
        private System.Windows.Forms.DataGridView DtaConsulta;
        private ModeracaoBtn moderacaoBtn5;
        private ModeracaoBtn BtnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}