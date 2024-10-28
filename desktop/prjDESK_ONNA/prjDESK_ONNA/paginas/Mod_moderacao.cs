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
    public partial class Mod_moderacao : Form
    {
        private Intermediaria _obj;

        public Mod_moderacao(Intermediaria obj)
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu a =new Menu(_obj);
            a.Show();
            this.Close();
        }

        private void Mod_moderacao_Load(object sender, EventArgs e)
        {

        }
        private Panel CriarCard(MySqlDataReader reader)
        {
            string genero = "";

            int iidd = Convert.ToInt32(reader["idArtigo"]);

            string link = reader["fonte"].ToString();

            if (reader["idGenero"].ToString() == "1")
            {
                genero = "Menstruação";

            }
            else if (reader["idGenero"].ToString() == "2")
            {
                genero = "Engravidar";
            }
            else if (reader["idGenero"].ToString() == "3")
            {
                genero = "Gestação";
            }
            else if (reader["idGenero"].ToString() == "4")
            {
                genero = "Maternidade";
            }
            else
            {
                genero = "Cuidados com o corpo";
            }


            PanelEstilizado card = new PanelEstilizado
            {
                Size = new Size(265, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackgroudColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                CurvaturaBorda = 15


            };


            Label labelTitulo = new Label
            {
                Text = reader["titulo"].ToString(),
                Font = new Font("Palatino Linotype", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(5, 5),
                Size = new Size(255, 25)
            };
            card.Controls.Add(labelTitulo);


            Label labelResumo = new Label
            {
                Size = new Size(230, 50),
                Text = reader["resumo"].ToString(),
                Font = new Font("Palatino Linotype", 7),
                Location = new Point(10, 50),
                AutoSize = false,

            };
            card.Controls.Add(labelResumo);


            Label labelGenero = new Label
            {
                Text = genero,
                Location = new Point(10, 30),
                Font = new Font("Palatino Linotype", 10),
                AutoSize = true,
                Margin = new Padding(20)
            };
            card.Controls.Add(labelGenero);

            ModeracaoBtn btnDetalhes = new ModeracaoBtn
            {
                Text = "Visualizar",
                Location = new Point(80, 100),
                Size = new Size(100, 30),
                BackColor = Color.FromArgb(38, 180, 225)
            };
            card.Controls.Add(btnDetalhes);

            btnDetalhes.Click += (sender, e) =>
            {
                //LblTitulo.Text = labelTitulo.Text;
                //LblResumo.Text = labelResumo.Text;
                //LblLink.Text = link;
                //idArtigo = iidd;

            };


            return card;
        }
        private void CarregarDados()
        {
            try
            {
                string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                MySqlConnection con = new MySqlConnection(conect);
                con.Open();
                string query = "call consulta_Superficial_Denuncia";

                MySqlCommand command = new MySqlCommand(query, con);

               


                MySqlDataReader reader = command.ExecuteReader();


                flowLayoutPanel1.Controls.Clear();


                while (reader.Read())
                {

                    Panel card = CriarCard(reader);
                    flowLayoutPanel1.Controls.Add(card);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }




        }
    }
}
