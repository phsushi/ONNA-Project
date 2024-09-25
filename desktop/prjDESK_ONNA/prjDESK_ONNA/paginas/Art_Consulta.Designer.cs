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
            this.components = new System.ComponentModel.Container();
            this.TxtPesquisaCons = new System.Windows.Forms.TextBox();
            this.DtaConsulta = new System.Windows.Forms.DataGridView();
            this.tblArtigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.BtnVoltar = new prjDESK_ONNA.ModeracaoBtn();
            this.panelEstilizado1 = new prjDESK_ONNA.classes.PanelEstilizado();
            
            this.idArtigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtigoBindingSource)).BeginInit();
            
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
            this.DtaConsulta.AllowUserToAddRows = false;
            this.DtaConsulta.AllowUserToDeleteRows = false;
            this.DtaConsulta.AutoGenerateColumns = false;
            this.DtaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.DtaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtigoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.resumoDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn});
            this.DtaConsulta.DataSource = this.tblArtigoBindingSource;
            this.DtaConsulta.Location = new System.Drawing.Point(39, 78);
            this.DtaConsulta.Name = "DtaConsulta";
            this.DtaConsulta.ReadOnly = true;
            this.DtaConsulta.Size = new System.Drawing.Size(710, 399);
            this.DtaConsulta.TabIndex = 3;
            this.DtaConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblArtigoBindingSource
            // 
            this.tblArtigoBindingSource.DataMember = "tblArtigo";
            
            // 
            // demonstracaoDataSet
            // 
           
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
            // panelEstilizado1
            // 
            this.panelEstilizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.panelEstilizado1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.panelEstilizado1.BackgroundImage = global::prjDESK_ONNA.Properties.Resources.VERDADEIROARTIGO;
            this.panelEstilizado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEstilizado1.CorBorda = System.Drawing.Color.PaleVioletRed;
            this.panelEstilizado1.CurvaturaBorda = 39;
            this.panelEstilizado1.ForeColor = System.Drawing.Color.White;
            this.panelEstilizado1.Location = new System.Drawing.Point(12, 12);
            this.panelEstilizado1.Name = "panelEstilizado1";
            this.panelEstilizado1.Size = new System.Drawing.Size(51, 42);
            this.panelEstilizado1.TabIndex = 18;
            this.panelEstilizado1.TamanhoBorda = 0;
            this.panelEstilizado1.TextColor = System.Drawing.Color.White;
            // 
            // tblArtigoTableAdapter
            // 
            
            // 
            // idArtigoDataGridViewTextBoxColumn
            // 
            this.idArtigoDataGridViewTextBoxColumn.DataPropertyName = "idArtigo";
            this.idArtigoDataGridViewTextBoxColumn.HeaderText = "idArtigo";
            this.idArtigoDataGridViewTextBoxColumn.Name = "idArtigoDataGridViewTextBoxColumn";
            this.idArtigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resumoDataGridViewTextBoxColumn
            // 
            this.resumoDataGridViewTextBoxColumn.DataPropertyName = "resumo";
            this.resumoDataGridViewTextBoxColumn.HeaderText = "resumo";
            this.resumoDataGridViewTextBoxColumn.Name = "resumoDataGridViewTextBoxColumn";
            this.resumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Art_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.panelEstilizado1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DtaConsulta);
            this.Controls.Add(this.TxtPesquisaCons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Art_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art_Consulta";
            this.Load += new System.EventHandler(this.Art_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtigoBindingSource)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPesquisaCons;
        private System.Windows.Forms.DataGridView DtaConsulta;
        private ModeracaoBtn BtnVoltar;
        private classes.PanelEstilizado panelEstilizado1;
        private System.Windows.Forms.BindingSource tblArtigoBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
    }
}