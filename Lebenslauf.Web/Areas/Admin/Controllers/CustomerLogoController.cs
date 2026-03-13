using Lebenslauf.Application.Extensions;
using Lebenslauf.Application.Generator;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Application.StaticTools;
using Lebenslauf.Domain.ViewModels.CustomerLogo;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class CustomerLogoController : AdminBaseController
    {
        private readonly ICustomerLogoService _customerLogoService;
        public CustomerLogoController(ICustomerLogoService customerLogoService)
        {
            _customerLogoService = customerLogoService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _customerLogoService.GetCustomerLogoForIndexPage());
        }

        public async Task<IActionResult> LoadCustomerLogoFormModal(long id)
        {
            var result = await _customerLogoService.FillCreateOrEditCustomerLogoViewModel(id);
            return PartialView("_CustomerLogoFormModalPartial", result);
        }

        //[HttpPost]
        //public async Task<IActionResult> SubmitCustomerLogoFormModal(CreateOrEditCustomerLogoViewModel logo)
        //{
        //    var result = await _customerLogoService.CreateOrEditCustomerLogo(logo);
        //    if (result) return new JsonResult(new { status = "Success" });
        //    return new JsonResult(new { status = "Error" });
        //}
        [HttpPost]
        public async Task<IActionResult> SubmitCustomerLogoFormModal(CreateOrEditCustomerLogoViewModel logo)
        {
            if (logo.Id == 0 && string.IsNullOrEmpty(logo.Logo))
            {
                return new JsonResult(new { status = "Error", message = "Bitte laden Sie zuerst ein Logo hoch." });
            }

            var result = await _customerLogoService.CreateOrEditCustomerLogo(logo);
            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteCustomerLogo(long id)
        {
            var result = await _customerLogoService.DeleteCustomerLogo(id);
            if (result) return new JsonResult(new { status = "Success" });
            return new JsonResult(new { status = "Error" });
        }

        [HttpPost]
        public async Task<IActionResult> UploadCustomerLogoImageAjax(IFormFile file)
        {
            if (file != null)
            {
                var ext = Path.GetExtension(file.FileName).ToLower();
                if (ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".svg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + ext;
                    await file.AddImageAjaxToServer(imageName, FilePath.CustomerLogoServer);
                    return new JsonResult(new { status = "Success", imageName = imageName });
                }
            }
            return new JsonResult(new { status = "Error" });
        }
    }
}