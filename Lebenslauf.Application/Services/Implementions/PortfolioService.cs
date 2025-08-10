
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Portfolio;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class PortfolioService : IPortfolioService
    {
        #region COnstructor
        private readonly AppDbContext _context;
        public PortfolioService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<List<PortfolioViewModel>> GetAllPortfolios()
        {
            List<PortfolioViewModel> portfolios = await _context.Portfolios
                .OrderBy(p => p.Order)
                .Select(p => new PortfolioViewModel()
                {
                    Id = p.Id,
                    Image = p.Image,
                    ImageAlt = p.ImageAlt,
                    Link = p.Link,
                    Order = p.Order,
                    PortfolioCategoryName = p.PortfolioCategory.Name,
                    Title = p.Title
                })
                .ToListAsync();

            return portfolios;
        }
        public async Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategories()
        {
            List<PortfolioCategoryViewModel > portfolio = await _context.PortfolioCategories
                .OrderBy(p => p.Order)
                .Select (p => new PortfolioCategoryViewModel()
                {
                    Id =p.Id,
                    Name = p.Name,
                    Order = p.Order,
                    Title=p.Title,
                })
                .ToListAsync();

            return portfolio;
        }
    



    }
}
