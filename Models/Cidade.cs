using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]

        public string CidadeNome { get;set; } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "EstadoId")]

        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
