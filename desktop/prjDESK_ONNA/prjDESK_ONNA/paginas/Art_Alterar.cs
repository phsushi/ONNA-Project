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
    public partial class Art_Alterar : Form
    {
        private Intermediaria _obj;
        public Art_Alterar(Intermediaria obj)
        {
            InitializeComponent();
            _obj = obj;
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Art_Consulta art = new Art_Consulta(_obj);
            art.Show();
            this.Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                MySqlConnection con = new MySqlConnection(conect);
                string titulo = TxtTituloAlter.Text;
                string resumo = TxtResumoAlter.Text;
                string link = TxtLinkAlter.Text;
                int genero = 0;
                int idArtigo = _obj.IdArtigo;

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

                MySqlCommand comando = new MySqlCommand("call alterar_Artigo(" + idArtigo + ",'" + titulo + "','" + resumo + "','" + link + "'," + genero + ")", con);
                int val = comando.ExecuteNonQuery();
                con.Close();
                if (val == 1)
                {
                    MessageBox.Show("Alteração realizada com sucesso", "Sucesso");
                    Art_Consulta art = new Art_Consulta(_obj);
                    art.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A alteração não foi realizada com êxito", "Falha");
                }

            }catch(Exception op)
            {
                MessageBox.Show(op.ToString(),"Erro");
            }
        }

        private void Art_Alterar_Load(object sender, EventArgs e)
        {
            TxtTituloAlter.Text = _obj.Titulo;
            TxtResumoAlter.Text = _obj.Resumo;
            TxtLinkAlter.Text = _obj.Fonte;
            int idGenero = _obj.IdGenero;

            if(idGenero == 1)
            {
                RdoMens.Checked = true;

            }else if (idGenero == 2)
            {
                RdoEngra.Checked = true;

            }else if (idGenero == 3)
            {
                RdoGest.Checked = true;
            }else if (idGenero == 4)
            {
                RdoMater.Checked = true;
            }
            else
            {
                RdoCuidado.Checked = true;
            }
        }
    }
}
