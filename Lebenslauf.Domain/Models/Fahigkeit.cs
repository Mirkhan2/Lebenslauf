using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.Models
{
    public class Fahigkeit
    {
        [Key]
        public long Id { get; set; }


        [Display(Name = "Thema")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Title { get; set; }


        [Display(Name = "Prosent")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        [MaxLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Percent { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; } = 0;
    }
}
