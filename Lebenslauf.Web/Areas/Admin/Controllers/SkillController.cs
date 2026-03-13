using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Fahigkeit;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class SkillController : AdminBaseController
    {
        private readonly IFahigkeitService _fahigkeitService;

        public SkillController(IFahigkeitService fahigkeitService)
        {
            _fahigkeitService = fahigkeitService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _fahigkeitService.GetAllFahigkeits());
        }

        public async Task<IActionResult> LoadSkillFormModal(long id)
        {
            var result = await _fahigkeitService.FillCreateOrEditFahigkeitViewModel(id);
            return PartialView("_SkillFormModalPartial", result);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitSkillFormModal(CreateOrEditFahigkeitViewModel skill)
        {
            var result = await _fahigkeitService.CreateOrEditFahigkeit(skill);
            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteSkill(long id)
        {
            var result = await _fahigkeitService.DeleteFahigkeit(id);
            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }
    }
}