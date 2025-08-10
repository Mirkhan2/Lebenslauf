

using Lebenslauf.Domain.ViewModels.SocialMedia;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface ISocialMediaService
    {
        Task<List<SocialMediaViewModel>> GetAllSocialMedias();
    }
}
