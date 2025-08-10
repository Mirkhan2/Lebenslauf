using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Information
{
    public class InformationViewModel
    {
        public long Id { get; set; }


        [Display(Name = "Avatar")]
        public string Avatar { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Arbeit")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Job { get; set; }


        [Display(Name = "Geburstag")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string DateOfBirth { get; set; }


        [Display(Name = "Address")]
        [MaxLength(1000, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Address { get; set; }


        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Email { get; set; }


        [Display(Name = "HandyNummer")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string Phone { get; set; }


        [Display(Name = "Lebenslauf FIle")]
        [MaxLength(100, ErrorMessage = "{0} Es kann nicht weniger als {1} Zeichen sein.")]
        public string ResumeFile { get; set; }
    }
}
