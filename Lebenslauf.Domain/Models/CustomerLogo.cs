using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.Models
{
    public class CustomerLogo
    {
        [Key]
        public long Id { get; set; }


        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Bitte {0} wiederholen Sie die Eingabe.")]
        public string Logo { get; set; }


        [Display(Name = "erklarungLogo ")]
        [Required(ErrorMessage = "Bitte {0} wiederholen Sie die Eingabe.")]
        public string LogoAlt { get; set; }


        [Display(Name = "Link")]
        [Required(ErrorMessage = "Bitte {0} wiederholen Sie die Eingabe.")]
        public string Link { get; set; }


        [Display(Name = "Priorität")]
        public int Order { get; set; } = 0;
    }
}
