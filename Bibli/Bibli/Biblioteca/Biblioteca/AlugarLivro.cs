namespace Biblioteca
{
    public class AlugarLivro
    {
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;
        public List<String> leitoresNomes = new List<String>();
        public List<String> exemplaresNomes = new List<String>();
        public AlugarLivro() { }

        public AlugarLivro(Leitor leitor, Exemplar exemplar)
        {
            leitores = new List<Leitor> { leitor };
            exemplares = new List<Exemplar> { exemplar };
        }

        public AlugarLivro(List<Leitor> leitores, List<Exemplar> exemplares)
        {
            this.leitores = leitores;
            this.exemplares = exemplares;
            definirLeitoresExemplares();
            
            
            
        }

        public void definirLeitoresExemplares()
        {
            foreach (var leitor in this.leitores)
            {
                this.leitoresNomes.Add(leitor.Nome);
            }

            foreach (var exemplar in this.exemplares)
            {
                this.exemplaresNomes.Add(exemplar.Titulo);

            }
        }
    }
}
