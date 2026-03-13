using System.ComponentModel.DataAnnotations;

namespace Lebenslauf.Domain.ViewModels.CustomerLogo
{
    public class CreateOrEditCustomerLogoViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Logo Bild")]
        public string Logo { get; set; }

        [Display(Name = "Logo Erklärung (Alt)")]
        [Required(ErrorMessage = "Bitte {0} eingeben.")]
        public string LogoAlt { get; set; }

        [Display(Name = "Link")]
        [Required(ErrorMessage = "Bitte {0} eingeben.")]
        public string Link { get; set; }

        [Display(Name = "Priorität")]
        public int Order { get; set; } = 0;
    }
}