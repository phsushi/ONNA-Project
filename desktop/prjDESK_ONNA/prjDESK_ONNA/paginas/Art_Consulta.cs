﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDESK_ONNA.paginas
{
    public partial class Art_Consulta : Form
    {
        public Art_Consulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Art_Alterar a= new Art_Alterar();
            a.Show();
            this.Close();
        }

     

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Art_Gerenc a = new Art_Gerenc();
            a.Show();
            this.Close();
        }

        private void Art_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'demonstracaoDataSet.tblArtigo'. Você pode movê-la ou removê-la conforme necessário.
            try
            {
                this.tblArtigoTableAdapter.Fill(this.demonstracaoDataSet.tblArtigo);
            }
            catch (Exception)
            {

            }
            

        }
    }
}
