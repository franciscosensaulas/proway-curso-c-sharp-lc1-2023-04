using Microsoft.AspNetCore.Mvc;
using ProjetoBiblioteca.Servicos;

namespace WebApplicationExemplo.Controllers
{
    [Route("/produtos")]
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/produtos/cadastrar")]
        public IActionResult Cadastrar(
            [FromQuery] string nome,
            [FromQuery] int quantidade,
            [FromQuery] decimal precoUnitario)
        {
            var produtoServico = new ProdutoServico();
            produtoServico.Cadastrar(nome, precoUnitario, quantidade);
            return Ok("Produto cadastrado");
        }

    }
}
