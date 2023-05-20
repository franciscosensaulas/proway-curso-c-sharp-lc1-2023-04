using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class FilmeCadastroForm : Form
    {
        public FilmeCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0;
            // ComboBox é uma lista de itens, ou seja, para remover a seleção
            // Atribuímos -1 para o indice do item selecionado.
            comboBoxCategoria.SelectedIndex = -1;
            dateTimePickerDataLancamento.ResetText();
            checkBoxVitoriaGrammy.Checked = false;
            checkBoxVitoriaEmmy.Checked = false;
            checkBoxVitoriaOscar.Checked = false;
            radioButtonFlopouNao.Checked = false;
            radioButtonFlopouSim.Checked = false;

        }
    }
}
