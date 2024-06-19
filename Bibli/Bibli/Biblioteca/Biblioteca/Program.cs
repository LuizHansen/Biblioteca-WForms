namespace Biblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Exemplar> exemplares = new List<Exemplar>();
            List<Leitor> leitores = new List<Leitor>();
            List<Funcionario> funcionarios = new List<Funcionario>();

          
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBiblioteca());
        }
    }
}