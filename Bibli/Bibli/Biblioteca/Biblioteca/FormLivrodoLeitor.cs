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
        }
    }
}
