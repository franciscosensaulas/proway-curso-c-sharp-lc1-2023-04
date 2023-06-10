using System;
using System.Collections.Generic;
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
        }
    }
}
