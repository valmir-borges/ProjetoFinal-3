using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Cód. Fornecedor")]

        public int Id { get; set; }

        [Column("NomeFornecedor")]
        [Display(Name = "Nome do Fornecedor")]

        public string NomeFornecedor { get; set; } = string.Empty;

        [Column("EmailFornecedor")]
        [Display(Name = "Email do Fornecedor")]

        public string EmailFornecedor { get; set; } = string.Empty;

        [Column("CnpjFornecedor")]
        [Display(Name = "CNPJ do Fornecedor")]

        public string CnpjFornecedor { get; set; } = string.Empty;
    }
}
