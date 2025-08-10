using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Page;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class LebenslaufController : Controller
    {
        #region Contructor

        private readonly IEducationService _educationService;
        private readonly IErfahrungService _erfahrungService;
        private readonly IFahigkeitService _fahigkeitService;
        private readonly IPortfolioService _portfolioService;

        public LebenslaufController(IEducationService educationService, IErfahrungService erfahrungService, IFahigkeitService fahigkeitService, IPortfolioService portfolioService)
        {
            _educationService = educationService;
            _erfahrungService = erfahrungService;
            _fahigkeitService = fahigkeitService;
            _portfolioService = portfolioService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            LebenslaufPageViewModel model = new LebenslaufPageViewModel()
            {
                Educations = await _educationService.GetAllEducations(),
                Erfahrungs = await _erfahrungService.GetAllErfahrungs(),
                Fahigkeits = await _fahigkeitService.GetAllFahigkeits(),
           //     Portfolios = await _portfolioService.GetAllPortfolios(),
                
            };
            return View(model);
        }
    }
}
