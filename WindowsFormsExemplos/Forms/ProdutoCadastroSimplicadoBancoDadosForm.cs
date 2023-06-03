using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadastroSimplicadoBancoDadosForm : Form
    {
        public ProdutoCadastroSimplicadoBancoDadosForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text.Trim());
            var precoUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text.Trim());

            var comando = Conectar();
            comando.CommandText = @"INSERT INTO produtos 
(nome, preco_unitario, quantidade) 
VALUES ('" + nome + "', " + 
    precoUnitario.ToString(CultureInfo.InvariantCulture) + ", " + quantidade + ");";
            comando.ExecuteNonQuery();
            MessageBox.Show("Produto cadastrado com sucesso");
        }

        private SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\proway-curso-c-sharp-lc1-2023-04\WindowsFormsExemplos\BancoDados\WindowsFormsBancoDados.mdf;Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }
    }
}
