using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Education
{
    public class EducationViewModel
    {
        public long Id { get; set; }


        [Display(Name = "AThema")]
        public string Title { get; set; }


        [Display(Name = "Datum Fangte")]
        public string StartDate { get; set; }


        [Display(Name = "ENde Datum ")]
        public string EndDate { get; set; }


        [Display(Name = "Erklarung")]
        public string Description { get; set; }


        [Display(Name = "prioritat")]
        public int Order { get; set; }
    }
}
