using System.ComponentModel.DataAnnotations;

namespace Lebenslauf.Domain.ViewModels.Fahigkeit
{
    public class CreateOrEditFahigkeitViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Thema")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(100, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string Title { get; set; }

        [Display(Name = "Prozent")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(4, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string Percent { get; set; }

        [Display(Name = "Priorität")]
        public int Order { get; set; } = 0;
    }
}