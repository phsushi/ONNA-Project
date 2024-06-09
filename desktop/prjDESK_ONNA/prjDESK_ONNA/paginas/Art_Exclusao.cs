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
    public partial class Art_Exclusao : Form
    {
        public Art_Exclusao()
        {
            InitializeComponent();
        }

        private void moderacaoBtn3_Click(object sender, EventArgs e)
        {
            Art_Gerenc a=new Art_Gerenc();
            a.Show();
            this.Close();
        }

        private void Art_Exclusao_Closed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
