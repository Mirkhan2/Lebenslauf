using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.CustomerFeedBack;
using Lebenslauf.Domain.ViewModels.CustomerLogo;
using Lebenslauf.Domain.ViewModels.ThingIDo;

namespace Lebenslauf.Domain.ViewModels.Page
{
    public class IndexPageViewModel
    {
        public List<ThingsIDoListViewModel> ThingsIDoList { get; set; }
        public List<CustomerFeedBackViewModel> CustomerFeedBackList { get; set; }
        public List<CustomerLogoListViewModel> CustomerLogoList { get; set; }

    }
}
