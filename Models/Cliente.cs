using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Id")]

        public int Id { get; set; }

        [Column("NomeCliente")]
        [Display(Name = "Nome do Cliente")]

        public string NomeCliente { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de nascimento")]

        public DateTime DataNascimento { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "Cpf do Cliente")]

        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço do Cliente")]

        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Numero da Casa do Cliente")]

        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Bairro do Cliente")]

        public string BairroCliente { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name ="Cidade")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do Cliente")]

        public string TelefoneCliente { get; set; } = string.Empty;

    }
}
