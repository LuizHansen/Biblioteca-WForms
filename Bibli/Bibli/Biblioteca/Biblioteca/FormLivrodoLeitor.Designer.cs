﻿namespace Biblioteca
{
    partial class FormLivrodoLeitor
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
            label1 = new Label();
            label3 = new Label();
            salvar = new Button();
            comboBox2 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(226, 106);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(117, 35);
            buttonExcluir.TabIndex = 11;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 23);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 17;
            label3.Text = "Exemplar alugado";
            // 
            // salvar
            // 
            salvar.BackColor = Color.ForestGreen;
            salvar.ForeColor = Color.White;
            salvar.Location = new Point(28, 106);
            salvar.Name = "salvar";
            salvar.Size = new Size(124, 35);
            salvar.TabIndex = 20;
            salvar.Text = "Salvar";
            salvar.UseVisualStyleBackColor = false;
            salvar.Click += salvar_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 21;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(208, 41);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(153, 22);
            checkedListBox1.TabIndex = 22;
            // 
            // FormLivrodoLeitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 158);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox2);
            Controls.Add(salvar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonExcluir);
            Name = "FormLivrodoLeitor";
            Text = "FormLivrodoLeitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExcluir;
        private Label label1;
        private Label label3;
        private Button salvar;
        private ComboBox comboBox2;
        private CheckedListBox checkedListBox1;
    }
}