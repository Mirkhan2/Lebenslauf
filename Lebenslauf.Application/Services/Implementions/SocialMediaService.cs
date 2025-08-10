using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.SocialMedia;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class SocialMediaService : ISocialMediaService
    {
        #region Contructor

        private readonly AppDbContext _context;
        public SocialMediaService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<SocialMediaViewModel>> GetAllSocialMedias()
        {
            List<SocialMediaViewModel> socialMedias = await _context.SocialMedias
                .OrderBy(s => s.Order)
                .Select(s => new SocialMediaViewModel()
                {
                        Icon = s.Icon,
                        Link = s.Link,
                        Order = s.Order,
                        Id = s.Id
                })
                .ToListAsync();
            return socialMedias;
        }
    }
}
