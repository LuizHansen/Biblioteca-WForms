namespace Biblioteca
{
    public class AlugarLivro
    {
        public List<Tuple<Leitor, Exemplar>> LivroLeitorPairs { get; private set; } = new List<Tuple<Leitor, Exemplar>>();

        public AlugarLivro() { }

        public AlugarLivro(Leitor leitor, Exemplar exemplar)
        {
            AddPair(leitor, exemplar);
        }

        public AlugarLivro(Leitor leitor, List<Exemplar> exemplares)
        {
            foreach (var exemplar in exemplares)
            {
                AddPair(leitor, exemplar);
            }
        }

        public AlugarLivro(List<Leitor> leitores, List<Exemplar> exemplares)
        {
            int count = Math.Min(leitores.Count, exemplares.Count);
            for (int i = 0; i < count; i++)
            {
                AddPair(leitores[i], exemplares[i]);
            }
        }

        private void AddPair(Leitor leitor, Exemplar exemplar)
        {
            var pair = Tuple.Create(leitor, exemplar);
            if (!LivroLeitorPairs.Any(p => p.Item1 == leitor && p.Item2 == exemplar))
            {
                LivroLeitorPairs.Add(pair);
            }
        }
    }
}
