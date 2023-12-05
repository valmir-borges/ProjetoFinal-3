using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        [Display(Name ="Cód. Entrada Produto")]

        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "ProdutoId")]

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data de Entrada")]

        public DateTime DataEntrada { get; set;}

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade da Entrada")]

        public int QuantidadeEntrada { get; set; }
    }
}
