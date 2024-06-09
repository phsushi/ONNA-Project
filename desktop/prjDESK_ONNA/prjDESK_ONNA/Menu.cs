using prjDESK_ONNA.paginas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDESK_ONNA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }         

        private void BtnMod_Click(object sender, EventArgs e)
        {
            Mod_moderacao a = new Mod_moderacao();
            a.Show();
            this.Hide();
        }

        private void BtnArt_Click(object sender, EventArgs e)
        {
            Art_Gerenc c = new Art_Gerenc();
            c.Show();
            this.Hide();
        }
    }
}
