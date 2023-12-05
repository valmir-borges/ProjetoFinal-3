using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Cód. Produto")]

        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]

        public string NomeProduto { get; set; } = string.Empty;

        [Column("QuantidadeEstoque")]
        [Display(Name = "Quantidade em Estoque")]

        public int QuantidadeEstoque { get; set;}

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo do Produto")]

        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }


        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor do Produto")]

        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
