using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        [Required(ErrorMessage = "O nome do esporte é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O nome do esporte pode ter no máximo 50 caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quatidade máxima de jogadores por time")]
        [Range(1, 25, ErrorMessage = "A quantidade de jogadores deve ser entre 1 e 25")]

        [Display(Name = "Quantidade de Jogadores")]
        public int? QtdJogadores { get; set; }


    }
}
