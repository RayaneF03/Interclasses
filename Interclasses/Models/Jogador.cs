using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "O nome do jogador é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do jogador pode ter no máximo 50 caracteres")]
        public string? JogadorName { get; set; }

        [Required(ErrorMessage = "Informe o Numero do jogador")]
        [Range(1, 99, ErrorMessage = "O número do jogador deve ser entre 1 e 99")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe a Posição do jogador")]
        [MaxLength(30, ErrorMessage = "A posição do jogador pode ter no máximo 30 caracteres")]
        public string? Posicao { get; set; }

        [Display(Name = "Time")]

        public int TimeId { get; set; }
        public Time? Time { get; set; }

    }

}
