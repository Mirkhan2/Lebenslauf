using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.CustomerFeedBack
{
    public class CustomerFeedbackViewModel
    {

        public long Id { get; set; }


        public string Avatar { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Bitte {0} Fullen sie Aus")]
        public string Name { get; set; }

        [Display(Name="Description")]
        [Required(ErrorMessage = "Bitte {0} Fullen sie Aus")]
        public string Description { get; set; }

        [Display(Name="Priority")]
        public int Order { get; set; }

    }
}
