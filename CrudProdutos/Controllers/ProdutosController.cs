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
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            { 
               return NotFound(); 
            }

            ProdutosModel produtos = _db.Produtos.FirstOrDefault(x => x.Id == id);

            if (produtos == null) 
            {
                return NotFound();
            }

            return View(produtos);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProdutosModel produtos = _db.Produtos.FirstOrDefault(x => x.Id == id); // x é como se representasse as tabelas e as colunas

            if(produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
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

        [HttpPost]
        public IActionResult Editar(ProdutosModel produtos)
        {
            if(ModelState.IsValid)
            {
                _db.Produtos.Update(produtos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        [HttpPost]
        public IActionResult Excluir(ProdutosModel produtos)
        {
            if(produtos == null)
            {
                return NotFound();
            }

            _db.Produtos.Remove(produtos);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
