using System.ComponentModel.DataAnnotations;

namespace CrudProdutos.Models
{
    public class ProdutosModel
    {
        public int Id { get; set; } // Referênciar uma Coluna da Tabela

        [Required(ErrorMessage = "Digite o nome do produto!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite a descrição do produto!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o preço do produto!")]
        public string Preco { get; set; }

        [Required(ErrorMessage = "Digite a categoria do produto!")]
        public string Categoria { get; set; }

    }
}
