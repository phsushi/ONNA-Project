﻿using prjDESK_ONNA.classes;
using System;
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
    public partial class Mod_moderacao : Form
    {
        private Intermediaria _obj;

        public Mod_moderacao(Intermediaria obj)
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu a =new Menu(_obj);
            a.Show();
            this.Close();
        }
    }
}
