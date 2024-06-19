using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Generico : Exemplar
    {
        public int Tipo { get; set; }
        public Generico()
        {
        }
        public Generico(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int tipo) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Tipo = tipo;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
