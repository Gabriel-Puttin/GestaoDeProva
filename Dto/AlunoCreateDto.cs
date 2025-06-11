using System.ComponentModel.DataAnnotations;

namespace GestaoDeProvas.Dto
{
    public class AlunoCreateDto
    {
        [Required]
        public string? Nome { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Senha { get; set; }
    }
}