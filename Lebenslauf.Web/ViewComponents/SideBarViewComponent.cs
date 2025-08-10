using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.ViewComponent;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        #region Contructor
        private readonly ISocialMediaService _socialmediaService;
        private readonly IInformationService _informationService;

        public SideBarViewComponent(ISocialMediaService socialmediaService, IInformationService informationService)
        {
            _socialmediaService = socialmediaService;
            _informationService = informationService;
        }

        #endregion
        public async Task<IViewComponentResult> InvokeAsync()
        {

            SideBarViewModel model = new SideBarViewModel()
            {
                SocialMedias = await _socialmediaService.GetAllSocialMedias(),
                Informations = await _informationService.GetInformation()


            };

            return View("SideBar" , model);
        }
    }
}
