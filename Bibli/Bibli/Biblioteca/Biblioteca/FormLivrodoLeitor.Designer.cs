namespace Biblioteca
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
            buttonEditar = new Button();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(264, 106);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(117, 35);
            buttonExcluir.TabIndex = 11;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkCyan;
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(11, 106);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(117, 35);
            buttonEditar.TabIndex = 10;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(208, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 106);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 20;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 23);
            comboBox2.TabIndex = 21;
            // 
            // FormLivrodoLeitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 158);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Name = "FormLivrodoLeitor";
            Text = "FormLivrodoLeitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExcluir;
        private Button buttonEditar;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
    }
}