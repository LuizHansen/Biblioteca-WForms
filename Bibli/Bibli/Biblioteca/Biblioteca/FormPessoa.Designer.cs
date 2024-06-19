namespace Biblioteca
{
    partial class FormPessoa
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
            label1 = new Label();
            textBoxNome = new TextBox();
            groupBoxDados = new GroupBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            dateTimePickerNascimento = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tabControlPessoa = new TabControl();
            tabPageLeitor = new TabPage();
            listBoxTipo = new ListBox();
            label6 = new Label();
            tabPageFuncionario = new TabPage();
            textBoxFuncao = new TextBox();
            label10 = new Label();
            label9 = new Label();
            numericUpDownCHoraria = new NumericUpDown();
            label8 = new Label();
            numericUpDownSalario = new NumericUpDown();
            comboBoxCargo = new ComboBox();
            label7 = new Label();
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            groupBoxDados.SuspendLayout();
            tabControlPessoa.SuspendLayout();
            tabPageLeitor.SuspendLayout();
            tabPageFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCHoraria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(20, 53);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(174, 23);
            textBoxNome.TabIndex = 1;
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(maskedTextBoxTelefone);
            groupBoxDados.Controls.Add(maskedTextBoxCPF);
            groupBoxDados.Controls.Add(label5);
            groupBoxDados.Controls.Add(textBoxEmail);
            groupBoxDados.Controls.Add(label4);
            groupBoxDados.Controls.Add(dateTimePickerNascimento);
            groupBoxDados.Controls.Add(label3);
            groupBoxDados.Controls.Add(label2);
            groupBoxDados.Controls.Add(textBoxNome);
            groupBoxDados.Controls.Add(label1);
            groupBoxDados.Location = new Point(12, 12);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(320, 366);
            groupBoxDados.TabIndex = 2;
            groupBoxDados.TabStop = false;
            groupBoxDados.Text = "Dados";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(20, 337);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(172, 23);
            maskedTextBoxTelefone.TabIndex = 11;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(22, 218);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(172, 23);
            maskedTextBoxCPF.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 319);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(20, 275);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(174, 23);
            textBoxEmail.TabIndex = 7;
            textBoxEmail.Text = "exemplo@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 257);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Location = new Point(22, 133);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(200, 23);
            dateTimePickerNascimento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 193);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(tabPageLeitor);
            tabControlPessoa.Controls.Add(tabPageFuncionario);
            tabControlPessoa.Location = new Point(376, 12);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(450, 245);
            tabControlPessoa.TabIndex = 3;
            // 
            // tabPageLeitor
            // 
            tabPageLeitor.Controls.Add(listBoxTipo);
            tabPageLeitor.Controls.Add(label6);
            tabPageLeitor.Location = new Point(4, 24);
            tabPageLeitor.Name = "tabPageLeitor";
            tabPageLeitor.Padding = new Padding(3);
            tabPageLeitor.Size = new Size(442, 217);
            tabPageLeitor.TabIndex = 0;
            tabPageLeitor.Text = "Leitor";
            tabPageLeitor.UseVisualStyleBackColor = true;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[] { "Leitor Casual", "Leitor Avido", "Leitor de Ficção", "Leitor Critico", "Leitor de Classicos", "Leitor Academico" });
            listBoxTipo.Location = new Point(18, 51);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(351, 94);
            listBoxTipo.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 21);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 0;
            label6.Text = "Tipo";
            // 
            // tabPageFuncionario
            // 
            tabPageFuncionario.Controls.Add(textBoxFuncao);
            tabPageFuncionario.Controls.Add(label10);
            tabPageFuncionario.Controls.Add(label9);
            tabPageFuncionario.Controls.Add(numericUpDownCHoraria);
            tabPageFuncionario.Controls.Add(label8);
            tabPageFuncionario.Controls.Add(numericUpDownSalario);
            tabPageFuncionario.Controls.Add(comboBoxCargo);
            tabPageFuncionario.Controls.Add(label7);
            tabPageFuncionario.Location = new Point(4, 24);
            tabPageFuncionario.Name = "tabPageFuncionario";
            tabPageFuncionario.Padding = new Padding(3);
            tabPageFuncionario.Size = new Size(442, 217);
            tabPageFuncionario.TabIndex = 1;
            tabPageFuncionario.Text = "Funcionario";
            tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(272, 97);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(120, 23);
            textBoxFuncao.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(272, 80);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 6;
            label10.Text = "Função";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 19);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 5;
            label9.Text = "Carga Horaria";
            // 
            // numericUpDownCHoraria
            // 
            numericUpDownCHoraria.Location = new Point(272, 37);
            numericUpDownCHoraria.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCHoraria.Name = "numericUpDownCHoraria";
            numericUpDownCHoraria.Size = new Size(120, 23);
            numericUpDownCHoraria.TabIndex = 4;
            numericUpDownCHoraria.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 80);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 3;
            label8.Text = "Salario";
            // 
            // numericUpDownSalario
            // 
            numericUpDownSalario.Location = new Point(31, 98);
            numericUpDownSalario.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(120, 23);
            numericUpDownSalario.TabIndex = 2;
            numericUpDownSalario.Value = new decimal(new int[] { 800, 0, 0, 0 });
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "1 - Gerente", "2 - Atendente", "3 - Caixa", "4 - Estagiário" });
            comboBoxCargo.Location = new Point(31, 37);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(121, 23);
            comboBoxCargo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 19);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 0;
            label7.Text = "Cargo";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.LimeGreen;
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(420, 311);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(117, 35);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkCyan;
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(543, 311);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(117, 35);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(666, 311);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(117, 35);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // FormPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 384);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(tabControlPessoa);
            Controls.Add(groupBoxDados);
            Name = "FormPessoa";
            Text = "CadastroPessoa";
            groupBoxDados.ResumeLayout(false);
            groupBoxDados.PerformLayout();
            tabControlPessoa.ResumeLayout(false);
            tabPageLeitor.ResumeLayout(false);
            tabPageLeitor.PerformLayout();
            tabPageFuncionario.ResumeLayout(false);
            tabPageFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCHoraria).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private GroupBox groupBoxDados;
        private Label label2;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label4;
        private DateTimePicker dateTimePickerNascimento;
        private Label label3;
        private TabControl tabControlPessoa;
        private TabPage tabPageLeitor;
        private TabPage tabPageFuncionario;
        private ListBox listBoxTipo;
        private Label label6;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Label label9;
        private NumericUpDown numericUpDownCHoraria;
        private Label label8;
        private NumericUpDown numericUpDownSalario;
        private ComboBox comboBoxCargo;
        private Label label7;
        private TextBox textBoxFuncao;
        private Label label10;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCPF;
    }
}