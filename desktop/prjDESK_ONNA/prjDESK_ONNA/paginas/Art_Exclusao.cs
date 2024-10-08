using MySql.Data.MySqlClient;
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int idArtigo = Convert.ToInt16(TxtPesquisa.Text);
            try
            {
                string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                MySqlConnection con = new MySqlConnection(conect);
                con.Open();
                MySqlCommand comando = new MySqlCommand("call excluir_Artigo("+idArtigo+")", con);
                int val = comando.ExecuteNonQuery();
                if (val == 1)
                {
                    MessageBox.Show("Artigo excluido com sucesso!", "Sucesso");
                    Art_Gerenc art = new Art_Gerenc(_obj);
                    art.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("O artigo não foi excluido com êxito", "Falha");
                }
                con.Close();



            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString(),"Erro");
            }
        }
    }
}
