using CrudProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<ProdutosModel> Produtos { get; set; }
    }
}
