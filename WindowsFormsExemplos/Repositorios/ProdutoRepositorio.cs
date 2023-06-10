using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BancoDados;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio
    {
        // CRUD
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"INSERT INTO produtos (nome, preco_unitario, quantidade) 
VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(string nome, decimal precoUnitario, int quantidade, int id)
        {
        }

        public void Apagar(int id)
        {
            // Abrir conexão
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            // Definir o comando
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Executar o comando de apagar o registro
            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodos()
        {
            var produtos = new List<Produto>();
            // Abrir a conexão
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            // Executar o comando de SELECT
            comando.CommandText = "SELECT * FROM produtos";

            // Criar tabela em memória para carregar os registros da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criar a lista de produtos com os produtos do banco de dados
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro(consultado da tabela de produtos) da tabela em memória
                var registro = tabelaEmMemoria.Rows[i];
                
                // Instanciar um objeto da classe Produto
                var produto = new Produto();

                // Preencher as propriedades do objeto do Produto
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                // Adicionar o produto na lista de produtos
                produtos.Add(produto);
            }
            // Retornar a lista de produtos (com os
            // registros da tabela de produtos (Banco de Dados))
            return produtos;
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
