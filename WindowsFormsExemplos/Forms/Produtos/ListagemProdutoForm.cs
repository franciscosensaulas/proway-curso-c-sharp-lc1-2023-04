using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsExemplos.Servicos;

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

        private void ListagemProdutoForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            // Obter a lista de produtos
            var produtoServico = new ProdutoServico();
            var produtos = produtoServico.ObterTodos();

            // Remover todas as linhas do DataGridView
            dataGridView1.Rows.Clear();

            // Percorrer a lista dos produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto iterado
                var produto = produtos[i];

                // Adicionar linha no dataGridView com as informações
                // do produto iterado
                dataGridView1.Rows.Add(new object[] {
                    produto.Id,
                    produto.Nome,
                    produto.Quantidade,
                    produto.PrecoUnitario
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
