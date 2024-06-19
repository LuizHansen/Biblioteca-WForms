using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : Exemplar
    {
        public int Edicao { get; set; }
        public int Paginas { get; set; }
        public Revista()
        {
        }
        public Revista(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int edicao, int paginas) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Edicao = edicao;
            Paginas = paginas;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
