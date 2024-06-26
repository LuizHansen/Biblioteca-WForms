namespace Biblioteca
{
    partial class FormBiblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonCadPessoa = new Button();
            buttonCadExemplar = new Button();
            dataGridViewLeitores = new DataGridView();
            tabControlDados = new TabControl();
            tabPageDadosLeitor = new TabPage();
            tabPageDadosFuncionario = new TabPage();
            dataGridViewFuncionarios = new DataGridView();
            tabPageDadosExemplares = new TabPage();
            dataGridViewExemplares = new DataGridView();
            tabPageLivroAlugado = new TabPage();
            dataGridViewLivroAlugado = new DataGridView();
            leitorBindingSource = new BindingSource(components);
            buttonAnexar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).BeginInit();
            tabControlDados.SuspendLayout();
            tabPageDadosLeitor.SuspendLayout();
            tabPageDadosFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            tabPageDadosExemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).BeginInit();
            tabPageLivroAlugado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivroAlugado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonCadPessoa
            // 
            buttonCadPessoa.Location = new Point(24, 57);
            buttonCadPessoa.Name = "buttonCadPessoa";
            buttonCadPessoa.Size = new Size(135, 57);
            buttonCadPessoa.TabIndex = 0;
            buttonCadPessoa.Text = "Cadastrar pessoa";
            buttonCadPessoa.UseVisualStyleBackColor = true;
            buttonCadPessoa.Click += buttonCadPessoa_Click;
            // 
            // buttonCadExemplar
            // 
            buttonCadExemplar.Location = new Point(24, 165);
            buttonCadExemplar.Name = "buttonCadExemplar";
            buttonCadExemplar.Size = new Size(135, 57);
            buttonCadExemplar.TabIndex = 1;
            buttonCadExemplar.Text = "Cadastrar Exemplar";
            buttonCadExemplar.UseVisualStyleBackColor = true;
            buttonCadExemplar.Click += buttonCadExemplar_Click;
            // 
            // dataGridViewLeitores
            // 
            dataGridViewLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeitores.Location = new Point(6, 6);
            dataGridViewLeitores.Name = "dataGridViewLeitores";
            dataGridViewLeitores.Size = new Size(573, 317);
            dataGridViewLeitores.TabIndex = 2;
            dataGridViewLeitores.DoubleClick += dataGridViewLeitores_DoubleClick;
            // 
            // tabControlDados
            // 
            tabControlDados.Controls.Add(tabPageDadosLeitor);
            tabControlDados.Controls.Add(tabPageDadosFuncionario);
            tabControlDados.Controls.Add(tabPageDadosExemplares);
            tabControlDados.Controls.Add(tabPageLivroAlugado);
            tabControlDados.Location = new Point(195, 12);
            tabControlDados.Name = "tabControlDados";
            tabControlDados.SelectedIndex = 0;
            tabControlDados.Size = new Size(593, 357);
            tabControlDados.TabIndex = 4;
            // 
            // tabPageDadosLeitor
            // 
            tabPageDadosLeitor.Controls.Add(dataGridViewLeitores);
            tabPageDadosLeitor.Location = new Point(4, 24);
            tabPageDadosLeitor.Name = "tabPageDadosLeitor";
            tabPageDadosLeitor.Padding = new Padding(3);
            tabPageDadosLeitor.Size = new Size(585, 329);
            tabPageDadosLeitor.TabIndex = 0;
            tabPageDadosLeitor.Text = "Leitor";
            tabPageDadosLeitor.UseVisualStyleBackColor = true;
            // 
            // tabPageDadosFuncionario
            // 
            tabPageDadosFuncionario.Controls.Add(dataGridViewFuncionarios);
            tabPageDadosFuncionario.Location = new Point(4, 24);
            tabPageDadosFuncionario.Name = "tabPageDadosFuncionario";
            tabPageDadosFuncionario.Padding = new Padding(3);
            tabPageDadosFuncionario.Size = new Size(585, 329);
            tabPageDadosFuncionario.TabIndex = 1;
            tabPageDadosFuncionario.Text = "Funcionario";
            tabPageDadosFuncionario.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(6, 6);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(573, 317);
            dataGridViewFuncionarios.TabIndex = 3;
            dataGridViewFuncionarios.DoubleClick += dataGridViewFuncionarios_DoubleClick;
            // 
            // tabPageDadosExemplares
            // 
            tabPageDadosExemplares.Controls.Add(dataGridViewExemplares);
            tabPageDadosExemplares.Location = new Point(4, 24);
            tabPageDadosExemplares.Name = "tabPageDadosExemplares";
            tabPageDadosExemplares.Padding = new Padding(3);
            tabPageDadosExemplares.Size = new Size(585, 329);
            tabPageDadosExemplares.TabIndex = 2;
            tabPageDadosExemplares.Text = "Exemplar";
            tabPageDadosExemplares.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExemplares
            // 
            dataGridViewExemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExemplares.Location = new Point(6, 6);
            dataGridViewExemplares.Name = "dataGridViewExemplares";
            dataGridViewExemplares.Size = new Size(573, 317);
            dataGridViewExemplares.TabIndex = 3;
            dataGridViewExemplares.DoubleClick += dataGridViewExemplares_DoubleClick;
            // 
            // tabPageLivroAlugado
            // 
            tabPageLivroAlugado.Controls.Add(dataGridViewLivroAlugado);
            tabPageLivroAlugado.Location = new Point(4, 24);
            tabPageLivroAlugado.Name = "tabPageLivroAlugado";
            tabPageLivroAlugado.Padding = new Padding(3);
            tabPageLivroAlugado.Size = new Size(585, 329);
            tabPageLivroAlugado.TabIndex = 3;
            tabPageLivroAlugado.Text = "Livros Alugados";
            tabPageLivroAlugado.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLivroAlugado
            // 
            dataGridViewLivroAlugado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivroAlugado.Location = new Point(6, 6);
            dataGridViewLivroAlugado.Name = "dataGridViewLivroAlugado";
            dataGridViewLivroAlugado.Size = new Size(573, 317);
            dataGridViewLivroAlugado.TabIndex = 3;
            dataGridViewLivroAlugado.DoubleClick += dataGridViewLivroAlugado_DoubleClick;
            // 
            // leitorBindingSource
            // 
            leitorBindingSource.DataSource = typeof(Leitor);
            // 
            // buttonAnexar
            // 
            buttonAnexar.Location = new Point(24, 272);
            buttonAnexar.Name = "buttonAnexar";
            buttonAnexar.Size = new Size(135, 57);
            buttonAnexar.TabIndex = 5;
            buttonAnexar.Text = "Anexar Livro";
            buttonAnexar.UseVisualStyleBackColor = true;
            buttonAnexar.Click += buttonAnexar_Click;
            // 
            // FormBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnexar);
            Controls.Add(tabControlDados);
            Controls.Add(buttonCadExemplar);
            Controls.Add(buttonCadPessoa);
            Name = "FormBiblioteca";
            Text = "Form1";
            Load += FormBiblioteca_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).EndInit();
            tabControlDados.ResumeLayout(false);
            tabPageDadosLeitor.ResumeLayout(false);
            tabPageDadosFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            tabPageDadosExemplares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).EndInit();
            tabPageLivroAlugado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivroAlugado).EndInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadPessoa;
        private Button buttonCadExemplar;
        private DataGridView dataGridViewLeitores;
        private TabControl tabControlDados;
        private TabPage tabPageDadosLeitor;
        private TabPage tabPageDadosFuncionario;
        private DataGridView dataGridViewFuncionarios;
        private TabPage tabPageDadosExemplares;
        private DataGridView dataGridViewExemplares;
        private BindingSource leitorBindingSource;
        private Button buttonAnexar;
        private TabPage tabPageLivroAlugado;
        private DataGridView dataGridViewLivroAlugado;
    }
}
