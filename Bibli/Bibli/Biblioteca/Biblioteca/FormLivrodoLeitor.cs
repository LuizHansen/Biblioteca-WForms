using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                leitoresNomes.Add(leitor.Nome);
            }

            comboBox2.DataSource = leitoresNomes;
        }

        public void definirExemplares()
        {
            List<String> exemplaresNomes = new List<String>();
            foreach (var exemplar in this.exemplares)
            {
                exemplaresNomes.Add(exemplar.Titulo);
            }

            comboBox1.DataSource = exemplaresNomes;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle event if needed
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string leitorNome = comboBox2.SelectedItem.ToString();
            string exemplarTitulo = comboBox1.SelectedItem.ToString();

            Leitor leitorSelecionado = leitores.FirstOrDefault(l => l.Nome == leitorNome);
            Exemplar exemplarSelecionado = exemplares.FirstOrDefault(ex => ex.Titulo == exemplarTitulo);

            if (leitorSelecionado != null && exemplarSelecionado != null)
            {
                leitorSelecionado.AdicionaExemplarLeitor(exemplarSelecionado, leitorSelecionado);
                MessageBox.Show($"Exemplar '{exemplarSelecionado.Titulo}' adicionado ao leitor '{leitorSelecionado.Nome}' com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o exemplar ao leitor. Verifique as seleções e tente novamente.");
            }
        }
    }
}
