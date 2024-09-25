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
    public partial class Art_Insert : Form
    {
        private Intermediaria _obj;
        public Art_Insert(Intermediaria obj)
        {
            InitializeComponent();
            _obj = obj;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Art_Gerenc art = new Art_Gerenc(_obj);
            art.Show();
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
            MySqlConnection con = new MySqlConnection(conect);
            string titulo = TxtTitulo.Text;
            string resumo = TxtResumo.Text;
            string link = TxtLink.Text;
            int genero = 0;

            

             int uo = _obj.Id;

            TxtLink.Text = uo.ToString();

            if (RdoMens.Checked)
            {
                genero = 1;
            }
            else if (RdoEngra.Checked)
            {
                genero = 2;
            }
            else if (RdoGest.Checked)
            {
                genero = 3;
            }
            else if (RdoMater.Checked)
            {
                genero = 4;
            }
            else
            {
                genero = 5;
            }
            con.Open();


            //MySqlCommand comando = new MySqlCommand("call criar_Artigo('" + TxtTitulo.Text + "','" + TxtResumo.Text + "','" + TxtLink.Text + "'," + 1 + "," + genero + ")", con);
            //comando.ExecuteNonQuery();
            con.Close();
        }

        private void Art_Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
