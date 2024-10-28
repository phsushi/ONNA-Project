using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDESK_ONNA.classes
{
    class Artigos
    {
        public int IdArtigo { get => idArtigo; set => idArtigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Resumo { get => resumo; set => resumo = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }

        private int idArtigo;
        private string titulo;
        private string resumo;
        private int idGenero;
    }
}
