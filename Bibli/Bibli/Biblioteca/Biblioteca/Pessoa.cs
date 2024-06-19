using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IPessoa
    {
        void ListaLeitor(Leitor leitor);
        void EditaLeitor(Leitor leitor);
        void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor);
        void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    }
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public Pessoa() 
        {
        }
        public Pessoa(string nome, DateTime nascimento, string cpf, string email, string telefone)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }

        public abstract void ListaLeitor(Leitor leitor);
        public abstract void EditaLeitor(Leitor leitor);
        public abstract void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    }
}
