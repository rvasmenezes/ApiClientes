using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{

    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("Id")]
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        [Column("NomeCliente")]
        [Display(Description = "Nome do cliente")]
        [MaxLength(30, ErrorMessage = "Este campo deve conter no máximo 30 caracteres")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("Cpf")]
        [Display(Description = "Cpf do cliente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("DataNascimento")]
        [Display(Description = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
