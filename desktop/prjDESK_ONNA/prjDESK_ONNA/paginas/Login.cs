using MySql.Data.MySqlClient;
using prjDESK_ONNA.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDESK_ONNA.paginas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {

            List<string> lista = new List<string>();


            string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
            MySqlConnection con = new MySqlConnection(conect);
            MySqlDataReader leitor;
            if (TxtUsuario.Text == "" || TxtSenha.Text == "")
            {
                MessageBox.Show("Usuário ou senha inválidos, tente novamente!", "Falha ao logar");
                return;
            }
            else
            {
                con.Open();
                MySqlCommand comando = new MySqlCommand("call login_Admin('" + TxtUsuario.Text + "','" + TxtSenha.Text + "')", con);
                try
                {

                    leitor = comando.ExecuteReader();
                    leitor.Read();
                    lista.Add(Convert.ToString(leitor["username"]));

                    Intermediaria obja = new Intermediaria();

                    if (leitor["idAdmin"] != DBNull.Value && int.TryParse(leitor["idAdmin"].ToString(), out int idValue))
                    {
                        obja.Id = Convert.ToInt32(leitor["idAdmin"]);                         
                    }
                   




                    if (leitor["username"].ToString() == TxtUsuario.Text && leitor["senha"].ToString() == TxtSenha.Text)
                    {
                        Menu car = new Menu(obja);
                        car.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos, tente novamente!", "Falha ao logar");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Usuário ou senha inválidos, tente novamente!", "Falha ao logar");
                }
                con.Close();

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
