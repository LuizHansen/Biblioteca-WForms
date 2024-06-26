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
        List<Exemplar>? exemplares;
        List<Leitor> leitores;
        public FormLivrodoLeitor() { }
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

        }
    }
}
