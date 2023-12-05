using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("SaidaProdutoId")]
        [Display(Name = "Cód. Saída Produto")]

        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data da Saída")]

        public DateTime DataSaida { get; set;}

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade da Saída")]

        public int QuantidadeSaida { get;set;}

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]

        public int ClienteId { get; set;}

        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        [Display(Name = "Tipo Saída")]

        public int TipoSaidaId { get; set; }

        public TipoSaida? TipoSaida { get; set; }
    }
}
