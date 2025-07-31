using CrudProdutos.Data;
using CrudProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudProdutos.Controllers
{
    public class ProdutosController : Controller
    {
        readonly private ApplicationDbContext _db;  // Variável de Leitura

        public ProdutosController(ApplicationDbContext db) // Conectando com o Banco de Dados.
        {
            _db = db;
        }

        public IActionResult Index() // Indo no banco e buscando todos os produtos do banco
        {
            IEnumerable<ProdutosModel> produtos = _db.Produtos; // Pegando a tabela completa
            return View(produtos); // Retornando Tabela do Banco
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ProdutosModel produtos)
        {
            if (ModelState.IsValid)
            {
                _db.Produtos.Add(produtos);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
