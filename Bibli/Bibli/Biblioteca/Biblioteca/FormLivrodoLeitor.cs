using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLivrodoLeitor : Form
    {
        private List<Exemplar> exemplares;
        private List<Leitor> leitores;

        public FormLivrodoLeitor()
        {
            InitializeComponent();
        }

        public FormLivrodoLeitor(List<Leitor> leitores, List<Exemplar> exemplares)
        {
            this.exemplares = exemplares;
            this.leitores = leitores;
            InitializeComponent();
            definirLeitores();
            definirExemplares();
        }

        public void definirLeitores()
        {
            List<String> leitoresNomes = new List<String>();
            foreach (var leitor in this.leitores)
            {
                leitoresNomes.Add(leitor.Nome); // Adiciona o nome de cada leitor à lista
            }

            // Configura o comboBox2 para exibir os nomes dos leitores
            comboBox2.DataSource = leitoresNomes;
        }


        public void definirExemplares()
        {
            List<String> exemplaresNomes = new List<String>();

            // Exibe todos os exemplares disponíveis
            foreach (var exemplar in exemplares)
            {
                exemplaresNomes.Add(exemplar.Titulo);
            }

            // Configura o CheckedListBox para exibir os itens disponíveis
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(exemplaresNomes.ToArray());
            checkedListBox1.ColumnWidth = 100; // Define a largura da coluna para ajustar os itens
            checkedListBox1.CheckOnClick = true;
        }



        public void SetLeitorAndExemplares(string leitorNome, List<string> exemplaresTitulos)
        {
            comboBox2.SelectedItem = leitorNome;

            // Limpa e preenche o CheckedListBox com os exemplares do leitor
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(exemplaresTitulos.ToArray());
            checkedListBox1.ColumnWidth = 100; // Define a largura da coluna para ajustar os itens
            checkedListBox1.CheckOnClick = true;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle event if needed
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string leitorNome = comboBox2.SelectedItem.ToString();
            Leitor leitorSelecionado = leitores.FirstOrDefault(l => l.Nome == leitorNome);

            if (leitorSelecionado != null)
            {
                foreach (var checkedItem in checkedListBox1.CheckedItems)
                {
                    string exemplarTitulo = checkedItem.ToString();
                    Exemplar exemplarSelecionado = exemplares.FirstOrDefault(ex => ex.Titulo == exemplarTitulo);

                    if (exemplarSelecionado != null)
                    {
                        leitorSelecionado.AdicionaExemplarLeitor(exemplarSelecionado, leitorSelecionado);
                    }
                }
                MessageBox.Show("Exemplares adicionados ao leitor com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar os exemplares ao leitor. Verifique as seleções e tente novamente.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string leitorNome = comboBox2.SelectedItem?.ToString();
            Leitor leitorSelecionado = leitores.FirstOrDefault(l => l.Nome == leitorNome);

            if (leitorSelecionado != null)
            {
                // Cria uma lista auxiliar para armazenar os exemplares a serem removidos
                var exemplaresARemover = new List<Exemplar>();

                foreach (var checkedItem in checkedListBox1.CheckedItems)
                {
                    string exemplarTitulo = checkedItem.ToString();
                    Exemplar exemplarSelecionado = exemplares.FirstOrDefault(ex => ex.Titulo == exemplarTitulo);

                    if (exemplarSelecionado != null)
                    {
                        exemplaresARemover.Add(exemplarSelecionado);
                    }
                }

                // Remove os exemplares selecionados do leitor
                foreach (var exemplar in exemplaresARemover)
                {
                    leitorSelecionado.RemoveExemplarLeitor(exemplar, leitorSelecionado);
                }

                // Atualiza o CheckedListBox após a exclusão
                definirExemplares();
                MessageBox.Show("Exemplares removidos do leitor com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover os exemplares do leitor. Verifique as seleções e tente novamente.");
            }
        }
    }
}

