using System.ComponentModel.DataAnnotations;

namespace Lebenslauf.Domain.ViewModels.Erfahrung
{
    public class CreateOrEditErfahrungViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Thema")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(100, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string Title { get; set; }

        [Display(Name = "Datum Anfangen")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MinLength(4, ErrorMessage = "{0} darf nicht kürzer als {1} Zeichen sein.")]
        [MaxLength(4, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string StartDate { get; set; }

        [Display(Name = "Datum Beenden")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MinLength(4, ErrorMessage = "{0} darf nicht kürzer als {1} Zeichen sein.")]
        [MaxLength(4, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string EndDate { get; set; }

        [Display(Name = "Erklärung")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(1000, ErrorMessage = "{0} darf nicht länger als {1} Zeichen sein.")]
        public string Description { get; set; }

        [Display(Name = "Priorität")]
        public int Order { get; set; } = 0;
    }
}