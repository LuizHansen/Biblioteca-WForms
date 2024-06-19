using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Hq : Exemplar
    {
        public int Edicao { get; set; }
        public string? Ilustrador { get; set; }
        public Hq()
        {
        }
        public Hq(string titulo, string subtitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int edicao, string ilustrador) : base(titulo, subtitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Edicao = edicao;
            Ilustrador = ilustrador;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
