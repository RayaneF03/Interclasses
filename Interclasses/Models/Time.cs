using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        [Required(ErrorMessage = "O nome do time é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do time pode ter no maximo 50 caracteres")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        //relacionamento entre models (tabelas no banco de dados)
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vincular o campo de Id da tabela
        public Esporte? Esporte { get; set; } // Vincular o objeto relacionado ao id acima.
    }
}
