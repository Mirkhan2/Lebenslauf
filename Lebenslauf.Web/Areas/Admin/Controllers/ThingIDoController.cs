using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.ThingIDo;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class ThingIDoController : AdminBaseController
    {
        #region Constructor
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

        public async Task<IActionResult> LoadThingIDoFormModal(long id)
        {
            CreateOrEditThingIDoViewModel result = await _thingIDoService.FillCreateOrEditThingIDoViewModel(id);
            return PartialView("_ThingIDoFormModalPartial", result);
        }
        public async Task<IActionResult> SubmitThingIDoFormModal(CreateOrEditThingIDoViewModel thingIDo)
        {
            var result = await _thingIDoService.CreateOrEditThingIDo(thingIDo);

            if (result) return new JsonResult(new { status = "Success"});
            
            return new JsonResult(new {status  = "Error"});

        }
    }
}
