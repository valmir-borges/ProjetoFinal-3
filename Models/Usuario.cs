using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Cód. Usuário")]

        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuário")]

        public string NomeUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "Email do Usuário")]

        public string EmailUsuario {get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha do Usuário")]

        public string SenhaUsuario { get; set; } = string.Empty;
    }
}
