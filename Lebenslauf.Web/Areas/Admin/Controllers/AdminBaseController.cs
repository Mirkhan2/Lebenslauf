using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Areas.Controllers
{
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string WarningMessage = "WarningMessage";
        protected string InfoMessage = "InfoMessage";
        protected string ErrorMessage = "ErrorMessage";
    }

}
