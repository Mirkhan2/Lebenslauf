using System.ComponentModel.DataAnnotations;


namespace Lebenslauf.Domain.ViewModels.SocialMedia
{
    public class SocialMediaViewModel
    {

        public  long Id  { get; set; }


        [Display(Name = "Link")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Link { get; set; }


        [Display(Name = "ICon")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        [MaxLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Icon { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; } = 0;
    }
}
