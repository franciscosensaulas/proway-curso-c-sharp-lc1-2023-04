
using ProjetoBiblioteca.Servicos;

Console.Write("Nome: ");
var nome = Console.ReadLine();
Console.Write("Quantidade: ");
var quantidade = Convert.ToInt32(Console.ReadLine());
Console.Write("Preço Unitário: ");
var precoUnitario = Convert.ToDecimal(Console.ReadLine());


var produtoServico = new ProdutoServico();
produtoServico.Cadastrar(nome, precoUnitario, quantidade);

Console.WriteLine("Produto Cadastrado com sucesso");