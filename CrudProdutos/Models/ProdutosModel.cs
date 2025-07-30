namespace CrudProdutos.Models
{
    public class ProdutosModel
    {
        public int Id { get; set; } // Referênciar uma Coluna da Tabela

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Preco { get; set; }

        public string Categoria { get; set; }

    }
}
