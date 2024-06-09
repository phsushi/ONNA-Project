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
    public partial class Art_Gerenc : Form
    {
        public Art_Gerenc()
        {
            InitializeComponent();
          
        }

        private void Art_Gerenc_Load(object sender, EventArgs e)
        {

        }

        private void Art_Gerenc_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

    
        private void BtnJanelaAlter_Click(object sender, EventArgs e)
        {
            Art_Consulta c = new Art_Consulta();
            c.Show();
            this.Close();
        }

        private void BtnJanelaExcluir_Click(object sender, EventArgs e)
        {
            Art_Exclusao c = new Art_Exclusao();
            c.Show();
            this.Close();
        }

        private void BtnInsercao_Click(object sender, EventArgs e)
        {
            Art_Insert a = new Art_Insert();
            a.Show();
            this.Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Close();
        }
    }
}
