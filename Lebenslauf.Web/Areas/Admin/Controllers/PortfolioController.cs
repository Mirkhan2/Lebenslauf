using Lebenslauf.Application.Extensions;
using Lebenslauf.Application.Generator;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Application.StaticTools;
using Lebenslauf.Domain.ViewModels.Portfolio;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class PortfolioController : AdminBaseController
    {
        #region Constructor
        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            return View(await _portfolioService.GetAllPortfolios());
        }

        public async Task<IActionResult> LoadPortfolioFormModal(long id)
        {
            CreateOrEditPortfolioCategoryViewModel result = await _portfolioService.FillCreateOrEditPortfolioCategoryViewModel(id);
            return PartialView("_PortfolioFormModalPartial", result);

        }

        public async Task<IActionResult> SubmitPortfolioFormModal(CreateOrEditPortfolioCategoryViewModel portfolio)
        {
            var result = await _portfolioService.CreateOrEditPortfolioCategory(portfolio);
            if (result) return new JsonResult(new { status = "Success" });
            return new JsonResult(new { status = "Error" });
        }
        public async Task<IActionResult> DeletePortfolio(long id)
        {
            var result = await _portfolioService.DeletePortfolioCategory(id);
            if (result) return new JsonResult(new { status = "Success" });
            return new JsonResult(new { status = "Error" });
        }
        [HttpPost]
        public async Task<IActionResult> UploadPortfolioImageAjax(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePath.CustomerFeedbackAvatar);
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
