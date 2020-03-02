using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{

    [Table("Endereco")]
    public class Endereco
    {

        [Key]
        [Column("Id")]
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Column("Logradouro")]
        [Display(Description = "Logradouro")]
        [MaxLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Logradouro { get; set; }

        [Column("Bairro")]
        [Display(Description = "Bairro")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(40, ErrorMessage = "Este campo deve conter no máximo 40 caracteres")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Description = "Cidade")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(40, ErrorMessage = "Este campo deve conter no máximo 40 caracteres")]
        public string Cidade { get; set; }

        [Column("Estado")]
        [Display(Description = "Estado")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(40, ErrorMessage = "Este campo deve conter no máximo 40 caracteres")]
        public string Estado { get; set; }
    }
}
