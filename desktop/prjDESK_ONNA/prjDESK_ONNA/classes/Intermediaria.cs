using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDESK_ONNA.classes
{
    public class Intermediaria
    {
        public int Id { get; set; } = 0;

        //Artigo

        public int IdArtigo { get => idArtigo; set => idArtigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Resumo { get => resumo; set => resumo = value; }
        public string Fonte { get => fonte; set => fonte = value; }
        public int IdAdmin { get => idAdmin; set => idAdmin = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }

        private int idArtigo;
        private string titulo;
        private string resumo;
        private string fonte;
        private int idAdmin;
        private int idGenero;
    }
}
