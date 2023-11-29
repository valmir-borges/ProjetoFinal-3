using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Cód. Tipo do Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Tipo do Produto Descrição")]

        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
