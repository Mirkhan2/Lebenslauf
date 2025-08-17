using Lebenslauf.Web.Areas.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            TempData[SuccessMessage] = SuccessMessage;
            return View();
        }
    }
}
