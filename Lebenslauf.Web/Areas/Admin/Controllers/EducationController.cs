using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Education;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class EducationController : AdminBaseController
    {
        private readonly IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _educationService.GetAllEducations());
        }

        public async Task<IActionResult> LoadEducationFormModal(long id)
        {
            CreateOrEditEducationViewModel result = await _educationService.FillCreateOrEditEducationViewModel(id);
            return PartialView("_EducationFormModalPartial", result);
        }

        [HttpPost] 
        public async Task<IActionResult> SubmitEducationFormModal(CreateOrEditEducationViewModel education)
        {
            var result = await _educationService.CreateOrEditEducation(education);

            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteEducation(long id)
        {
            var result = await _educationService.DeleteEducation(id);

            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }
    }
}