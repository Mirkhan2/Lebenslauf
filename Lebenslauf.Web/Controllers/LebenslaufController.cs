using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Page;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class LebenslaufController : Controller
    {
        #region Constructor
        private readonly IEducationService _educationService;
        private readonly IFahigkeitService _fahigkeitService;
        private readonly IErfahrungService _erfahrungService;
        public LebenslaufController(IEducationService educationService, IFahigkeitService fahigkeitService, IErfahrungService erfahrungService)
        {
            _educationService = educationService;
            _fahigkeitService = fahigkeitService;
            _erfahrungService = erfahrungService;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            LebenslaufPageViewModel model = new LebenslaufPageViewModel()
            {
                Educations = await _educationService.GetAllEducations(),
                Fahigkeits = await _fahigkeitService.GetAllFahigkeits(),
                Erfahrungs = await _erfahrungService.GetAllErfahrungs()
            };

            return View(model);
        }
    }

}

