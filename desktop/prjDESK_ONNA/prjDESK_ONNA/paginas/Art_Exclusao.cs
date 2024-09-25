using prjDESK_ONNA.classes;
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
        private Intermediaria _obj;

        public Art_Exclusao(Intermediaria obj)
        {
            InitializeComponent();
            _obj = obj;
        }

      

        private void Art_Exclusao_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Art_Gerenc a = new Art_Gerenc(_obj);
            a.Show();
            this.Close();
        }
    }
}
