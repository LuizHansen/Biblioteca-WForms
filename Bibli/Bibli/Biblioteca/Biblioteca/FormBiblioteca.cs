namespace Biblioteca
{
    public partial class FormBiblioteca : Form
    {
        //luiz hansen, Yuri Martinelli, Tarcisio�Correa
        public List<Funcionario> funcionarios;
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;
        public List<AlugarLivro> livroLeitor;

        public FormBiblioteca()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplares = new List<Exemplar>();
            livroLeitor = new List<AlugarLivro>();

            CargaInicial();
            AtualizarDataGridView();
        }
        private void CargaInicial()
        {
            leitores.Add(new Leitor("Luiz", DateTime.Today, "111.111.111-22", "luiz@gmail.com", "49 99132-8979", "Leitor de Fic��o"));
            leitores.Add(new Leitor("Henrique", DateTime.Today, "111.111.111-23", "henrique@gmail.com", "49 99987-5431", "Leitor de Fic��o"));
            leitores.Add(new Leitor("Alessandra", DateTime.Today, "111.111.111-24", "alessandra@outlook.com", "49 99873-4652", "Leitor Casual"));
            leitores.Add(new Leitor("Vinicius", DateTime.Today, "111.111.111-25", "vinicius@bol.com.br", "48 99921-2728", "Leitor de Romance"));
            leitores.Add(new Leitor("Poze", DateTime.Today, "111.111.111-26", "poze@mafia.com", "11 99969-1570", "Leitor de Fic��o"));

            funcionarios.Add(new Funcionario("Carlos", DateTime.Today, "222.222.222-33", "carlos@gmail.com", "49 99132-8978", 1, 9999.99M, 8, "Gerente"));
            funcionarios.Add(new Funcionario("Ana", DateTime.Today, "333.333.333-44", "ana@gmail.com", "49 99987-5432", 2, 3333.33M, 6, "Auxiliar"));
            funcionarios.Add(new Funcionario("Jo�o", DateTime.Today, "444.444.444-55", "joao@gmail.com", "49 99873-4653", 3, 1024.00M, 8, "Caixa"));
            funcionarios.Add(new Funcionario("Paula", DateTime.Today, "555.555.555-66", "paula@gmail.com", "48 99921-2729", 2, 1024.00M, 10, "Auxiliar"));
            funcionarios.Add(new Funcionario("Lucas", DateTime.Today, "666.666.666-77", "lucas@gmail.com", "11 99969-1571", 4, 2222.22M, 2, "Estagi�rio"));

            exemplares.Add(new Livro("O Enigma", "Misterioso", "Fulano Silva", "Editora X", 2021, "Misterio", 1, 100, "Capa Dura", "1234567890"));
            exemplares.Add(new Livro("A Aventura", "Da Jornada", "Ciclano Lima", "Editora Y", 2021, "Novela", 2, 112, "Capa com Relevo", "2345678901"));
            exemplares.Add(new Livro("O Romance", "Do Amor Imposs�vel", "Beltrano Souza", "Editora Z", 2021, "Romance", 3, 132, "Capa Papel Cartao", "3456789012"));
            exemplares.Add(new Livro("A Hist�ria", "Da Era Medieval", "Fulana Castro", "Editora A", 2021, "Cronica", 4, 234, "Capa de Tecido", "4567890123"));
            exemplares.Add(new Livro("Uma Fic��o", "De Outro Mundo", "Cicrana Dias", "Editora B", 2021, "Conto", 5, 432, "Capa Dura", "5678901234"));
            exemplares.Add(new Ebook("E- O Enigma", "Misterioso", "Fulano Silva", "Editora X", 2021, "Misterio", 1, 100, "Capa Digital", "1234567890", "PDF", 266, "https:\\exemplo.com.br"));
            exemplares.Add(new Ebook("E- A Aventura", "Da Jornada", "Ciclano Lima", "Editora Y", 2021, "Novela", 2, 112, "Capa com Relevo", "2345678901", "PDF", 348, "https:\\exemplo.com.br"));
            exemplares.Add(new Ebook("E- O Romance", "Do Amor Imposs�vel", "Beltrano Souza", "Editora Z", 2021, "Romance", 3, 132, "Capa Papel Cartao", "3456789012", "MOBI", 181, "https:\\exemplo.com.br"));
            exemplares.Add(new Ebook("E- A Hist�ria", "Da Era Medieval", "Fulana Castro", "Editora A", 2021, "Cronica", 4, 234, "Capa de Tecido", "4567890123", "PDF", 576, "https:\\exemplo.com.br"));
            exemplares.Add(new Ebook("E- Uma Fic��o", "De Outro Mundo", "Cicrana Dias", "Editora B", 2021, "Romance", 5, 432, "Capa Dura", "5678901234", "PDF", 891, "https:\\exemplo.com.br"));
            exemplares.Add(new Revista("Ci�ncia", "Descobertas", "Fulano Silva", "Editora X", 2021, "DramaHistorico", 1, 3, 100));
            exemplares.Add(new Revista("Moda", "Estilo", "Ciclano Lima", "Editora Y", 2021, "Esportes", 2, 2, 48));
            exemplares.Add(new Revista("Tecnologia", "Inova��es", "Beltrano Souza", "Editora Z", 2021, "DramaHistorico", 3, 8, 150));
            exemplares.Add(new Revista("Sa�de", "Bem-Estar", "Fulana Castro", "Editora A", 2021, "DramaHistorico", 4, 5, 12));
            exemplares.Add(new Revista("Esportes", "Atividades", "Cicrana Dias", "Editora B", 2021, "Esportes", 5, 20, 164));
            exemplares.Add(new Hq("Super-Man", "A Aventura", "Fulano Silva", "Editora X", 2021, "Novela", 1, 43, "Ilustrador A"));
            exemplares.Add(new Hq("Turma da Monica", "Hist�ria em Tiras", "Ciclano Lima", "Editora Y", 2021, "Misterio", 2, 54, "Ilustrador B"));
            exemplares.Add(new Hq("Fantastico", "Mundo M�gico", "Beltrano Souza", "Editora Z", 2021, "Romance", 3, 28, "Ilustrador C"));
            exemplares.Add(new Hq("Her�is", "Da Nova Era", "Fulana Castro", "Editora A", 2021, "Novela", 4, 42, "Ilustrador D"));
            exemplares.Add(new Hq("Behind us", "Outro Universo", "Cicrana Dias", "Editora B", 2021, "DramaHistorico", 5, 98, "Ilustrador E"));
            exemplares.Add(new Generico("Manual", "Como Fazer", "Fulano Silva", "Editora X", 2021, "Cancao", 1, 12));
            exemplares.Add(new Generico("Guia", "Passo a Passo", "Ciclano Lima", "Editora Y", 2021, "Cancao", 2, 12));
            exemplares.Add(new Generico("Tutorial", "Aprenda F�cil", "Beltrano Souza", "Editora Z", 2021, "Cancao", 3, 6));
            exemplares.Add(new Generico("Dicion�rio", "Palavras-cruzadas", "Fulana Castro", "Editora A", 2021, "Cancao", 4, 9));
            exemplares.Add(new Generico("Mapa", "Da Groelandia", "Cicrana Dias", "Editora B", 2021, "DramaHistorico", 5, 3));

            // Adicionando exemplares aos leitores
            leitores[0].AdicionaExemplarLeitor(exemplares[0], leitores[0]);
            leitores[0].AdicionaExemplarLeitor(exemplares[1], leitores[0]);
            leitores[1].AdicionaExemplarLeitor(exemplares[2], leitores[1]);
            leitores[1].AdicionaExemplarLeitor(exemplares[3], leitores[1]);
            leitores[2].AdicionaExemplarLeitor(exemplares[4], leitores[2]);
            leitores[2].AdicionaExemplarLeitor(exemplares[5], leitores[2]);
            leitores[3].AdicionaExemplarLeitor(exemplares[6], leitores[3]);
            leitores[3].AdicionaExemplarLeitor(exemplares[7], leitores[3]);
            leitores[4].AdicionaExemplarLeitor(exemplares[8], leitores[4]);
            leitores[4].AdicionaExemplarLeitor(exemplares[9], leitores[4]);

            // Inicializando o objeto de aluguel de livros
            livroLeitor.Add(new AlugarLivro(leitores, exemplares));

            // Atualizando o DataGridView
            AtualizarDataGridView();
        }

        private void buttonCadPessoa_Click(object sender, EventArgs e)
        {
            var aux = new FormPessoa(funcionarios, leitores);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
            AtualizarDataGridView();
        }

        private void buttonCadExemplar_Click(object sender, EventArgs e)
        {
            var aux = new FormExemplar(exemplares);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
            AtualizarDataGridView();
        }
        private void buttonAnexar_Click(object sender, EventArgs e)
        {
            var form = new FormLivrodoLeitor(leitores, exemplares);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            AtualizarDataGridView();
        }
        private void AtualizarDataGridView()
        {
            // Listar funcion�rios no DataGridView
            dataGridViewFuncionarios.DataSource = null;
            dataGridViewFuncionarios.DataSource = funcionarios;

            // Listar leitores no DataGridView
            dataGridViewLeitores.DataSource = null;
            dataGridViewLeitores.DataSource = leitores;

            // Listar exemplares no DataGridView
            dataGridViewExemplares.DataSource = null;
            dataGridViewExemplares.DataSource = exemplares;

            // Listar livros alugados no DataGridView
            dataGridViewLivroAlugado.DataSource = null;
            dataGridViewLivroAlugado.Rows.Clear();
            dataGridViewLivroAlugado.Columns.Clear();

            dataGridViewLivroAlugado.Columns.Add("Leitor", "Leitor");
            dataGridViewLivroAlugado.Columns.Add("Exemplares", "Exemplares");

            // Percorre todos os leitores para preencher o DataGridView
            foreach (var leitor in leitores)
            {
                // Cria uma lista de t�tulos de exemplares alugados pelo leitor
                List<string> exemplaresTitulos = leitor.ExemplaresLeitor.Select(ex => ex.Titulo).ToList();

                // Adiciona uma �nica linha para o leitor com seus exemplares alugados concatenados
                dataGridViewLivroAlugado.Rows.Add(leitor.Nome, string.Join(", ", exemplaresTitulos));
            }

            // Adiciona o evento CellClick para abrir o formul�rio FormLivrodoLeitor com os dados da linha clicada
            dataGridViewLivroAlugado.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica se o �ndice da linha e coluna s�o v�lidos
                {
                    DataGridViewCell cell = dataGridViewLivroAlugado.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string leitorNome = dataGridViewLivroAlugado.Rows[e.RowIndex].Cells["Leitor"].Value.ToString();

                    // Obt�m o leitor selecionado
                    Leitor leitor = leitores.FirstOrDefault(l => l.Nome == leitorNome);
                    if (leitor != null)
                    {
                        // Obt�m os t�tulos dos exemplares alugados pelo leitor
                        List<string> exemplaresTitulos = leitor.ExemplaresLeitor.Select(ex => ex.Titulo).ToList();

                        // Abre o FormLivrodoLeitor com os dados do leitor e seus exemplares
                        FormLivrodoLeitor formLivrodoLeitor = new FormLivrodoLeitor();
                        formLivrodoLeitor.SetLeitorAndExemplares(leitorNome, exemplaresTitulos);
                        formLivrodoLeitor.ShowDialog();
                    }
                }
            };

        }



        private void dataGridViewLeitores_DoubleClick(object sender, EventArgs e)
        {
            // armazena o objeto selecionado
            var leitor = dataGridViewLeitores.CurrentRow.DataBoundItem as Leitor;
            var form = new FormPessoa(leitores, leitor);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            AtualizarDataGridView();
        }

        private void dataGridViewFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            // armazena o objeto selecionado
            var funcionario = dataGridViewFuncionarios.CurrentRow.DataBoundItem as Funcionario;
            // abre a tela de funcion�rio, utilizando o construtor criado para edi��o
            var form = new FormPessoa(funcionarios, funcionario);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            AtualizarDataGridView();
        }

        private void dataGridViewExemplares_DoubleClick(object sender, EventArgs e)
        {
            // armazena o objeto selecionado
            var exemplar = dataGridViewExemplares.CurrentRow.DataBoundItem as Exemplar;
            var form = new FormExemplar(exemplares, exemplar);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            AtualizarDataGridView();
        }

        private void dataGridViewLivroAlugado_DoubleClick(object sender, EventArgs e)
        {
            var livroAlugado = dataGridViewLivroAlugado.CurrentRow.DataBoundItem as AlugarLivro;
            var form = new FormLivrodoLeitor(leitores, exemplares);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            AtualizarDataGridView();
        }

        private void FormBiblioteca_Load(object sender, EventArgs e)
        {

        }
    }
}
