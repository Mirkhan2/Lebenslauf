using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Portfolio
{
    public class CreateOrEditPortfolioCategoryViewModel
    {
        public long Id { get; set; }


        [Display(Name = "THemen")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Title { get; set; }


        [Display(Name = "Date anfanger")]
        [MaxLength(1000, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Link { get; set; }


        [Display(Name = "Foto")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        public string Image { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        public string Name { get; set; }



        [Display(Name = "Prioritat")]
        public int Order { get; set; } = 0;
    }
}
