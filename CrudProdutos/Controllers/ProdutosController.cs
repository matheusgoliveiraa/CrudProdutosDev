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

        public IActionResult Index()
        {
            IEnumerable<ProdutosModel> produtos = _db.Produtos; // Pegando a tabela completa
            
            return View(produtos);
        }
    }
}
