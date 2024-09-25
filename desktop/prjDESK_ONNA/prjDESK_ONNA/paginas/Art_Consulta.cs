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
    public partial class Art_Consulta : Form
    {
        private Intermediaria _obj;
        public Art_Consulta(Intermediaria obj)
        {
            InitializeComponent();
            _obj = obj;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Art_Alterar a= new Art_Alterar(_obj);
            a.Show();
            this.Close();
        }

     

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Art_Gerenc a = new Art_Gerenc(_obj);
            a.Show();
            this.Close();
        }

        private void Art_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'demonstracaoDataSet.tblArtigo'. Você pode movê-la ou removê-la conforme necessário.
            try
            {
                
            }
            catch (Exception)
            {

            }
            

        }
    }
}
