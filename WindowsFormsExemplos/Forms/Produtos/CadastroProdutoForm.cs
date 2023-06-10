using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class CadastroProdutoForm : Form
    {
        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);

            var produtoServico = new ProdutoServico();
            produtoServico.Cadastrar(nome, precoUnitario, quantidade);

            MessageBox.Show("Produto cadastrado com sucesso");
        }
    }
}
