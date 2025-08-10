using System;
using System.Collections.Generic;
using Lebenslauf.Domain.ViewModels.Information;
using Lebenslauf.Domain.ViewModels.SocialMedia;

namespace Lebenslauf.Domain.ViewModels.ViewComponent
{
    public class SideBarViewModel
    {
        public List<SocialMediaViewModel> SocialMedias { get; set; }
        public InformationViewModel Informations { get; set; }
    }
}
