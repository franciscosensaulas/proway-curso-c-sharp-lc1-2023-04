using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.BancoDados
{
    internal class BancoDadosExemplo01
    {
        public void Executar()
        {
            /*  CRUD
             *  Create: INSERT INTO nome_tabela (colunas) VALUES (valores);
             *  Read:   SELECT colunas FROM nome_tabela;
             *  Update: UPDATE nome_tabela SET 
             *              nome_coluna = valor_coluna 
             *              WHERE id = id_desejado;
             *  Delete: DELETE FROM nome_tabela WHERE id = id_desejado;
             */
            var conexao = new SqlConnection();

            // ConnectionString nada mais é do que o caminho do banco, assim como, 
            // caso necessário login, senha entre outros.
            
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Desktop\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            Console.WriteLine("Conectou");
        }
    }
}
