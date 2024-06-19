using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Ebook : Livro
    {
        public string? Formato { get; set; }
        public decimal Tamanho { get; set; }
        public string? Url { get; set; }
        public Ebook()
        {
        }
        public Ebook(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, string tipoCapa, string isbn, string formato, decimal tamanho, string url) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status, paginas, tipoCapa, isbn)
        {
            Formato = formato;
            Tamanho = tamanho;
            Url = url;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
