using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Common;

namespace Lebenslauf.Domain.ViewModels.Message
{
    public class CreateMessageViewModel : GoogleRecaptchaViewModel
    {
        public long Id { get; set; }


        [Display(Name = "Vorname und NachName")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Name { get; set; }


        [Display(Name = "N|Vorname und NachName")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Email { get; set; }


        //[Display(Name = "ICon")]
        //[Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        //[MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        //[MaxLength(4, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        //public string Icon { get; set; }


        [Display(Name = "Message& Text")]
        public string Text { get; set; }
    }
}
