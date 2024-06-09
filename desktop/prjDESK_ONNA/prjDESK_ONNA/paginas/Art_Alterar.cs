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
    public partial class Art_Alterar : Form
    {
        public Art_Alterar()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Art_Consulta art = new Art_Consulta();
            art.Show();
            this.Close();
        }
    }
}
