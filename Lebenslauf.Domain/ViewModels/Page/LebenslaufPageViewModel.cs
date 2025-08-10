using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Education;
using Lebenslauf.Domain.ViewModels.Erfahrung;
using Lebenslauf.Domain.ViewModels.Fahigkeit;

namespace Lebenslauf.Domain.ViewModels.Page
{
    public class LebenslaufPageViewModel
    {
        public List<EducationViewModel> Educations { get; set; }
        public List<ErfahrungViewModel> Erfahrungs { get; set; }
        public List<FahigkeitViewModel> Fahigkeits { get; set; }
        public List<PortfolioPageViewModel> Portfolios { get; set; }
    }
}
