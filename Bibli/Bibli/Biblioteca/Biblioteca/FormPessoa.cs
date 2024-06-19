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
    public partial class FormPessoa : Form
    {
        List<Funcionario>? funcionarios;
        List<Leitor>? leitores;
        Funcionario? funcionario;
        Leitor? leitor;

        public FormPessoa()
        {
        }
        public FormPessoa(List<Funcionario> funcionarios, List<Leitor> leitores)
        {
            InitializeComponent();
            this.funcionarios = funcionarios;
            this.leitores = leitores;
        }

        private void CadastroPessoa_Load(object sender, EventArgs e)
        {
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipoLeitor));
            listBoxTipo.SelectedIndex = 0;
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxNome = textBoxNome.Text;
            DateTime auxData = dateTimePickerNascimento.Value;
            string auxCpf = maskedTextBoxCPF.Text;
            string auxEmail = textBoxEmail.Text;
            string auxTelefone = maskedTextBoxTelefone.Text;
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // leitura dos valores dos campos
                string? auxTipoLeitor = listBoxTipo.SelectedItem.ToString();
                // cria o objeto leitor
                var leitor = new Leitor(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxTipoLeitor);
                // adicionar no list
                leitores.Add(leitor);
            }
            else
            {
                // leitura dos valores dos campos
                int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                decimal auxSalario = numericUpDownSalario.Value;
                int auxCargaHoraria = Convert.ToInt32(numericUpDownCHoraria.Value);
                string auxFuncao = textBoxFuncao.Text;
                // cria o objeto funcionário e já adiciona diretamente
                funcionarios.Add(new Funcionario(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxSalario, auxCargaHoraria, auxFuncao));
            }
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();
        }
        // sobrecarga de construtor, novo construtor com lista de parâmetros diferente
        public FormPessoa(List<Funcionario> funcionarios, Funcionario funcionario)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.funcionario = funcionario;
            this.funcionarios = funcionarios;
            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            // carrega os valores do objeto recebido
            textBoxNome.Text = funcionario.Nome;
            dateTimePickerNascimento.Value = funcionario.Nascimento;
            maskedTextBoxCPF.Text = funcionario.Cpf;
            textBoxEmail.Text = funcionario.Email;
            maskedTextBoxTelefone.Text = funcionario.Telefone;
            comboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            numericUpDownSalario.Value = funcionario.Salario;
            numericUpDownCHoraria.Value = funcionario.CargaHoraria;
            textBoxFuncao.Text = funcionario.Funcao;
            // ajusta a tab e botões
            tabControlPessoa.SelectedIndex = 1;
            tabControlPessoa.TabPages[0].Enabled = false;
            buttonSalvar.Enabled = false;
        }

        public FormPessoa(List<Leitor> leitores, Leitor leitor)
        {
            InitializeComponent();
            this.leitor = leitor;
            this.leitores = leitores;

            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipoLeitor));
            listBoxTipo.SelectedIndex = 0;

            textBoxNome.Text = leitor.Nome;
            dateTimePickerNascimento.Value = leitor.Nascimento;
            maskedTextBoxCPF.Text = leitor.Cpf;
            textBoxEmail.Text = leitor.Email;
            maskedTextBoxTelefone.Text = leitor.Telefone;
            listBoxTipo.SelectedItem = leitor.Tipo.ToString();

            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.TabPages[1].Enabled = false;
            buttonSalvar.Enabled = false;
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                leitor.Nome = textBoxNome.Text;
                leitor.Nascimento = dateTimePickerNascimento.Value;
                leitor.Cpf = maskedTextBoxCPF.Text;
                leitor.Email = textBoxEmail.Text;
                leitor.Telefone = maskedTextBoxTelefone.Text;
                leitor.Tipo = listBoxTipo.SelectedItem.ToString();
            }
            else
            {
                // atualiza os dados no objeto
                funcionario.Nome = textBoxNome.Text;
                funcionario.Nascimento = dateTimePickerNascimento.Value;
                funcionario.Cpf = maskedTextBoxCPF.Text;
                funcionario.Email = textBoxEmail.Text;
                funcionario.Telefone = maskedTextBoxTelefone.Text;
                funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo),
                comboBoxCargo.Text);
                funcionario.Salario = numericUpDownSalario.Value;
                funcionario.CargaHoraria = Convert.ToInt32(numericUpDownCHoraria.Value);
                funcionario.Funcao = textBoxFuncao.Text;
            }
            MessageBox.Show("Pessoa editada com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                leitores.Remove(leitor);
            }
            else
            {
                funcionarios.Remove(funcionario);
            }
            MessageBox.Show("Pessoa excluída com sucesso!");
            Close();
        }
    }
}
