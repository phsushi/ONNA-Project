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
    public partial class Art_Insert : Form
    {
        public Art_Insert()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Art_Gerenc art = new Art_Gerenc();
            art.Show();
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
