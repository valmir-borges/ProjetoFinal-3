using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("PaisId")]
        [Display(Name = "Cód. País")]

        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do País")]

        public string PaisNome { get; set; } = string.Empty;
    }
}
