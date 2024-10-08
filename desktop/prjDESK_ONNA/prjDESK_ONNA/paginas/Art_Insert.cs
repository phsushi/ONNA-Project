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
            try
            {
                string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                MySqlConnection con = new MySqlConnection(conect);
                if (!string.IsNullOrWhiteSpace(TxtTitulo.Text) && !string.IsNullOrWhiteSpace(TxtResumo.Text) && !string.IsNullOrWhiteSpace(TxtLink.Text))
                {


                    string titulo = TxtTitulo.Text;
                    string resumo = TxtResumo.Text;
                    string link = TxtLink.Text;
                    int genero = 0;
                    int admin = _obj.Id;

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


                    MySqlCommand comando = new MySqlCommand("call criar_Artigo('" + TxtTitulo.Text + "','" + TxtResumo.Text + "','" + TxtLink.Text + "'," + admin + "," + genero + ")", con);
                    int val = comando.ExecuteNonQuery();
                    if (val == 1)
                    {
                        MessageBox.Show("Artigo inserido com sucesso!", "Sucesso");
                        Art_Gerenc art = new Art_Gerenc(_obj);
                        art.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("O artigo não foi inserido com êxito", "Falha");
                    }
                    con.Close();
                   

                }
                else
                {
                    MessageBox.Show("Não é possível inserir dados inexistentes, tente novamente!","Campos vazios");
                }
            }
            catch (Exception eA)
            {
                MessageBox.Show(eA.ToString(),"Erro");
            }
            
        }

        private void Art_Insert_Load(object sender, EventArgs e)
        {
            RdoMens.Checked = true;
        }
    }
}
