using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.CustomerFeedBack
{
    public class CustomerFeedBackViewModel
    {

        public long Id { get; set; }


        public string Avatar { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Display(Name="Description")]
        public string Description { get; set; }

        [Display(Name="Priority")]
        public int Order { get; set; }

    }
}
