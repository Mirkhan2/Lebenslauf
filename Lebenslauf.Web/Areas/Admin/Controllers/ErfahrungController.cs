using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Erfahrung;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class ErfahrungController : AdminBaseController
    {
        #region constructor
        private readonly IErfahrungService _erfahrungService;
        public ErfahrungController(IErfahrungService erfahrungService)
        {
            _erfahrungService = erfahrungService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _erfahrungService.GetAllErfahrungs());
        }
        public async Task<IActionResult> LoadErfahrungFormModal(long id)
        {
            CreateOrEditErfahrungViewModel result = await _erfahrungService.FillCreateOrEditErfahrungViewModel(id);
            return PartialView("_CreateOrEditErfahrungModal", result);
        }
        public async Task<IActionResult> SubmitErfahrungFormModal(CreateOrEditErfahrungViewModel erfahrung)
        {
            var result = await _erfahrungService.CreateOrEditErfahrung(erfahrung);

            if (result) return new JsonResult(new { status ="Success." }); 

            return new JsonResult(new { status = "Error." });
        }
        public async Task<IActionResult> DeleteErfahrung(long id)
        {
            var result = await _erfahrungService.DeleteErfahrung(id);

            if (result) return new JsonResult(new { status = "Success." });

            return new JsonResult(new { status = "Error." });
        }
    }
}
