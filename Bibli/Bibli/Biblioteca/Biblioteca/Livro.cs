using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : Exemplar
    {
        public int Paginas { get; set; }
        public string? TipoCapa { get; set; }
        public string? Isbn { get; set; }
        public Livro() 
        {
        }
        public Livro(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, string tipoCapa, string isbn) :base(titulo,subtitulo,escritor,editora,anoPublicacao,genero,status) 
        {
            Paginas = paginas;
            TipoCapa = tipoCapa;
            Isbn = isbn;
        }
        public override string ToString()
        {
            return "";
        }
    }

}
