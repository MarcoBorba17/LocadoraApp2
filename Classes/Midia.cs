using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraApp2.Classes
{
    internal class Midia
    {
        //Titulo
        //Gênero
        //Sinopse
        //Autor
        //Duração
        //Classificação Indicativa

        public int MidiaId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor {  get; set; }
        public string Sinopse { get; set; }
        public int Ano  { get; set; }
        public int Duracao { get; set; }
        public string ClassicacaoIndicativa { get; set; }

    }
}
