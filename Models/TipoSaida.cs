using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Cód. Tipo de Saída")]

        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Tipo de saída")]

        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
