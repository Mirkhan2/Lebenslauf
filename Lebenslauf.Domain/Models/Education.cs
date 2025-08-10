using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.Models
{
    public class Education
    {

        [Key]
        public long Id { get; set; }


        [Display(Name = "Thema")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Title { get; set; }


        [Display(Name = " Daten anfangen")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        [MaxLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string StartDate { get; set; }


        [Display(Name = " Daten Beenden")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MinLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        [MaxLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string EndDate { get; set; }


        [Display(Name = "erklarung")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(1000, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein.")]
        public string Description { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; } = 0;

    }
}
//Es kann nicht weniger als {1} Zeichen sein.
//Bitte geben Sie {0} ein
