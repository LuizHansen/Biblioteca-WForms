using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IFuncionario
    {
        void NovoLeitor(Leitor leitor);
        void ExcluiLeitor(Leitor leitor);
        void NovoFuncionario(Funcionario funcionario);
        void EditaFuncionario(Funcionario funcionario);
        void ExcluiFuncionario(Funcionario funcionario);
        void ListaFuncionario(Funcionario funcionario);
        void NovoExemplar(Exemplar exemplar);
        void EditaExemplar(Exemplar exemplar);
        void ExcluiExemplar(Exemplar exemplar);
        void ListaExemplar(Exemplar exemplar);
    }
    public class Funcionario : Pessoa, IFuncionario
    {
        public int Cargo { get; set; }
        public decimal Salario { get; set; }
        public int CargaHoraria { get; set; }
        public string? Funcao { get; set; }
        public Funcionario() 
        {
        }
        public Funcionario(string nome, DateTime nascimento, string cpf, string email, string telefone, int cargo, decimal salario, int cargaHoraria, string funcao) : base(nome, nascimento, cpf, email, telefone)
        { 
            Cargo = cargo;
            Salario = salario;
            CargaHoraria = cargaHoraria;
            Funcao = funcao;
        }
        public void NovoLeitor(Leitor leitor) { }
        public void ExcluiLeitor(Leitor leitor) { }
        public void NovoFuncionario(Funcionario funcionario) { }
        public void EditaFuncionario(Funcionario funcionario) { }
        public void ExcluiFuncionario(Funcionario funcionario) { }
        public void ListaFuncionario(Funcionario funcionario) { }
        public void NovoExemplar(Exemplar exemplar) { }
        public void EditaExemplar(Exemplar exemplar) { }
        public void ExcluiExemplar(Exemplar exemplar) { }
        public void ListaExemplar(Exemplar exemplar) { }

        public override string ToString()
        {
            return "";
        }

        public override void ListaLeitor(Leitor leitor) { }
        public override void EditaLeitor(Leitor leitor) { }
        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    }
}
