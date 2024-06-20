namespace Biblioteca
{
    public class AlugarLivro
    {
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;

        public string NomeLeitor { get; set; }
        public string TituloExemplar { get; set; }

        public AlugarLivro() { }

        public AlugarLivro(Leitor leitor, Exemplar exemplar)
        {
            NomeLeitor = leitor.Nome;
            TituloExemplar = exemplar.Titulo;
            leitores = new List<Leitor> { leitor };
            exemplares = new List<Exemplar> { exemplar };
        }

        public AlugarLivro(List<Leitor> leitores, List<Exemplar> exemplares)
        {
            this.leitores = leitores; 
            this.exemplares = exemplares;
            Random random = new Random();

            int leitorIndex = random.Next(leitores.Count);
            int exemplarIndex = random.Next(exemplares.Count);

            NomeLeitor = leitores[2 ].Nome;
            TituloExemplar = exemplares[exemplarIndex].Titulo;
        }
    }
}
