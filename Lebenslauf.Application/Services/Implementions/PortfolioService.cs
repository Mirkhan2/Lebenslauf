
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
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

        #region Portfolio


        public async Task<Portfolio> GetPortfolioById(long id)
        {
            return await _context.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<PortfolioViewModel>> GetAllPortfolios()
        {
            List<PortfolioViewModel> portfolios = await _context.Portfolios
                .Include(p => p.PortfolioCategory)
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

        public async Task<CreateOrEditPortfolioViewModel> FillCreateOrEditPortfolioViewModel(long id)
        {
            if (id == 0) return new CreateOrEditPortfolioViewModel()
            {
                Id = 0,
                PortfolioCategories = await GetAllPortfolioCategories()
            };

            Portfolio portfolio = await GetPortfolioById(id);

            if (portfolio == null) return new CreateOrEditPortfolioViewModel()
            {
                Id = 0,
                PortfolioCategories = await GetAllPortfolioCategories()
            };

            return new CreateOrEditPortfolioViewModel()
            {
                Id = portfolio.Id,
                Image = portfolio.Image,
                ImageAlt = portfolio.ImageAlt,
                Link = portfolio.Link,
                Order = portfolio.Order,
                Title = portfolio.Title,
                PortfolioCategoryId = portfolio.PortfolioCategoryId,
                PortfolioCategories = await GetAllPortfolioCategories()
            };

        }

        public async Task<bool> CreateOrEditPortfolio(CreateOrEditPortfolioViewModel portfolio)
        {
            if (portfolio.Id == 0)
            {
                var newPortfolio = new Portfolio()
                {
                    Image = portfolio.Image,
                    ImageAlt = portfolio.ImageAlt,
                    Link = portfolio.Link,
                    Order = portfolio.Order,
                    Title = portfolio.Title,
                    PortfolioCategoryId = portfolio.PortfolioCategoryId,
                };
                await _context.Portfolios.AddAsync(newPortfolio);
                await _context.SaveChangesAsync();
                return true;
            }

            Portfolio currnetPortfolio = await GetPortfolioById(portfolio.Id);
            if (currnetPortfolio == null) return false;

            currnetPortfolio.Image = portfolio.Image;
            currnetPortfolio.ImageAlt = portfolio.ImageAlt;
            currnetPortfolio.Link = portfolio.Link;
            currnetPortfolio.Order = portfolio.Order;
            currnetPortfolio.Title = portfolio.Title;
            currnetPortfolio.PortfolioCategoryId = portfolio.PortfolioCategoryId;

            _context.Portfolios.Update(currnetPortfolio);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePortfolio(long id)
        {
            Portfolio portfolio =  await GetPortfolioById(id);
            if (portfolio == null) return false;

            _context.Portfolios.Remove(portfolio);
            await _context.SaveChangesAsync();
            return true;

        }

        #endregion

        #region Portfoliocategory
        public async Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategories()
        {
            List<PortfolioCategoryViewModel> portfolio = await _context.PortfolioCategories
                .OrderBy(p => p.Order)
                .Select(p => new PortfolioCategoryViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Order = p.Order,
                    Title = p.Title,
                })
                .ToListAsync();

            return portfolio;
        }

        public Task<PortfolioCategory> GetAllPortfolioCategoryById(long id)
        {
            return _context.PortfolioCategories.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<CreateOrEditPortfolioCategoryViewModel> FillCreateOrEditPortfolioCategoryViewModel(long id)
        {
            if(id == 0) return new CreateOrEditPortfolioCategoryViewModel() { Id = 0};

            PortfolioCategory portfolioCategory = await GetAllPortfolioCategoryById(id);

            if (portfolioCategory == null) return new CreateOrEditPortfolioCategoryViewModel() { Id = 0 };
            return new CreateOrEditPortfolioCategoryViewModel() 
            {
                Id= portfolioCategory.Id,
                Name = portfolioCategory.Name,
                Order = portfolioCategory.Order,
                Title = portfolioCategory.Title
            };
        }

        public async Task<bool> CreateOrEditPortfolioCategory(CreateOrEditPortfolioCategoryViewModel portfolioCategory)
        {

            if (portfolioCategory.Id == 0)
            {
                var newPorfolioCategory = new PortfolioCategory()
                {
                    Name = portfolioCategory.Name,
                    Order = portfolioCategory.Order,
                    Title = portfolioCategory.Title
                };
                await _context.PortfolioCategories.AddAsync(newPorfolioCategory);
                await _context.SaveChangesAsync();
                return true;
            }

            PortfolioCategory currentportfolioCategory = await GetAllPortfolioCategoryById(portfolioCategory.Id);
            if (currentportfolioCategory == null) return false;

            currentportfolioCategory.Name = portfolioCategory.Name;
            currentportfolioCategory.Order = portfolioCategory.Order;
            currentportfolioCategory.Title = portfolioCategory.Title;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePortfolioCategory(long id)
        {
            PortfolioCategory portfolioCategory = await GetAllPortfolioCategoryById(id);

            if (portfolioCategory == null) return false;

            _context.PortfolioCategories.Remove(portfolioCategory);

            await _context.SaveChangesAsync();

            return true;
        }

        #endregion

    }
}
