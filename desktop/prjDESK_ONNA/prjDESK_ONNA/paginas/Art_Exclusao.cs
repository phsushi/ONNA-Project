using MySql.Data.MySqlClient;
using prjDESK_ONNA.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        int idArtigo;
        public Art_Exclusao(Intermediaria obj)
        {
            InitializeComponent();
            _obj = obj;
           
            CarregarDados();
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

        private void DtaConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void Art_Exclusao_Load(object sender, EventArgs e) 
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

            }else if(reader["idGenero"].ToString() == "2")
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
                Size = new Size(255,25)
            };
            card.Controls.Add(labelTitulo);
          

            Label labelResumo = new Label
            {
                Size = new Size(230, 50),
                Text =  reader["resumo"].ToString(),
                Font = new Font("Palatino Linotype", 7),
                Location = new Point(10, 50),
                AutoSize = false,
                
            };
            card.Controls.Add(labelResumo);

            
            Label labelGenero = new Label
            {
                Text =  genero,
                Location = new Point(10, 30),
                Font = new Font("Palatino Linotype", 10),
                AutoSize = true,
                Margin = new Padding(20)
            };
            card.Controls.Add(labelGenero);

            ModeracaoBtn btnDetalhes = new ModeracaoBtn
            {
                Text = "Selecionar",
                Location = new Point(80, 100),
                Size = new Size(100, 30),
                BackColor = Color.FromArgb(38, 180, 225)
            };
            card.Controls.Add(btnDetalhes);

            btnDetalhes.Click += (sender, e) =>
            {
                LblTitulo.Text = labelTitulo.Text;
                LblResumo.Text = labelResumo.Text;
                LblLink.Text = link;
                idArtigo = iidd;

            };


            return card;
        }
        private void CarregarDados(string filtro = "")
        {
            try
            {
                string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
                MySqlConnection con = new MySqlConnection(conect);

                
                con.Open();

                
                string query = "SELECT * FROM tblArtigo";


                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE titulo LIKE @filtro";
                }

                
                MySqlCommand command = new MySqlCommand(query, con);

                if (!string.IsNullOrEmpty(filtro))
                {
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                
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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDados(TxtPesquisa.Text);
        }
    }

   
}
