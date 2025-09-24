using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.CustomerFeedBack
{
    public class CreateOrEditCustomerFeedbackViewModel
    {
        public long Id { get; set; }


        [Display(Name = "Avatar")]
        public string Avatar { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Bitte {0} Fullen sie Aus")]
        [MaxLength(100, ErrorMessage = "{0}  = Nicht megr als Characcter {1}  ")]
        public string Name { get; set; }


        [Display(Name = "Bearbeitung")]
        [Required(ErrorMessage = "Bitte {0} Fullen sie Aus")]
        [MaxLength(1000, ErrorMessage = "{0}  = Nicht megr als Characcter {1} ")]
        public string Description { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; }
    }
}
