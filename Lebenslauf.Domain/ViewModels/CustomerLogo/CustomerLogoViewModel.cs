using System.ComponentModel.DataAnnotations;


namespace Lebenslauf.Domain.ViewModels.CustomerLogo
{
    public class CustomerLogoListViewModel
    {
        public long Id { get; set; }


        [Display(Name = "Logo")]
        public string Logo { get; set; }


        [Display(Name = "Logo Erklarung")]
        public string LogoAlt { get; set; }


        [Display(Name = "Link")]
        public string Link { get; set; }


        [Display(Name = "Priorität")]
        public int Order { get; set; }
    }
}
