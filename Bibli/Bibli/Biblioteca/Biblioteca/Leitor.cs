using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface ILeitor
    {
        bool EmprestaItem(Exemplar exemplar, Leitor leitorDestino);
        bool DevolveItem(Exemplar exemplar, Leitor leitorDestino);
        bool DoaExemplar(Exemplar exemplar, Leitor leitorDestino);
        bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem);
    }

    public class Leitor : Pessoa, ILeitor
    {
        public List<Exemplar> ExemplaresLeitor { get; set; }
        public List<Emprestimo> EmprestimosLeitor { get; set; }
        public string Tipo { get; set; }

        public Leitor()
        {
            ExemplaresLeitor = new List<Exemplar>();
            EmprestimosLeitor = new List<Emprestimo>();
        }

        public Leitor(string nome, DateTime nascimento, string cpf, string email, string telefone, string tipo)
            : base(nome, nascimento, cpf, email, telefone)
        {
            ExemplaresLeitor = new List<Exemplar>();
            EmprestimosLeitor = new List<Emprestimo>();
            Tipo = tipo;
        }

        public bool EmprestaItem(Exemplar exemplar, Leitor leitorDestino)
        {
            if (ExemplaresLeitor.Contains(exemplar))
            {
                ExemplaresLeitor.Remove(exemplar);
                leitorDestino.ExemplaresLeitor.Add(exemplar);
                return true;
            }
            return false;
        }

        public bool DevolveItem(Exemplar exemplar, Leitor leitorDestino)
        {
            if (leitorDestino.ExemplaresLeitor.Contains(exemplar))
            {
                leitorDestino.ExemplaresLeitor.Remove(exemplar);
                ExemplaresLeitor.Add(exemplar);
                return true;
            }
            return false;
        }

        public bool DoaExemplar(Exemplar exemplar, Leitor leitorDestino)
        {
            if (ExemplaresLeitor.Contains(exemplar))
            {
                ExemplaresLeitor.Remove(exemplar);
                leitorDestino.ExemplaresLeitor.Add(exemplar);
                return true;
            }
            return false;
        }

        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem)
        {
            if (ExemplaresLeitor.Contains(exemplarVai) && leitorVai.ExemplaresLeitor.Contains(exemplarVem))
            {
                ExemplaresLeitor.Remove(exemplarVai);
                ExemplaresLeitor.Add(exemplarVem);
                leitorVai.ExemplaresLeitor.Remove(exemplarVem);
                leitorVai.ExemplaresLeitor.Add(exemplarVai);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Nome} ({Tipo})";
        }

        public override void ListaLeitor(Leitor leitor)
        {
            Console.WriteLine(leitor.ToString());
            foreach (var exemplar in leitor.ExemplaresLeitor)
            {
                Console.WriteLine($"- {exemplar.Titulo}");
            }
        }

        public override void EditaLeitor(Leitor leitor)
        {
            // Implement the logic to edit the leitor details.
        }

        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            leitor.ExemplaresLeitor.Add(exemplar);
        }

        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            leitor.ExemplaresLeitor.Remove(exemplar);
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            // Implement the logic to edit the exemplar details for the leitor.
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            foreach (var ex in leitor.ExemplaresLeitor)
            {
                if (ex.Equals(exemplar))
                {
                    Console.WriteLine($"{exemplar.Titulo} - {exemplar.SubTitulo}");
                }
            }
        }
    }
}
