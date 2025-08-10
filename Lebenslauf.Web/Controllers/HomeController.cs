using System.Diagnostics;
using Lebenslauf.Application.Services.Implementions;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Page;
using Lebenslauf.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor
        private readonly IThingIDoService _thingIDoService;
        private readonly ICustomerFeedBackService _customerFeedbackService;
        private readonly ICustomerLogoService _customerLogoService;


        public HomeController(IThingIDoService thingIDoService, ICustomerFeedBackService customerFeedbackService, ICustomerLogoService customerLogoService)
        {
            _thingIDoService = thingIDoService;
            _customerFeedbackService = customerFeedbackService;
            _customerLogoService = customerLogoService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {

            IndexPageViewModel model = new IndexPageViewModel()
            {
                ThingsIDoList = await _thingIDoService.GetAllThingIDoForIndex(),
                CustomerFeedBackList = await _customerFeedbackService.GetCustomerFeedBackForIndex(),
                CustomerLogoList = await _customerLogoService.GetCustomerLogoForIndexPage()
            };

            return View(model);

        }

    }
}