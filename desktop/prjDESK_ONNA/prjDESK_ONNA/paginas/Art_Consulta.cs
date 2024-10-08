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
            

            if (DtaConsulta.SelectedCells.Count > 0)
            {

                int selectedrowindex = DtaConsulta.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = DtaConsulta.Rows[selectedrowindex];

                _obj.IdArtigo = Convert.ToInt16(selectedRow.Cells["idArtigo"].Value);
                _obj.IdGenero = Convert.ToInt16(selectedRow.Cells["idGenero"].Value);
                _obj.Resumo = Convert.ToString(selectedRow.Cells["resumo"].Value);
                _obj.Titulo = Convert.ToString(selectedRow.Cells["titulo"].Value);
                _obj.Fonte = Convert.ToString(selectedRow.Cells["fonte"].Value);
                _obj.IdAdmin = Convert.ToInt16(selectedRow.Cells["idAdmin"].Value);
            }


            Art_Alterar a = new Art_Alterar(_obj);
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
            
            try
            {
                

            
                DtaConsulta.AutoGenerateColumns = true;             
                DtaConsulta.DataSource = GetData("Select * From tblArtigo");
                DtaConsulta.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                DtaConsulta.BorderStyle = BorderStyle.Fixed3D;
                DtaConsulta.EditMode = DataGridViewEditMode.EditOnEnter;


            }
            catch (Exception)
            {

            }
            

        }
        private static DataTable GetData(string sqlCommand)
        {
            string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
            MySqlConnection con = new MySqlConnection(conect);

            MySqlCommand command = new MySqlCommand(sqlCommand, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }


        private void TxtPesquisaCons_TextChanged(object sender, EventArgs e)
        {
            string conect = "server=localhost;database=ONNA;uid=root;pwd=U1de8JA87Rrb";
            MySqlConnection con = new MySqlConnection(conect);
            string query = "Select * from tblArtigo where titulo like '%" + TxtPesquisaCons.Text + "%'";
            MySqlCommand command = new MySqlCommand(query, con);         
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DtaConsulta.DataSource = dt;
        }

        private void panelEstilizado2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
