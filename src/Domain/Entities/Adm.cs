using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.src.Domain.Entities
{
    public class Adm
    {
        [Key] // Indica uma chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indica que é uma classe de identidade
        public int Id { get; set; } = default!;
        [Required] // Torna um campo obrigatorio
        [MaxLength(255)] // Indica o tamanho maximo de caracteres
        public string Email { get; set; } = default!;
        [Required]
        [MaxLength(50)]
        [MinLength(10)] // Indica o tamanho minimo de caracteres
        public string Password { get; set; } = default!;
        [MaxLength(10)]
        public string Perfil { get; set; } = default!;
    }
}
