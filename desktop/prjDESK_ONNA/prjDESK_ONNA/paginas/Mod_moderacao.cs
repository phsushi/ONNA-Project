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
        int id;
        int post;
        int resposta;
       
        public Mod_moderacao(Intermediaria obj)
        {
            InitializeComponent();
            CarregarDados();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu a =new Menu(_obj);
            a.Show();
            this.Close();
        }

        private void Mod_moderacao_Load(object sender, EventArgs e)
        {
            BtnVoltar.Focus();
            RdoAbuso.Checked = true;
        }
        private Panel CriarCard(MySqlDataReader reader)
        {
           

            string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";

            MySqlConnection con = new MySqlConnection(conect);
            MySqlDataReader denuncia;
            int idDenuncia;

            if (string.IsNullOrEmpty(reader["idPostagem"].ToString()))
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("call consulta_Detalhada_Denuncia_Resposta("+Convert.ToInt16(reader["idDenuncia"])+")", con);
                denuncia = command.ExecuteReader();
                idDenuncia = Convert.ToInt16(reader["idDenuncia"]);
                

            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("call consulta_Detalhada_Denuncia_Postagem(" + Convert.ToInt16(reader["idDenuncia"]) + ")", con);
                denuncia = command.ExecuteReader();
                 idDenuncia = Convert.ToInt16(reader["idDenuncia"]);
                
            }

           

            PanelEstilizado card = new PanelEstilizado
            {
                Size = new Size(410, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackgroudColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                CurvaturaBorda = 15
            };


            Label labelDenunciou = new Label
            {
                Text = reader["Quem denunciou"].ToString(),
                Font = new Font("Palatino Linotype", 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 15),
                Size = new Size(130, 25),
                BackColor = Color.Transparent
            };
            card.Controls.Add(labelDenunciou);


            Label labelDenunciada = new Label
            {
                Size = new Size(150, 25),
                Text = reader["Quem foi denunciado"].ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Palatino Linotype", 10),
                Location = new Point(220, 15),
                BackColor = Color.Transparent


            };
            card.Controls.Add(labelDenunciada);


            Label labelForum = new Label
            {
                Text = reader["Fórum"].ToString(),
                Location = new Point(10, 70),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(150 , 25),
                Font = new Font("Palatino Linotype", 10),
                
            };
            card.Controls.Add(labelForum);

            Label labelData = new Label
            {
                Text = reader["Data da Denúncia"].ToString(),
                Location = new Point(220, 70),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Palatino Linotype", 10),
                Size = new Size(150,25),
                
            };
            card.Controls.Add(labelData);

            ModeracaoBtn btnDetalhes = new ModeracaoBtn
            {
                Text = "Visualizar",
                Location = new Point(145, 100),
                Size = new Size(100, 30),
                BackColor = Color.FromArgb(38, 180, 225)
            };

            card.Controls.Add(btnDetalhes);

            btnDetalhes.Click += (sender, e) =>
            {
                try
                {


                    LblDenunciou.Text = labelDenunciou.Text;

                    LblDenunciada.Text = labelDenunciada.Text;



                    denuncia.Read();

                    LblObservacao.Text = denuncia["Descrição da denúncia"].ToString();

                    LblComentario.Text = denuncia["Mensagem denunciada"].ToString();

                    if (Convert.ToInt16(denuncia["idTipo_Denuncia"]) == 1)
                    {
                        RdoAbuso.Checked = true;

                    }
                    else if (Convert.ToInt16(denuncia["idTipo_Denuncia"]) == 2)
                    {
                        RdoDiscurso.Checked = true;

                    }
                    else if (Convert.ToInt16(denuncia["idTipo_Denuncia"]) == 3)
                    {
                        RdoNome.Checked = true;
                    }
                    else if (Convert.ToInt16(denuncia["idTipo_Denuncia"]) == 4)
                    {
                        RdoPost.Checked = true;
                    }
                    else
                    {
                        RdoSpam.Checked = true;
                    }
                    
                    id = idDenuncia;

                    string conects = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                    MySqlConnection cons = new MySqlConnection(conects);
                    cons.Open();
                    string querys = "Select * from tblDenuncia where idDenuncia = "+id+"";

                    MySqlCommand commands = new MySqlCommand(querys, cons);
                    MySqlDataReader readers = commands.ExecuteReader();
                    readers.Read();
                    if (string.IsNullOrEmpty(readers["idPostagem"].ToString()))
                    {
                        resposta = Convert.ToInt16(readers["idResposta_Postagem"]);
                    }
                    else
                    {
                        post = Convert.ToInt16(readers["idPostagem"]);
                    }
                    cons.Close();



                }
                catch(Exception ads)
                {
                    MessageBox.Show(ads.ToString() ,"Erro: ");

                }

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
                string query = "call consulta_Superficial_Denuncia()";

                MySqlCommand command = new MySqlCommand(query, con);

               


                MySqlDataReader reader = command.ExecuteReader();


                flowLayoutPanel1.Controls.Clear();


                while (reader.Read() )
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIgnorar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer ignorar esta denuncia?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                    MySqlConnection con = new MySqlConnection(conect);

                    con.Open();

                    string query = "call ignorar_Denuncia(" + id + ")";

                    MySqlCommand command = new MySqlCommand(query, con);

                    command.ExecuteNonQuery();

                    con.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString(), "Erro: ");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer Apagar este comentário?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (post == 0)
                    {
                        string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                        MySqlConnection con = new MySqlConnection(conect);

                        con.Open();

                        string query = "call apagar_Resposta(" + resposta + ")";

                        MySqlCommand command = new MySqlCommand(query, con);

                        command.ExecuteNonQuery();

                        con.Close();

                    }
                    else
                    {
                        string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                        MySqlConnection con = new MySqlConnection(conect);

                        con.Open();

                        string query = "call apagar_Postagem(" + post + ")";

                        MySqlCommand command = new MySqlCommand(query, con);

                        command.ExecuteNonQuery();

                        con.Close();
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString(), "Erro: ");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        
       
    }
}
