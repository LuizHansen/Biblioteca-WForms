using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Biblioteca
{ 
    //luiz Hansen
    public partial class FormExemplar : Form
    {
        List<Exemplar>? exemplares;
        Exemplar? exemplar;

        public FormExemplar(List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.exemplares = exemplares;
        }
        public FormExemplar(List<Exemplar> exemplares, Exemplar exemplar)
        {
            InitializeComponent();
            this.exemplares = exemplares;
            this.exemplar = exemplar;

            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
            comboBoxGenero.DataSource = Enum.GetValues(typeof(EnumExemplarGeneroTipo));
            comboBoxGenero.SelectedIndex = 0;
            comboBoxTipoCapa.DataSource = Enum.GetValues(typeof(EnumExemplarTipoCapa));
            comboBoxTipoCapa.SelectedIndex = 0;
            comboBoxEbook.DataSource = Enum.GetValues(typeof(EnumEbookFormato));
            comboBoxEbook.SelectedIndex = 0;
            listBoxTipoGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipoGenerico.SelectedIndex = 0;

            if (exemplar is Livro || exemplar is Ebook)
            {
                textBoxTitulo.Text = exemplar.Titulo;
                textBoxSubtitulo.Text = exemplar.SubTitulo;
                textBoxEscritor.Text = exemplar.Escritor;
                textBoxEditora.Text = exemplar.Editora;
                numericUpDownAnoPub.Value = exemplar.AnoPublicacao;
                comboBoxGenero.Text = "" + (EnumExemplarGeneroTipo)Enum.Parse(typeof(EnumExemplarGeneroTipo), exemplar.Genero.ToString());
                comboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                numericUpDownPaginas.Value = ((Livro)exemplar).Paginas;
                comboBoxTipoCapa.Text = ((Livro)exemplar).TipoCapa;
                textBoxISBN.Text = ((Livro)exemplar).Isbn;

                checkBoxEbook.Checked = false;
                if (exemplar is Ebook)
                {
                    checkBoxEbook.Checked = true;
                    comboBoxEbook.Text = ((Ebook)exemplar).Formato;
                    numericUpDownTamanhoEbook.Value = ((Ebook)exemplar).Tamanho;
                    textBoxUrl.Text = ((Ebook)exemplar).Url;
                }
            }
            else if (exemplar is Revista revista)
            {
                numericUpDownEdicaoRevista.Value = revista.Edicao;
                numericUpDownPagRevista.Value = revista.Paginas;
            }
            else if (exemplar is Hq hq)
            {
                numericUpDownEdicaoHQ.Value = hq.Edicao;
                textBoxIlustrador.Text = hq.Ilustrador;
            }
            else if(exemplar is Generico generico)
            {
                listBoxTipoGenerico.Text = "" + (EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo),((Generico)exemplar).Tipo.ToString()); 
            }

            if (TabControlExemplar.SelectedIndex == 0)
            {
                TabControlExemplar.SelectedIndex = 0;
                TabControlExemplar.TabPages[1].Enabled = false;
                TabControlExemplar.TabPages[2].Enabled = false;
                TabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;
            }
            else if (TabControlExemplar.SelectedIndex == 1)
            {
                TabControlExemplar.SelectedIndex = 1;
                TabControlExemplar.TabPages[0].Enabled = false;
                TabControlExemplar.TabPages[2].Enabled = false;
                TabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;
            }
            else if (TabControlExemplar.SelectedIndex == 2)
            {
                TabControlExemplar.SelectedIndex = 2;
                TabControlExemplar.TabPages[0].Enabled = false;
                TabControlExemplar.TabPages[1].Enabled = false;
                TabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;
            }
            else if (TabControlExemplar.SelectedIndex == 3)
            {
                TabControlExemplar.SelectedIndex = 3;
                TabControlExemplar.TabPages[0].Enabled = false;
                TabControlExemplar.TabPages[1].Enabled = false;
                TabControlExemplar.TabPages[2].Enabled = false;
                buttonSalvar.Enabled = false;
            }
        }
        public FormExemplar() { }

        private void CadastroExemplar_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
            comboBoxGenero.DataSource = Enum.GetValues(typeof(EnumExemplarGeneroTipo));
            comboBoxGenero.SelectedIndex = 0;
            comboBoxTipoCapa.DataSource = Enum.GetValues(typeof(EnumExemplarTipoCapa));
            comboBoxTipoCapa.SelectedIndex = 0;
            comboBoxEbook.DataSource = Enum.GetValues(typeof(EnumEbookFormato));
            comboBoxEbook.SelectedIndex = 0;
            listBoxTipoGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipoGenerico.SelectedIndex = 0;
        }
        private void checkBoxEbook_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEbook.Enabled = checkBoxEbook.Checked;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxTitulo = textBoxTitulo.Text;
            string auxSubTitulo = textBoxSubtitulo.Text;
            string auxEscritor = textBoxEscritor.Text;
            string auxEditora = textBoxEditora.Text;
            int auxAnoPublicacao = Convert.ToInt32(numericUpDownAnoPub.Value);
            string auxGenero = comboBoxGenero.Text;
            int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (TabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginas.Value);
                string auxTipoCapa = comboBoxTipoCapa.Text;
                string auxIsbn = textBoxISBN.Text;
                if (!checkBoxEbook.Checked)
                {
                    // livro
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Livro(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
                }
                else
                {
                    // ebook
                    // leitura dos valores dos campos
                    string auxFormato = comboBoxEbook.Text;
                    decimal auxTamanho = numericUpDownTamanhoEbook.Value;
                    string auxUrl = textBoxUrl.Text;
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn, auxFormato, auxTamanho, auxUrl));
                }
            }
            else if (TabControlExemplar.SelectedIndex == 1)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                int auxPaginasRevista = Convert.ToInt32(numericUpDownPagRevista.Value);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (TabControlExemplar.SelectedIndex == 2)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(numericUpDownEdicaoHQ.Value);
                string auxIlustrador = textBoxIlustrador.Text;
                // cria o objeto e já adiciona no List
                exemplares.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (TabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listBoxTipoGenerico.Text);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }
            MessageBox.Show("Exemplar cadastrada com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            exemplar.Titulo = textBoxTitulo.Text;
            exemplar.SubTitulo = textBoxSubtitulo.Text;
            exemplar.Escritor = textBoxEscritor.Text;
            exemplar.Editora = textBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(numericUpDownAnoPub.Value);
            exemplar.Genero = comboBoxGenero.Text;
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (exemplar is Livro livro)
            {
                livro.Paginas = Convert.ToInt32(numericUpDownPaginas.Value);
                livro.TipoCapa = comboBoxTipoCapa.Text;
                livro.Isbn = textBoxISBN.Text;
            }
            else if (exemplar is Ebook ebook)
            {
                ebook.Paginas = Convert.ToInt32(numericUpDownPaginas.Value);
                ebook.TipoCapa = comboBoxTipoCapa.Text;
                ebook.Isbn = textBoxISBN.Text;
                ebook.Formato = comboBoxEbook.Text;
                ebook.Tamanho = numericUpDownTamanhoEbook.Value;
                ebook.Url = textBoxUrl.Text;
            }
            else if (exemplar is Revista revista)
            {
                revista.Edicao = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                revista.Paginas = Convert.ToInt32(numericUpDownPagRevista.Value);
            }
            else if (exemplar is Hq hq)
            {
                hq.Edicao = Convert.ToInt32(numericUpDownEdicaoHQ.Value);
                hq.Ilustrador = textBoxIlustrador.Text;
            }
            else if (exemplar is Generico generico)
            {
                generico.Tipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo),listBoxTipoGenerico.Text);
            }
            MessageBox.Show("Exemplar editado com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);
            MessageBox.Show("Exemplar excluído com sucesso!");
            Close();
        }
    }
}
