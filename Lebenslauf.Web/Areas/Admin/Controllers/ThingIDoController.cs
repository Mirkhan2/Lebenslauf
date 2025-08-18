using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class ThingIDoController : AdminBaseController
    {
        #region COnstructor
        private readonly IThingIDoService _thingIDoService;
        public ThingIDoController(IThingIDoService thingIDoService)
        {
            _thingIDoService = thingIDoService;
        }
        #endregion

        #region List
        public async Task<IActionResult> Index()
        {
            return View(await _thingIDoService.GetAllThingIDoForIndex());
        }
        #endregion


    }
}
