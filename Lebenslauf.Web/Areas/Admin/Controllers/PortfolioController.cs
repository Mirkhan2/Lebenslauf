using Lebenslauf.Application.Extensions;
using Lebenslauf.Application.Generator;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Application.StaticTools;
using Lebenslauf.Domain.ViewModels.Portfolio;
using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

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
            CreateOrEditPortfolioViewModel result = await _portfolioService.FillCreateOrEditPortfolioViewModel(id);
            return PartialView("_PortfolioFormModalPartial", result);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitPortfolioFormModal(CreateOrEditPortfolioViewModel portfolio)
        {
            var result = await _portfolioService.CreateOrEditPortfolio(portfolio);
            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeletePortfolio(long id)
        {
            var result = await _portfolioService.DeletePortfolio(id);
            if (result) return new JsonResult(new { status = "Success" });

            return new JsonResult(new { status = "Error" });
        }

        [HttpPost]
        public async Task<IActionResult> UploadPortfolioImageAjax(IFormFile file)
        {
            if (file != null)
            {
                
                var ext = Path.GetExtension(file.FileName).ToLower();

                if (ext == ".png" || ext == ".jpg" || ext == ".jpeg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + ext;
                    await file.AddImageAjaxToServer(imageName, FilePath.PortfolioServer);
                    return new JsonResult(new { status = "Success", imageName = imageName });
                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }
            }
            return new JsonResult(new { status = "Error" });
        }
    }
}