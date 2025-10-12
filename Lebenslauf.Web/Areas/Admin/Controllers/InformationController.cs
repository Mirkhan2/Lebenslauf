using Lebenslauf.Application.Extensions;
using Lebenslauf.Application.Generator;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Application.StaticTools;
using Lebenslauf.Domain.ViewModels.Information;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class InformationController : Controller
    {
        #region Constructor
        private readonly IInformationService _informationService;
        public InformationController(IInformationService informationService)
        {
            _informationService = informationService;
        }

        #endregion
        public async Task<IActionResult> LoadInformationFormModal()
        {
            CreateOrEditInformationViewModel result = await _informationService.FillCreateOrEditInformationViewModel();

            return View("_InformationFormModalPartial", result);
        }
        public async Task<IActionResult> SubmitInformationFormModal(CreateOrEditInformationViewModel information)
        {
            var result = await _informationService.CreateOrEditInformation(information);

            if (result) return new JsonResult(new { status = " Success" });

            return new JsonResult(new { status = " Error" });

        }
        [HttpPost]
        public async Task<IActionResult> UploadInformationAvatarAjax(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".jpeg" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePath.AvatarServer);
                    return new JsonResult(new { status = "Success", imageName = imageName });

                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }
            }
            else
            {
                return new JsonResult(new { status = "Error" });
            }
        }


        [HttpPost]
        public async Task<IActionResult> UploadInformationResumeAjax(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".pdf")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePath.ResumeServer);
                    return new JsonResult(new { status = "Success", imageName = imageName });

                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }
            }
            else
            {
                return new JsonResult(new { status = "Error" });
            }
        }

    }

}
