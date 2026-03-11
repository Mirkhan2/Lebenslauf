using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.ViewComponents
{
    public class MetaTagViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View("MetaTag");
        }
    }
}
