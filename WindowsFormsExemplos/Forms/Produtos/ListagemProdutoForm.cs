using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class ListagemProdutoForm : Form
    {
        public ListagemProdutoForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var formulario = new CadastroProdutoForm();
            formulario.Text = "Cadatrar Produto";
            formulario.ShowDialog();
        }
    }
}
