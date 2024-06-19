namespace Biblioteca
{
    partial class FormExemplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            Pessoa = new GroupBox();
            comboBoxGenero = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownAnoPub = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            textBoxSubtitulo = new TextBox();
            textBoxEscritor = new TextBox();
            textBoxEditora = new TextBox();
            textBoxTitulo = new TextBox();
            TabControlExemplar = new TabControl();
            Livro = new TabPage();
            checkBoxEbook = new CheckBox();
            groupBoxEbook = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            textBoxUrl = new TextBox();
            comboBoxEbook = new ComboBox();
            numericUpDownTamanhoEbook = new NumericUpDown();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBoxISBN = new TextBox();
            comboBoxTipoCapa = new ComboBox();
            numericUpDownPaginas = new NumericUpDown();
            Revista = new TabPage();
            label9 = new Label();
            label8 = new Label();
            numericUpDownPagRevista = new NumericUpDown();
            numericUpDownEdicaoRevista = new NumericUpDown();
            Hq = new TabPage();
            label11 = new Label();
            label10 = new Label();
            textBoxIlustrador = new TextBox();
            numericUpDownEdicaoHQ = new NumericUpDown();
            tabPageGenerico = new TabPage();
            label12 = new Label();
            listBoxTipoGenerico = new ListBox();
            Pessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPub).BeginInit();
            TabControlExemplar.SuspendLayout();
            Livro.SuspendLayout();
            groupBoxEbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanhoEbook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).BeginInit();
            Revista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagRevista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).BeginInit();
            Hq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHQ).BeginInit();
            tabPageGenerico.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(656, 393);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(117, 35);
            buttonExcluir.TabIndex = 9;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkCyan;
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(533, 393);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(117, 35);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.LimeGreen;
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(410, 393);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(117, 35);
            buttonSalvar.TabIndex = 7;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // Pessoa
            // 
            Pessoa.Controls.Add(comboBoxGenero);
            Pessoa.Controls.Add(label7);
            Pessoa.Controls.Add(label6);
            Pessoa.Controls.Add(label5);
            Pessoa.Controls.Add(label4);
            Pessoa.Controls.Add(label3);
            Pessoa.Controls.Add(label2);
            Pessoa.Controls.Add(label1);
            Pessoa.Controls.Add(numericUpDownAnoPub);
            Pessoa.Controls.Add(comboBoxStatus);
            Pessoa.Controls.Add(textBoxSubtitulo);
            Pessoa.Controls.Add(textBoxEscritor);
            Pessoa.Controls.Add(textBoxEditora);
            Pessoa.Controls.Add(textBoxTitulo);
            Pessoa.Location = new Point(12, 12);
            Pessoa.Name = "Pessoa";
            Pessoa.Size = new Size(355, 392);
            Pessoa.TabIndex = 10;
            Pessoa.TabStop = false;
            Pessoa.Text = "Exemplar";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "1 - Romance", "2 - Novela", "3 - Conto", "4 - Crônica", "5 - Poema", "6 - Canção", "7 - Drama histórico", "8 - Teatro de vanguarda" });
            comboBoxGenero.Location = new Point(6, 262);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(343, 23);
            comboBoxGenero.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 288);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 244);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 200);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Ano Publicação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Escritor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Subtitulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Titulo";
            // 
            // numericUpDownAnoPub
            // 
            numericUpDownAnoPub.Location = new Point(6, 218);
            numericUpDownAnoPub.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownAnoPub.Minimum = new decimal(new int[] { 1400, 0, 0, 0 });
            numericUpDownAnoPub.Name = "numericUpDownAnoPub";
            numericUpDownAnoPub.Size = new Size(343, 23);
            numericUpDownAnoPub.TabIndex = 6;
            numericUpDownAnoPub.Value = new decimal(new int[] { 1400, 0, 0, 0 });
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "1 - Pendente", "2 - Lido", "3 - Emprestado", "4 - Devolvido", "5 - Perdido" });
            comboBoxStatus.Location = new Point(6, 306);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(343, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // textBoxSubtitulo
            // 
            textBoxSubtitulo.Location = new Point(6, 84);
            textBoxSubtitulo.Name = "textBoxSubtitulo";
            textBoxSubtitulo.Size = new Size(343, 23);
            textBoxSubtitulo.TabIndex = 5;
            // 
            // textBoxEscritor
            // 
            textBoxEscritor.Location = new Point(6, 130);
            textBoxEscritor.Name = "textBoxEscritor";
            textBoxEscritor.Size = new Size(343, 23);
            textBoxEscritor.TabIndex = 4;
            // 
            // textBoxEditora
            // 
            textBoxEditora.Location = new Point(6, 174);
            textBoxEditora.Name = "textBoxEditora";
            textBoxEditora.Size = new Size(343, 23);
            textBoxEditora.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(6, 39);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(343, 23);
            textBoxTitulo.TabIndex = 0;
            // 
            // TabControlExemplar
            // 
            TabControlExemplar.Controls.Add(Livro);
            TabControlExemplar.Controls.Add(Revista);
            TabControlExemplar.Controls.Add(Hq);
            TabControlExemplar.Controls.Add(tabPageGenerico);
            TabControlExemplar.Location = new Point(401, 10);
            TabControlExemplar.Name = "TabControlExemplar";
            TabControlExemplar.SelectedIndex = 0;
            TabControlExemplar.Size = new Size(372, 377);
            TabControlExemplar.TabIndex = 11;
            // 
            // Livro
            // 
            Livro.Controls.Add(checkBoxEbook);
            Livro.Controls.Add(groupBoxEbook);
            Livro.Controls.Add(label15);
            Livro.Controls.Add(label14);
            Livro.Controls.Add(label13);
            Livro.Controls.Add(textBoxISBN);
            Livro.Controls.Add(comboBoxTipoCapa);
            Livro.Controls.Add(numericUpDownPaginas);
            Livro.Location = new Point(4, 24);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(364, 349);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            // 
            // checkBoxEbook
            // 
            checkBoxEbook.AutoSize = true;
            checkBoxEbook.Checked = true;
            checkBoxEbook.CheckState = CheckState.Checked;
            checkBoxEbook.Location = new Point(10, 138);
            checkBoxEbook.Name = "checkBoxEbook";
            checkBoxEbook.Size = new Size(69, 19);
            checkBoxEbook.TabIndex = 15;
            checkBoxEbook.Text = "E-BOOK";
            checkBoxEbook.UseVisualStyleBackColor = true;
            checkBoxEbook.CheckedChanged += checkBoxEbook_CheckedChanged;
            // 
            // groupBoxEbook
            // 
            groupBoxEbook.Controls.Add(label18);
            groupBoxEbook.Controls.Add(label17);
            groupBoxEbook.Controls.Add(label16);
            groupBoxEbook.Controls.Add(textBoxUrl);
            groupBoxEbook.Controls.Add(comboBoxEbook);
            groupBoxEbook.Controls.Add(numericUpDownTamanhoEbook);
            groupBoxEbook.Location = new Point(10, 163);
            groupBoxEbook.Name = "groupBoxEbook";
            groupBoxEbook.Size = new Size(336, 180);
            groupBoxEbook.TabIndex = 21;
            groupBoxEbook.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 77);
            label18.Name = "label18";
            label18.Size = new Size(116, 15);
            label18.TabIndex = 22;
            label18.Text = "Tamanho do arquivo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 133);
            label17.Name = "label17";
            label17.Size = new Size(28, 15);
            label17.TabIndex = 21;
            label17.Text = "URL";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 15);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 19;
            label16.Text = "Tipo de Arquivo";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(6, 151);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(324, 23);
            textBoxUrl.TabIndex = 20;
            // 
            // comboBoxEbook
            // 
            comboBoxEbook.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEbook.FormattingEnabled = true;
            comboBoxEbook.Items.AddRange(new object[] { "1 - Portable Document Format (PDF)" });
            comboBoxEbook.Location = new Point(6, 33);
            comboBoxEbook.Name = "comboBoxEbook";
            comboBoxEbook.Size = new Size(324, 23);
            comboBoxEbook.TabIndex = 18;
            // 
            // numericUpDownTamanhoEbook
            // 
            numericUpDownTamanhoEbook.Location = new Point(6, 95);
            numericUpDownTamanhoEbook.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTamanhoEbook.Minimum = new decimal(new int[] { 49, 0, 0, 0 });
            numericUpDownTamanhoEbook.Name = "numericUpDownTamanhoEbook";
            numericUpDownTamanhoEbook.Size = new Size(324, 23);
            numericUpDownTamanhoEbook.TabIndex = 19;
            numericUpDownTamanhoEbook.Value = new decimal(new int[] { 49, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 91);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 17;
            label15.Text = "ISBN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 47);
            label14.Name = "label14";
            label14.Size = new Size(74, 15);
            label14.TabIndex = 16;
            label14.Text = "Tipo de capa";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 3);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 14;
            label13.Text = "Paginas";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(6, 109);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(352, 23);
            textBoxISBN.TabIndex = 14;
            // 
            // comboBoxTipoCapa
            // 
            comboBoxTipoCapa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoCapa.FormattingEnabled = true;
            comboBoxTipoCapa.Items.AddRange(new object[] { "1 - Capa Dura", "2 - Capa Flexível ou Brochura", "3 - Capa de Papel Cartão", "4 - Capa com Sobrecapa (Jacket)", "5 - Capa com Relevo", "6 - Capa com Verniz UV", "7 - Capa Metalizada", "8 - Capa de Tecido", "9 - Capa com Janela", "10 - Capa Transparente", "11 - Capa Digital" });
            comboBoxTipoCapa.Location = new Point(5, 65);
            comboBoxTipoCapa.Name = "comboBoxTipoCapa";
            comboBoxTipoCapa.Size = new Size(353, 23);
            comboBoxTipoCapa.TabIndex = 14;
            // 
            // numericUpDownPaginas
            // 
            numericUpDownPaginas.Location = new Point(5, 21);
            numericUpDownPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPaginas.Minimum = new decimal(new int[] { 49, 0, 0, 0 });
            numericUpDownPaginas.Name = "numericUpDownPaginas";
            numericUpDownPaginas.Size = new Size(353, 23);
            numericUpDownPaginas.TabIndex = 14;
            numericUpDownPaginas.Value = new decimal(new int[] { 49, 0, 0, 0 });
            // 
            // Revista
            // 
            Revista.Controls.Add(label9);
            Revista.Controls.Add(label8);
            Revista.Controls.Add(numericUpDownPagRevista);
            Revista.Controls.Add(numericUpDownEdicaoRevista);
            Revista.Location = new Point(4, 24);
            Revista.Name = "Revista";
            Revista.Padding = new Padding(3);
            Revista.Size = new Size(364, 349);
            Revista.TabIndex = 1;
            Revista.Text = "Revista";
            Revista.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(146, 141);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 7;
            label9.Text = "Paginas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 48);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 6;
            label8.Text = "Edição";
            // 
            // numericUpDownPagRevista
            // 
            numericUpDownPagRevista.Location = new Point(104, 177);
            numericUpDownPagRevista.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPagRevista.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPagRevista.Name = "numericUpDownPagRevista";
            numericUpDownPagRevista.Size = new Size(120, 23);
            numericUpDownPagRevista.TabIndex = 2;
            numericUpDownPagRevista.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // numericUpDownEdicaoRevista
            // 
            numericUpDownEdicaoRevista.Location = new Point(104, 63);
            numericUpDownEdicaoRevista.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEdicaoRevista.Name = "numericUpDownEdicaoRevista";
            numericUpDownEdicaoRevista.Size = new Size(120, 23);
            numericUpDownEdicaoRevista.TabIndex = 1;
            numericUpDownEdicaoRevista.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Hq
            // 
            Hq.Controls.Add(label11);
            Hq.Controls.Add(label10);
            Hq.Controls.Add(textBoxIlustrador);
            Hq.Controls.Add(numericUpDownEdicaoHQ);
            Hq.Location = new Point(4, 24);
            Hq.Name = "Hq";
            Hq.Padding = new Padding(3);
            Hq.Size = new Size(364, 349);
            Hq.TabIndex = 2;
            Hq.Text = "HQ";
            Hq.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(138, 85);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 9;
            label11.Text = "Ilustrador";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 30);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 8;
            label10.Text = "Edição";
            // 
            // textBoxIlustrador
            // 
            textBoxIlustrador.Location = new Point(111, 100);
            textBoxIlustrador.Name = "textBoxIlustrador";
            textBoxIlustrador.Size = new Size(100, 23);
            textBoxIlustrador.TabIndex = 7;
            // 
            // numericUpDownEdicaoHQ
            // 
            numericUpDownEdicaoHQ.Location = new Point(100, 45);
            numericUpDownEdicaoHQ.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEdicaoHQ.Name = "numericUpDownEdicaoHQ";
            numericUpDownEdicaoHQ.Size = new Size(120, 23);
            numericUpDownEdicaoHQ.TabIndex = 2;
            // 
            // tabPageGenerico
            // 
            tabPageGenerico.Controls.Add(label12);
            tabPageGenerico.Controls.Add(listBoxTipoGenerico);
            tabPageGenerico.Location = new Point(4, 24);
            tabPageGenerico.Name = "tabPageGenerico";
            tabPageGenerico.Padding = new Padding(3);
            tabPageGenerico.Size = new Size(364, 349);
            tabPageGenerico.TabIndex = 3;
            tabPageGenerico.Text = "Generico";
            tabPageGenerico.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 14);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 6;
            label12.Text = "Tipo";
            // 
            // listBoxTipoGenerico
            // 
            listBoxTipoGenerico.FormattingEnabled = true;
            listBoxTipoGenerico.ItemHeight = 15;
            listBoxTipoGenerico.Items.AddRange(new object[] { "1 - Jornais", "2 - Calendários e Agendas", "3 - Mapas e Atlas", "4 - Postais e Cartões de Saudação", "5 - Papéis de Presente e Material de Embalagem", "6 - DVDs e Blu-rays", "7 - CDs e Vinis", "8 - K7", "9 - Jogos de Tabuleiro e Quebra-Cabeças", "10 - Material de Papelaria e Escritório", "11 - Produtos Relacionados à Cultura Pop", "12 - Audiolivros", "13 - Outros" });
            listBoxTipoGenerico.Location = new Point(20, 29);
            listBoxTipoGenerico.Name = "listBoxTipoGenerico";
            listBoxTipoGenerico.Size = new Size(299, 289);
            listBoxTipoGenerico.TabIndex = 1;
            // 
            // FormExemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlExemplar);
            Controls.Add(Pessoa);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Name = "FormExemplar";
            Text = "CadastroExemplar";
            Load += CadastroExemplar_Load;
            Pessoa.ResumeLayout(false);
            Pessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPub).EndInit();
            TabControlExemplar.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            groupBoxEbook.ResumeLayout(false);
            groupBoxEbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanhoEbook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).EndInit();
            Revista.ResumeLayout(false);
            Revista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagRevista).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).EndInit();
            Hq.ResumeLayout(false);
            Hq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHQ).EndInit();
            tabPageGenerico.ResumeLayout(false);
            tabPageGenerico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonExcluir;
        private Button buttonEditar;
        private Button buttonSalvar;
        private GroupBox Pessoa;
        private ComboBox comboBoxGenero;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownAnoPub;
        private ComboBox comboBoxStatus;
        private TextBox textBoxSubtitulo;
        private TextBox textBoxEscritor;
        private TextBox textBoxEditora;
        private TextBox textBoxTitulo;
        private TabControl TabControlExemplar;
        private TabPage Livro;
        private TextBox textBoxUrl;
        private NumericUpDown numericUpDownTamanhoEbook;
        private ComboBox comboBoxEbook;
        private Label label15;
        private Label label14;
        private Label label13;
        private CheckBox checkBoxEbook;
        private TextBox textBoxISBN;
        private ComboBox comboBoxTipoCapa;
        private NumericUpDown numericUpDownPaginas;
        private TabPage Revista;
        private Label label9;
        private Label label8;
        private NumericUpDown numericUpDownPagRevista;
        private NumericUpDown numericUpDownEdicaoRevista;
        private TabPage Hq;
        private Label label11;
        private Label label10;
        private TextBox textBoxIlustrador;
        private NumericUpDown numericUpDownEdicaoHQ;
        private TabPage tabPageGenerico;
        private Label label12;
        private ListBox listBoxTipoGenerico;
        private GroupBox groupBoxEbook;
        private Label label18;
        private Label label17;
        private Label label16;
    }
}