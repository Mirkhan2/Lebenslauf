using Lebenslauf.Application.Services.Implementions;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Application.StaticTools;
using Lebenslauf.Domain.ViewModels.CustomerFeedBack;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom.Compiler;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class CustomerFeedbackController : AdminBaseController
    {

        #region Constructor
        private readonly ICustomerFeedbackService _customerFeedBackService;
        public CustomerFeedbackController(ICustomerFeedbackService customerFeedBackService)
        {
            _customerFeedBackService = customerFeedBackService;
        }
        #endregion


        public async Task<IActionResult> Index()
        {
            return View(await _customerFeedBackService.GetCustomerFeedbackForIndex());
        }

        public async Task<IActionResult> LoadCustomerFeedbackFormModal(long id)
        {
            CreateOrEditCustomerFeedbackViewModel result = await _customerFeedBackService.FillCreateOrEditCustomerFeedbackViewModel(id);
            return PartialView("_CustomerFeedBackFormModalPartial" , result);
        }
        public async Task<IActionResult> SubmitCustomerFeedbackFormModal(CreateOrEditCustomerFeedbackViewModel customerFeedback)
        {
            var result = await _customerFeedBackService.CreateOrEditCustomerFeedback(customerFeedback);

            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteCustomerFeedback(long id)
        {
            var result = await _customerFeedBackService.DeleteCustomerFeedback(id);

            if (result) new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = " Error" });
        }
        public async Task<IActionResult> UploadCustomerFeedbackImageAjax(IFormFile file )
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenericUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxServer(imageName, FilePath.CustomerFeedbackAvatarServer);
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
