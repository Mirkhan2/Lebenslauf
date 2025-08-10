using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Page;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class PortfolioController : Controller
    {
        #region COntructor

        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            PortfolioPageViewModel model = new PortfolioPageViewModel()
            {
                Portfolios = await _portfolioService.GetAllPortfolios(),
                PortfolioCategories = await _portfolioService.GetAllPortfolioCategories(),
            };
            return View(model);
        }
    }
}
